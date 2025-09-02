#pragma once

#include "Layer.h"

using namespace System;
using namespace System::Collections;
using namespace System::Collections::Generic;
using namespace System::Drawing;
using namespace System::IO;

/*

File Format:

--- Header ---
* Layers count: 4 bytes int
* Image width: 4 bytes int
* Image height: 4 bytes int
* Layer table offset: 4 bytes int

--- Layers data ---

--- Layer table ---
Size: (Layers count) x Record size

--- Layer table record ---
* Layer name: string
* Layer visibility: 1 byte bool
* Layer data offset: 4 bytes int
* Layer data size: 4 bytes int

*/

ref class LayeredImage {
private:
	LayeredImage() { ; }
	~LayeredImage() { ; }

public:
	static void saveToFile(String^ filename, array<Layer^>^ layers) {
		if (layers->Length == 0) {
			return;
		}

		auto count = layers->Length;
		auto size = layers[0]->getSize();

		FileStream^ fs = gcnew FileStream(filename, FileMode::Create, FileAccess::Write);
		BinaryWriter^ writer = gcnew BinaryWriter(fs);

		//Header
		writer->Write(count);
		writer->Write(size.Width);
		writer->Write(size.Height);
		
		int layerTableOffset = 0;
		auto offsetTable = gcnew array<int>(count);
		auto sizeTable = gcnew array<int>(count);

		writer->Write(layerTableOffset); //Write a layer table offset (0 temporary)

		//Layer data
		for (int i = 0; i < count; i++) {
			auto layer = layers[i];
			Stream^ dataStream = layer->getDataStream();

			offsetTable[i] = (int)fs->Position;
			sizeTable[i] = (int)dataStream->Length;

			dataStream->CopyTo(fs);
		}

		//Layer table
		layerTableOffset = (int)fs->Position;

		for (int i = 0; i < count; i++) {
			auto layer = layers[i];

			writer->Write(layer->name);
			writer->Write(layer->isVisible);
			writer->Write(offsetTable[i]);
			writer->Write(sizeTable[i]);
		}

		//Write layer table offset
		fs->Seek(0x0C, SeekOrigin::Begin);
		writer->Write(layerTableOffset);

		fs->Flush();
		fs->Close();
	}

	static array<Layer^>^ loadFromFile(String^ filename) {	
		if (!File::Exists(filename)) {
			return nullptr;
		}

		FileStream^ fs = gcnew FileStream(filename, FileMode::Open, FileAccess::Read);
		BinaryReader^ reader = gcnew BinaryReader(fs);

		int count = reader->ReadInt32();

		if (count == 0) {
			fs->Close();
			return nullptr;
		}

		auto layers = gcnew array<Layer^>(count);

		//Header
		int width = reader->ReadInt32();
		int height = reader->ReadInt32();
		int layerTableOffset = reader->ReadInt32();

		fs->Seek(layerTableOffset, SeekOrigin::Begin);

		for (int i = 0; i < count; i++) {
			String^ name = reader->ReadString();
			bool isVisible = reader->ReadBoolean();
			int offset = reader->ReadInt32();
			int size = reader->ReadInt32();

			int currentTableOffset = fs->Position;

			//Read layer data
			fs->Seek(offset, SeekOrigin::Begin);

			MemoryStream^ ms = gcnew MemoryStream();
			auto rawData = reader->ReadBytes(size);
			ms->Write(rawData, 0, size);

			Layer^ layer = gcnew Layer(name, isVisible, ms);
			layers[i] = layer;

			delete ms;

			fs->Seek(currentTableOffset, SeekOrigin::Begin);
		}

		return layers;
	}
};