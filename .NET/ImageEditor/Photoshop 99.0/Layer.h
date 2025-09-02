#pragma once

using namespace System;
using namespace System::Drawing;
using namespace System::Drawing::Imaging;
using namespace System::IO;
ref class Layer {
private:
	
	
public:
	Image^ image;
	String^ name;
	bool isVisible;
	Graphics^ graphics;
	Layer(int width, int height, String^ name) {
		this->name = name;
		image = gcnew Bitmap(width, height);
		graphics = Graphics::FromImage(image);
		
		
		isVisible = true;
	}
	
	Layer(String^ name, bool visible, Stream^ dataStream) {
		this->name = name;
		isVisible = visible;

		image = Image::FromStream(dataStream);
		graphics = Graphics::FromImage(image);
	}
	
	~Layer() {
		delete image;
	}

	void drawLine(Pen^ pen, int xFrom, int yFrom, int xTo, int yTo) {
		graphics->DrawLine(pen, xFrom, yFrom, xTo, yTo);
	}

	void drawBrush(Brush^ brush, float xFrom, float yFrom, float width, float height) {
		graphics->FillEllipse(brush, xFrom, yFrom, width, height);
	}

	void drawNormalLine(Pen^ pen, int xFrom, int yFrom, int xTo, int yTo) {
		graphics->DrawLine(pen, xFrom, yFrom, xTo, yTo);
	}

	void drawRectangle(Brush^ brush, float xFrom, float yFrom, float width, float height) {
		graphics->FillRectangle(brush, xFrom, yFrom, width, height);
		
	}

	void PolygonRectangle(Pen^ pen, float xFrom, float yFrom, float width, float height) {
		graphics->DrawRectangle(pen, xFrom, yFrom, width, height);
	}

	void drawEllipse(Brush^ brush, float xFrom, float yFrom, float width, float height) {
		graphics->FillEllipse(brush, xFrom, yFrom, width, height);
	}

	void PolygonEllipse(Pen^ pen, float xFrom, float yFrom, float width, float height) {
		graphics->DrawEllipse(pen, xFrom, yFrom, width, height);
	}

	void render(Graphics^ target) {
		if (!isVisible) {
			return;
		}

		target->DrawImage(image, 0, 0);
	}
	
	Image^ previewImage(int size) {
		Image^ preview = gcnew Bitmap(size, size);
		Graphics^ g = Graphics::FromImage(preview);
		g->DrawImage(image, 0, 0, size, size);
		return preview;
	}
	
	Size getSize() {
		return image->Size;
	}

	Stream^ getDataStream() {
		MemoryStream^ stream = gcnew MemoryStream();
		image->Save(stream, ImageFormat::Png);
		stream->Seek(0, SeekOrigin::Begin);
		
		return stream;
	}
};