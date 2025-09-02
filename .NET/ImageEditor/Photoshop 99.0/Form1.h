#pragma once
#include <math.h>
#include <windows.h>
#include "Layer.h"
#include "LayeredImage.h"

namespace CppCLR_WinformsProjekt {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Collections::Generic;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;


	/// <summary>
	/// Zusammenfassung f�r Form1
	/// </summary>
	public ref class Form1 : public System::Windows::Forms::Form
	{
	public:
		Form1(void)
		{
			InitializeComponent();
			//
			//TODO: Konstruktorcode hier hinzuf�gen.
			//
		}

	protected:
		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		~Form1()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::PictureBox^  pictureBox1;
	protected:
	private: System::Windows::Forms::StatusStrip^  statusStrip1;








	private: System::Windows::Forms::Panel^  panel1;





	private: System::Windows::Forms::ToolStripMenuItem^  ����ToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  �������ToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  firstImageToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  �������ToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  ���������ToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  ������������ToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  �����ToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  �����������ToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  �����ToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  �����ToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  �������������ToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  ������ToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  ����������ToolStripMenuItem;


	private: System::Windows::Forms::ToolStripMenuItem^  ����ToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  �������ToolStripMenuItem1;
	private: System::Windows::Forms::ToolStripMenuItem^  �������ToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  �����������ToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  ����ToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  �������ToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  ������ToolStripMenuItem;
	private: System::Windows::Forms::MenuStrip^  menuStrip1;


	private: System::Windows::Forms::ToolStripMenuItem^  ������ToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  toolStripMenuItem2;
	private: System::Windows::Forms::ToolStripMenuItem^  toolStripMenuItem3;
	private: System::Windows::Forms::ToolStripMenuItem^  toolStripMenuItem4;
	private: System::Windows::Forms::ToolStripMenuItem^  toolStripMenuItem5;
	private: System::Windows::Forms::ToolStripMenuItem^  toolStripMenuItem6;
	private: System::Windows::Forms::ToolStripMenuItem^  toolStripMenuItem7;
	private: System::Windows::Forms::ToolStripMenuItem^  toolStripMenuItem8;
	private: System::Windows::Forms::ToolStrip^  toolStrip1;
	private: System::Windows::Forms::ToolStripMenuItem^  �������ToolStripMenuItem;
	private: System::Windows::Forms::ListBox^  listBox1;
	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::ColorDialog^  colorDialog1;
private: System::Windows::Forms::ToolStripMenuItem^  ������ToolStripMenuItem1;
private: System::Windows::Forms::PictureBox^  pictureBox2;
private: System::Windows::Forms::TrackBar^  trackBar1;
private: System::Windows::Forms::Button^  button1;


private: System::Windows::Forms::ToolStripMenuItem^  saveAstestToolStripMenuItem;
private: System::Windows::Forms::ToolStripMenuItem^  opentestToolStripMenuItem;
private: System::Windows::Forms::ToolStripMenuItem^  �������ToolStripMenuItem;
private: System::Windows::Forms::ToolStripStatusLabel^  ForX;
private: System::Windows::Forms::ToolStripStatusLabel^  ForY;
private: System::Windows::Forms::ToolStripMenuItem^  �������ToolStripMenuItem1;
private: System::Windows::Forms::ToolStripMenuItem^  ���������ToolStripMenuItem;









	private:
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Erforderliche Methode f�r die Designerunterst�tzung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor ge�ndert werden.
		/// </summary>
		void InitializeComponent(void)
		{
			this->pictureBox1 = (gcnew System::Windows::Forms::PictureBox());
			this->statusStrip1 = (gcnew System::Windows::Forms::StatusStrip());
			this->ForX = (gcnew System::Windows::Forms::ToolStripStatusLabel());
			this->ForY = (gcnew System::Windows::Forms::ToolStripStatusLabel());
			this->panel1 = (gcnew System::Windows::Forms::Panel());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->pictureBox2 = (gcnew System::Windows::Forms::PictureBox());
			this->trackBar1 = (gcnew System::Windows::Forms::TrackBar());
			this->����ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->�������ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->firstImageToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->���������ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->opentestToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->saveAstestToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->�������ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->������������ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->�����ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->�����������ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->�����ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->�����ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->�������������ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->������ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->����������ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->������ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->toolStripMenuItem2 = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->toolStripMenuItem3 = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->toolStripMenuItem4 = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->toolStripMenuItem5 = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->toolStripMenuItem6 = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->toolStripMenuItem7 = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->toolStripMenuItem8 = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->�������ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->����ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->�������ToolStripMenuItem1 = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->�������ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->�����������ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->�������ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->����ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->�������ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->������ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->�������ToolStripMenuItem1 = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->menuStrip1 = (gcnew System::Windows::Forms::MenuStrip());
			this->������ToolStripMenuItem1 = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->toolStrip1 = (gcnew System::Windows::Forms::ToolStrip());
			this->listBox1 = (gcnew System::Windows::Forms::ListBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->colorDialog1 = (gcnew System::Windows::Forms::ColorDialog());
			this->���������ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox1))->BeginInit();
			this->statusStrip1->SuspendLayout();
			this->panel1->SuspendLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox2))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->trackBar1))->BeginInit();
			this->menuStrip1->SuspendLayout();
			this->SuspendLayout();
			// 
			// pictureBox1
			// 
			this->pictureBox1->BackColor = System::Drawing::SystemColors::ActiveBorder;
			this->pictureBox1->Cursor = System::Windows::Forms::Cursors::Cross;
			this->pictureBox1->Location = System::Drawing::Point(3, 3);
			this->pictureBox1->Name = L"pictureBox1";
			this->pictureBox1->Size = System::Drawing::Size(400, 246);
			this->pictureBox1->SizeMode = System::Windows::Forms::PictureBoxSizeMode::Zoom;
			this->pictureBox1->TabIndex = 2;
			this->pictureBox1->TabStop = false;
			this->pictureBox1->Paint += gcnew System::Windows::Forms::PaintEventHandler(this, &Form1::pictureBox1_Paint_1);
			this->pictureBox1->MouseClick += gcnew System::Windows::Forms::MouseEventHandler(this, &Form1::pictureBox1_MouseClick);
			this->pictureBox1->MouseDown += gcnew System::Windows::Forms::MouseEventHandler(this, &Form1::pictureBox1_MouseDown_1);
			this->pictureBox1->MouseMove += gcnew System::Windows::Forms::MouseEventHandler(this, &Form1::pictureBox1_MouseMove_1);
			this->pictureBox1->MouseUp += gcnew System::Windows::Forms::MouseEventHandler(this, &Form1::pictureBox1_MouseUp_1);
			// 
			// statusStrip1
			// 
			this->statusStrip1->Items->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(2) { this->ForX, this->ForY });
			this->statusStrip1->Location = System::Drawing::Point(0, 354);
			this->statusStrip1->Name = L"statusStrip1";
			this->statusStrip1->Size = System::Drawing::Size(647, 22);
			this->statusStrip1->TabIndex = 3;
			this->statusStrip1->Text = L"statusStrip1";
			// 
			// ForX
			// 
			this->ForX->Name = L"ForX";
			this->ForX->Size = System::Drawing::Size(17, 17);
			this->ForX->Text = L"X:";
			// 
			// ForY
			// 
			this->ForY->Name = L"ForY";
			this->ForY->Size = System::Drawing::Size(20, 17);
			this->ForY->Text = L"Y: ";
			// 
			// panel1
			// 
			this->panel1->Anchor = static_cast<System::Windows::Forms::AnchorStyles>((((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Bottom)
				| System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->panel1->AutoScroll = true;
			this->panel1->Controls->Add(this->button1);
			this->panel1->Controls->Add(this->pictureBox2);
			this->panel1->Controls->Add(this->trackBar1);
			this->panel1->Controls->Add(this->pictureBox1);
			this->panel1->ImeMode = System::Windows::Forms::ImeMode::NoControl;
			this->panel1->Location = System::Drawing::Point(0, 49);
			this->panel1->Name = L"panel1";
			this->panel1->Size = System::Drawing::Size(470, 305);
			this->panel1->TabIndex = 3;
			// 
			// button1
			// 
			this->button1->BackColor = System::Drawing::SystemColors::Menu;
			this->button1->Enabled = false;
			this->button1->Location = System::Drawing::Point(340, 100);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(34, 23);
			this->button1->TabIndex = 13;
			this->button1->Text = L"Exc";
			this->button1->UseVisualStyleBackColor = false;
			this->button1->Visible = false;
			this->button1->Click += gcnew System::EventHandler(this, &Form1::button1_Click);
			// 
			// pictureBox2
			// 
			this->pictureBox2->BackColor = System::Drawing::SystemColors::HotTrack;
			this->pictureBox2->Enabled = false;
			this->pictureBox2->Location = System::Drawing::Point(192, 109);
			this->pictureBox2->Name = L"pictureBox2";
			this->pictureBox2->Size = System::Drawing::Size(171, 82);
			this->pictureBox2->TabIndex = 4;
			this->pictureBox2->TabStop = false;
			this->pictureBox2->Visible = false;
			// 
			// trackBar1
			// 
			this->trackBar1->BackColor = System::Drawing::SystemColors::HotTrack;
			this->trackBar1->Enabled = false;
			this->trackBar1->Location = System::Drawing::Point(192, 129);
			this->trackBar1->Maximum = 30;
			this->trackBar1->Minimum = 1;
			this->trackBar1->Name = L"trackBar1";
			this->trackBar1->Size = System::Drawing::Size(171, 45);
			this->trackBar1->TabIndex = 3;
			this->trackBar1->Value = 1;
			this->trackBar1->Visible = false;
			this->trackBar1->Scroll += gcnew System::EventHandler(this, &Form1::trackBar1_Scroll);
			this->trackBar1->ValueChanged += gcnew System::EventHandler(this, &Form1::trackBar1_ValueChanged);
			// 
			// ����ToolStripMenuItem
			// 
			this->����ToolStripMenuItem->DropDownItems->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(7) {
				this->�������ToolStripMenuItem,
					this->���������ToolStripMenuItem, this->opentestToolStripMenuItem, this->saveAstestToolStripMenuItem, this->�������ToolStripMenuItem,
					this->������������ToolStripMenuItem, this->�����ToolStripMenuItem
			});
			this->����ToolStripMenuItem->Name = L"����ToolStripMenuItem";
			this->����ToolStripMenuItem->Size = System::Drawing::Size(48, 20);
			this->����ToolStripMenuItem->Text = L"����";
			// 
			// �������ToolStripMenuItem
			// 
			this->�������ToolStripMenuItem->DropDownItems->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(1) { this->firstImageToolStripMenuItem });
			this->�������ToolStripMenuItem->Name = L"�������ToolStripMenuItem";
			this->�������ToolStripMenuItem->Size = System::Drawing::Size(180, 22);
			this->�������ToolStripMenuItem->Text = L"�������";
			this->�������ToolStripMenuItem->Click += gcnew System::EventHandler(this, &Form1::�������ToolStripMenuItem_Click);
			// 
			// firstImageToolStripMenuItem
			// 
			this->firstImageToolStripMenuItem->Name = L"firstImageToolStripMenuItem";
			this->firstImageToolStripMenuItem->Size = System::Drawing::Size(129, 22);
			this->firstImageToolStripMenuItem->Text = L"FirstImage";
			this->firstImageToolStripMenuItem->Click += gcnew System::EventHandler(this, &Form1::firstImageToolStripMenuItem_Click_1);
			// 
			// ���������ToolStripMenuItem
			// 
			this->���������ToolStripMenuItem->Name = L"���������ToolStripMenuItem";
			this->���������ToolStripMenuItem->Size = System::Drawing::Size(180, 22);
			this->���������ToolStripMenuItem->Text = L"���������";
			// 
			// opentestToolStripMenuItem
			// 
			this->opentestToolStripMenuItem->Name = L"opentestToolStripMenuItem";
			this->opentestToolStripMenuItem->Size = System::Drawing::Size(180, 22);
			this->opentestToolStripMenuItem->Text = L"�������";
			this->opentestToolStripMenuItem->Click += gcnew System::EventHandler(this, &Form1::opentestToolStripMenuItem_Click);
			// 
			// saveAstestToolStripMenuItem
			// 
			this->saveAstestToolStripMenuItem->Name = L"saveAstestToolStripMenuItem";
			this->saveAstestToolStripMenuItem->Size = System::Drawing::Size(180, 22);
			this->saveAstestToolStripMenuItem->Text = L"��������� ���";
			this->saveAstestToolStripMenuItem->Click += gcnew System::EventHandler(this, &Form1::saveAstestToolStripMenuItem_Click);
			// 
			// �������ToolStripMenuItem
			// 
			this->�������ToolStripMenuItem->Name = L"�������ToolStripMenuItem";
			this->�������ToolStripMenuItem->Size = System::Drawing::Size(180, 22);
			this->�������ToolStripMenuItem->Text = L"������";
			this->�������ToolStripMenuItem->Click += gcnew System::EventHandler(this, &Form1::�������ToolStripMenuItem_Click);
			// 
			// ������������ToolStripMenuItem
			// 
			this->������������ToolStripMenuItem->Name = L"������������ToolStripMenuItem";
			this->������������ToolStripMenuItem->Size = System::Drawing::Size(180, 22);
			this->������������ToolStripMenuItem->Text = L"�������";
			this->������������ToolStripMenuItem->Click += gcnew System::EventHandler(this, &Form1::������������ToolStripMenuItem_Click);
			// 
			// �����ToolStripMenuItem
			// 
			this->�����ToolStripMenuItem->Name = L"�����ToolStripMenuItem";
			this->�����ToolStripMenuItem->Size = System::Drawing::Size(180, 22);
			this->�����ToolStripMenuItem->Text = L"�����";
			this->�����ToolStripMenuItem->Click += gcnew System::EventHandler(this, &Form1::�����ToolStripMenuItem_Click);
			// 
			// �����������ToolStripMenuItem
			// 
			this->�����������ToolStripMenuItem->DropDownItems->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(8) {
				this->�����ToolStripMenuItem,
					this->�����ToolStripMenuItem, this->�������������ToolStripMenuItem, this->������ToolStripMenuItem, this->����������ToolStripMenuItem,
					this->������ToolStripMenuItem, this->�������ToolStripMenuItem, this->���������ToolStripMenuItem
			});
			this->�����������ToolStripMenuItem->Name = L"�����������ToolStripMenuItem";
			this->�����������ToolStripMenuItem->Size = System::Drawing::Size(95, 20);
			this->�����������ToolStripMenuItem->Text = L"�����������";
			// 
			// �����ToolStripMenuItem
			// 
			this->�����ToolStripMenuItem->Name = L"�����ToolStripMenuItem";
			this->�����ToolStripMenuItem->Size = System::Drawing::Size(180, 22);
			this->�����ToolStripMenuItem->Text = L"�����";
			this->�����ToolStripMenuItem->Click += gcnew System::EventHandler(this, &Form1::�����ToolStripMenuItem_Click_1);
			// 
			// �����ToolStripMenuItem
			// 
			this->�����ToolStripMenuItem->Name = L"�����ToolStripMenuItem";
			this->�����ToolStripMenuItem->Size = System::Drawing::Size(180, 22);
			this->�����ToolStripMenuItem->Text = L"�����";
			this->�����ToolStripMenuItem->Click += gcnew System::EventHandler(this, &Form1::�����ToolStripMenuItem_Click);
			// 
			// �������������ToolStripMenuItem
			// 
			this->�������������ToolStripMenuItem->Name = L"�������������ToolStripMenuItem";
			this->�������������ToolStripMenuItem->Size = System::Drawing::Size(180, 22);
			this->�������������ToolStripMenuItem->Text = L"�������������";
			this->�������������ToolStripMenuItem->Click += gcnew System::EventHandler(this, &Form1::�������������ToolStripMenuItem_Click);
			// 
			// ������ToolStripMenuItem
			// 
			this->������ToolStripMenuItem->Name = L"������ToolStripMenuItem";
			this->������ToolStripMenuItem->Size = System::Drawing::Size(180, 22);
			this->������ToolStripMenuItem->Text = L"������";
			this->������ToolStripMenuItem->Click += gcnew System::EventHandler(this, &Form1::��������ToolStripMenuItem_Click);
			// 
			// ����������ToolStripMenuItem
			// 
			this->����������ToolStripMenuItem->Name = L"����������ToolStripMenuItem";
			this->����������ToolStripMenuItem->Size = System::Drawing::Size(180, 22);
			this->����������ToolStripMenuItem->Text = L"����������";
			this->����������ToolStripMenuItem->Click += gcnew System::EventHandler(this, &Form1::����������ToolStripMenuItem_Click);
			// 
			// ������ToolStripMenuItem
			// 
			this->������ToolStripMenuItem->DropDownItems->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(7) {
				this->toolStripMenuItem2,
					this->toolStripMenuItem3, this->toolStripMenuItem4, this->toolStripMenuItem5, this->toolStripMenuItem6, this->toolStripMenuItem7,
					this->toolStripMenuItem8
			});
			this->������ToolStripMenuItem->Name = L"������ToolStripMenuItem";
			this->������ToolStripMenuItem->Size = System::Drawing::Size(180, 22);
			this->������ToolStripMenuItem->Text = L"������";
			// 
			// toolStripMenuItem2
			// 
			this->toolStripMenuItem2->Name = L"toolStripMenuItem2";
			this->toolStripMenuItem2->Size = System::Drawing::Size(80, 22);
			this->toolStripMenuItem2->Text = L"1";
			this->toolStripMenuItem2->Click += gcnew System::EventHandler(this, &Form1::toolStripMenuItem2_Click);
			// 
			// toolStripMenuItem3
			// 
			this->toolStripMenuItem3->Name = L"toolStripMenuItem3";
			this->toolStripMenuItem3->Size = System::Drawing::Size(80, 22);
			this->toolStripMenuItem3->Text = L"2";
			this->toolStripMenuItem3->Click += gcnew System::EventHandler(this, &Form1::toolStripMenuItem3_Click);
			// 
			// toolStripMenuItem4
			// 
			this->toolStripMenuItem4->Name = L"toolStripMenuItem4";
			this->toolStripMenuItem4->Size = System::Drawing::Size(80, 22);
			this->toolStripMenuItem4->Text = L"3";
			this->toolStripMenuItem4->Click += gcnew System::EventHandler(this, &Form1::toolStripMenuItem4_Click);
			// 
			// toolStripMenuItem5
			// 
			this->toolStripMenuItem5->Name = L"toolStripMenuItem5";
			this->toolStripMenuItem5->Size = System::Drawing::Size(80, 22);
			this->toolStripMenuItem5->Text = L"4";
			this->toolStripMenuItem5->Click += gcnew System::EventHandler(this, &Form1::toolStripMenuItem5_Click);
			// 
			// toolStripMenuItem6
			// 
			this->toolStripMenuItem6->Name = L"toolStripMenuItem6";
			this->toolStripMenuItem6->Size = System::Drawing::Size(80, 22);
			this->toolStripMenuItem6->Text = L"5";
			this->toolStripMenuItem6->Click += gcnew System::EventHandler(this, &Form1::toolStripMenuItem6_Click);
			// 
			// toolStripMenuItem7
			// 
			this->toolStripMenuItem7->Name = L"toolStripMenuItem7";
			this->toolStripMenuItem7->Size = System::Drawing::Size(80, 22);
			this->toolStripMenuItem7->Text = L"6";
			this->toolStripMenuItem7->Click += gcnew System::EventHandler(this, &Form1::toolStripMenuItem7_Click);
			// 
			// toolStripMenuItem8
			// 
			this->toolStripMenuItem8->Name = L"toolStripMenuItem8";
			this->toolStripMenuItem8->Size = System::Drawing::Size(80, 22);
			this->toolStripMenuItem8->Text = L"7";
			this->toolStripMenuItem8->Click += gcnew System::EventHandler(this, &Form1::toolStripMenuItem8_Click);
			// 
			// �������ToolStripMenuItem
			// 
			this->�������ToolStripMenuItem->Name = L"�������ToolStripMenuItem";
			this->�������ToolStripMenuItem->Size = System::Drawing::Size(180, 22);
			this->�������ToolStripMenuItem->Text = L"�������";
			this->�������ToolStripMenuItem->Click += gcnew System::EventHandler(this, &Form1::�������ToolStripMenuItem_Click);
			// 
			// ����ToolStripMenuItem
			// 
			this->����ToolStripMenuItem->DropDownItems->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(4) {
				this->�������ToolStripMenuItem1,
					this->�������ToolStripMenuItem, this->�����������ToolStripMenuItem, this->�������ToolStripMenuItem
			});
			this->����ToolStripMenuItem->Name = L"����ToolStripMenuItem";
			this->����ToolStripMenuItem->Size = System::Drawing::Size(48, 20);
			this->����ToolStripMenuItem->Text = L"����";
			this->����ToolStripMenuItem->DropDownOpening += gcnew System::EventHandler(this, &Form1::����ToolStripMenuItem_DropDownOpening);
			// 
			// �������ToolStripMenuItem1
			// 
			this->�������ToolStripMenuItem1->Name = L"�������ToolStripMenuItem1";
			this->�������ToolStripMenuItem1->Size = System::Drawing::Size(146, 22);
			this->�������ToolStripMenuItem1->Text = L"�������";
			this->�������ToolStripMenuItem1->Click += gcnew System::EventHandler(this, &Form1::�������ToolStripMenuItem1_Click);
			// 
			// �������ToolStripMenuItem
			// 
			this->�������ToolStripMenuItem->Name = L"�������ToolStripMenuItem";
			this->�������ToolStripMenuItem->Size = System::Drawing::Size(146, 22);
			this->�������ToolStripMenuItem->Text = L"�������";
			this->�������ToolStripMenuItem->Click += gcnew System::EventHandler(this, &Form1::�������ToolStripMenuItem_Click);
			// 
			// �����������ToolStripMenuItem
			// 
			this->�����������ToolStripMenuItem->Name = L"�����������ToolStripMenuItem";
			this->�����������ToolStripMenuItem->Size = System::Drawing::Size(146, 22);
			this->�����������ToolStripMenuItem->Text = L"�����������";
			// 
			// �������ToolStripMenuItem
			// 
			this->�������ToolStripMenuItem->CheckOnClick = true;
			this->�������ToolStripMenuItem->Name = L"�������ToolStripMenuItem";
			this->�������ToolStripMenuItem->Size = System::Drawing::Size(146, 22);
			this->�������ToolStripMenuItem->Text = L"�������";
			this->�������ToolStripMenuItem->CheckedChanged += gcnew System::EventHandler(this, &Form1::�������ToolStripMenuItem_CheckedChanged_1);
			// 
			// ����ToolStripMenuItem
			// 
			this->����ToolStripMenuItem->DropDownItems->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(3) {
				this->�������ToolStripMenuItem,
					this->������ToolStripMenuItem, this->�������ToolStripMenuItem1
			});
			this->����ToolStripMenuItem->Name = L"����ToolStripMenuItem";
			this->����ToolStripMenuItem->Size = System::Drawing::Size(45, 20);
			this->����ToolStripMenuItem->Text = L"����";
			// 
			// �������ToolStripMenuItem
			// 
			this->�������ToolStripMenuItem->Name = L"�������ToolStripMenuItem";
			this->�������ToolStripMenuItem->Size = System::Drawing::Size(119, 22);
			this->�������ToolStripMenuItem->Text = L"����";
			this->�������ToolStripMenuItem->Click += gcnew System::EventHandler(this, &Form1::�������ToolStripMenuItem_Click);
			// 
			// ������ToolStripMenuItem
			// 
			this->������ToolStripMenuItem->Name = L"������ToolStripMenuItem";
			this->������ToolStripMenuItem->Size = System::Drawing::Size(119, 22);
			this->������ToolStripMenuItem->Text = L"������";
			// 
			// �������ToolStripMenuItem1
			// 
			this->�������ToolStripMenuItem1->CheckOnClick = true;
			this->�������ToolStripMenuItem1->Name = L"�������ToolStripMenuItem1";
			this->�������ToolStripMenuItem1->Size = System::Drawing::Size(119, 22);
			this->�������ToolStripMenuItem1->Text = L"�������";
			this->�������ToolStripMenuItem1->CheckedChanged += gcnew System::EventHandler(this, &Form1::�������ToolStripMenuItem1_CheckedChanged);
			// 
			// menuStrip1
			// 
			this->menuStrip1->Items->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(5) {
				this->����ToolStripMenuItem,
					this->�����������ToolStripMenuItem, this->����ToolStripMenuItem, this->����ToolStripMenuItem, this->������ToolStripMenuItem1
			});
			this->menuStrip1->Location = System::Drawing::Point(0, 0);
			this->menuStrip1->Name = L"menuStrip1";
			this->menuStrip1->Size = System::Drawing::Size(647, 24);
			this->menuStrip1->TabIndex = 6;
			this->menuStrip1->Text = L"menuStrip1";
			// 
			// ������ToolStripMenuItem1
			// 
			this->������ToolStripMenuItem1->Name = L"������ToolStripMenuItem1";
			this->������ToolStripMenuItem1->Size = System::Drawing::Size(59, 20);
			this->������ToolStripMenuItem1->Text = L"������";
			this->������ToolStripMenuItem1->Click += gcnew System::EventHandler(this, &Form1::������ToolStripMenuItem1_Click);
			// 
			// toolStrip1
			// 
			this->toolStrip1->Location = System::Drawing::Point(0, 24);
			this->toolStrip1->Name = L"toolStrip1";
			this->toolStrip1->Size = System::Drawing::Size(647, 25);
			this->toolStrip1->TabIndex = 7;
			this->toolStrip1->Text = L"toolStrip1";
			// 
			// listBox1
			// 
			this->listBox1->Anchor = static_cast<System::Windows::Forms::AnchorStyles>((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Right));
			this->listBox1->DrawMode = System::Windows::Forms::DrawMode::OwnerDrawFixed;
			this->listBox1->Enabled = false;
			this->listBox1->FormattingEnabled = true;
			this->listBox1->ItemHeight = 50;
			this->listBox1->Location = System::Drawing::Point(487, 49);
			this->listBox1->Name = L"listBox1";
			this->listBox1->Size = System::Drawing::Size(160, 304);
			this->listBox1->TabIndex = 4;
			this->listBox1->DrawItem += gcnew System::Windows::Forms::DrawItemEventHandler(this, &Form1::listBox1_DrawItem);
			this->listBox1->SelectedIndexChanged += gcnew System::EventHandler(this, &Form1::listBox1_SelectedIndexChanged);
			// 
			// label1
			// 
			this->label1->Anchor = static_cast<System::Windows::Forms::AnchorStyles>((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Right));
			this->label1->AutoSize = true;
			this->label1->BackColor = System::Drawing::SystemColors::ButtonHighlight;
			this->label1->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 16, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->label1->Location = System::Drawing::Point(535, 20);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(65, 26);
			this->label1->TabIndex = 12;
			this->label1->Text = L"����";
			// 
			// colorDialog1
			// 
			this->colorDialog1->AllowFullOpen = false;
			this->colorDialog1->FullOpen = true;
			// 
			// ���������ToolStripMenuItem
			// 
			this->���������ToolStripMenuItem->Name = L"���������ToolStripMenuItem";
			this->���������ToolStripMenuItem->Size = System::Drawing::Size(180, 22);
			this->���������ToolStripMenuItem->Text = L"���������";
			this->���������ToolStripMenuItem->Click += gcnew System::EventHandler(this, &Form1::���������ToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackColor = System::Drawing::SystemColors::ActiveBorder;
			this->ClientSize = System::Drawing::Size(647, 376);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->listBox1);
			this->Controls->Add(this->panel1);
			this->Controls->Add(this->toolStrip1);
			this->Controls->Add(this->statusStrip1);
			this->Controls->Add(this->menuStrip1);
			this->Name = L"Form1";
			this->Text = L"PicturAgic";
			this->FormClosed += gcnew System::Windows::Forms::FormClosedEventHandler(this, &Form1::Form1_FormClosed);
			this->Load += gcnew System::EventHandler(this, &Form1::Form1_Load);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox1))->EndInit();
			this->statusStrip1->ResumeLayout(false);
			this->statusStrip1->PerformLayout();
			this->panel1->ResumeLayout(false);
			this->panel1->PerformLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox2))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->trackBar1))->EndInit();
			this->menuStrip1->ResumeLayout(false);
			this->menuStrip1->PerformLayout();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private:

		Bitmap^ openImage;
		
		Bitmap^ New;

		Image^ image2;

		
		Graphics^ graphics2;

		Pen^ pen;
		Pen^ Eraser;
		SolidBrush^ brush;
		SolidBrush^ brushEraser;

		List<Layer^>^ layers = nullptr;
		Layer^ currentLayer;

		
		Image^ layerVisibleImage = Image::FromFile("icon_layer_visible.png");
		Image^ layerHiddenImage = Image::FromFile("icon_layer_hidden.png");
		
		
		Color^ color = gcnew Color;

		ColorDialog^ dialog = gcnew ColorDialog;
		
		
		
		int width = 0, height = 0;
		int tool = 55;
		bool drawing = false;
		int xPrev = -1, yPrev = -1;

		int clicked = 0;
		int xLine = -1, yLine = -1;

		bool FillOrNot = false;

		float currentSize = 1;

		int mouseX = 0;
		int mouseY = 0;

		bool checkColor = true;

	private: void ChangePen(float width) {
		
		if (checkColor) {
			color = dialog->Color;
		}
		
		
		

		
		currentSize = width;
		Eraser = gcnew Pen(Color::Transparent, width);		
		pen = gcnew Pen(Color(color), width);
		brush = gcnew SolidBrush(Color(color));
		brushEraser = gcnew SolidBrush(Color::Transparent);
	}

	private: void refreshLayerList() {
		listBox1->Items->Clear();
		for each (auto layer in layers) {
			listBox1->Items->Add(layer);
		}

		if (layers->Count > 0) {
			listBox1->SelectedIndex = 0;
			currentLayer = layers[0];
		}
	}


	private: void newLayer() {
		if (layers == nullptr) {
			return;
		}

		auto layer = gcnew Layer(width, height, String::Format("Layer {0}", layers->Count));
		layers->Insert(0, layer);
		listBox1->Items->Insert(0, layer);

		if (layers->Count == 1) {
			currentLayer = layer;
			listBox1->SelectedIndex = 0;
		}
	}

	private: void newFile(int width, int height) {
		layers = gcnew List<Layer^>();
		
		trackBar1->BringToFront();

		newLayer();

		
		image2 = gcnew Bitmap(width, height);
		
		New = gcnew Bitmap(pictureBox1->Width, pictureBox1->Height);
		
		Eraser = gcnew Pen(Color::Transparent, 4);
		pen = gcnew Pen(Color::Black, 4);
		
		
		
		graphics2 = Graphics::FromImage(image2);
		
		New = gcnew Bitmap(currentLayer->image);


		clear(width, height);


		pictureBox1->Size = System::Drawing::Size(width, height);
		pictureBox1->Invalidate();
		
		
		listBox1->Invalidate();
		enableUI(true);
	}
	
private: void renderLayers(Graphics^ target) {
		if (layers == nullptr) {
			return;
		}

		layers->Reverse();
		for each (auto layer in layers) {
			layer->render(target);
			
		}
		layers->Reverse();
	}
		 
		 
	private: void clear(int width, int height) {
		
		if (image2 == nullptr) {
			return;
		}


		graphics2->FillRectangle(Brushes::Transparent, 0, 0, width, height);
		

	}
	

	private: void enableUI(bool enable) {
		panel1->Enabled = enable;
		listBox1->Enabled = enable;				
	}


private: System::Void firstImageToolStripMenuItem_Click_1(System::Object^  sender, System::EventArgs^  e) {
	width = 640;
	height = 480;
	newFile(width, height);
	
}
private: System::Void �����ToolStripMenuItem_Click_1(System::Object^  sender, System::EventArgs^  e) {
	tool = 55;
}
private: System::Void �����ToolStripMenuItem_Click(System::Object^  sender, System::EventArgs^  e) {
	tool = 2;
}


private: System::Void pictureBox1_MouseDown_1(System::Object^  sender, System::Windows::Forms::MouseEventArgs^  e) {
	ChangePen(currentSize);
	listBox1->Invalidate();
	if (currentLayer == nullptr || !currentLayer->isVisible) {
		return;
	}
	if (tool == 0) {
		return;
	}
	
	if (tool == 1) {
		xPrev = e->X;
		yPrev = e->Y;
		
		drawing = true;
	}
	if (tool == 4) {
		xPrev = e->X;
		yPrev = e->Y;

		drawing = true;
	}
	
	if (tool == 2) {
		
		if (clicked == 0) {
			clicked = 1;
			xLine = e->X;
			yLine = e->Y;
			drawing = true;
			
		}
		
	}
	
	if (tool == 3) {
		
		if (clicked == 0) {
			clicked = 1;
			xPrev = e->X;
			yPrev = e->Y;
			drawing = true;
		}
		
	}
	if (tool == 5) {
		if (clicked == 0) {
			clicked = 1;
			xPrev = e->X;
			yPrev = e->Y;
			drawing = true;
		}
	}
	if (tool == 55) {
		xPrev = e->X;
		yPrev = e->Y;

		drawing = true;
	}
	
}

private: System::Void pictureBox1_MouseMove_1(System::Object^  sender, System::Windows::Forms::MouseEventArgs^  e) {
	mouseX = e->X;
	mouseY = e->Y;

	ForX->Text = "X: " + Convert::ToString(mouseX);
	ForY->Text = "Y: " + Convert::ToString(mouseY);

	if (currentLayer == nullptr || !currentLayer->isVisible) {
		return;
	}
	

	int x = e->X;
	int y = e->Y;
	
	if (drawing) {
		
		if (tool == 1) {
			
			

			currentLayer->drawLine(pen, xPrev, yPrev, x, y);
			
			
			pictureBox1->Invalidate();

			

			xPrev = x;
			yPrev = y;
		}
		if (tool == 2) {
			graphics2->Clear(Color::Transparent);
			graphics2->DrawLine(pen, xLine, yLine, x, y);
			
			pictureBox1->Invalidate();
			
						
		}
		
		if (tool == 3) {
			graphics2->Clear(Color::Transparent);
			graphics2->FillRectangle(brush, xPrev, yPrev, x - xPrev, y - yPrev);
			
			pictureBox1->Invalidate();
		}
		
		if (tool == 4) {
			currentLayer->drawBrush(Brushes::White, xPrev - currentSize / 2, yPrev - currentSize / 2, currentSize, currentSize);
			pictureBox1->Invalidate();
			xPrev = x;
			yPrev = y;


			
		}
		
		if (tool == 5) {
			
			graphics2->Clear(Color::Transparent);
			graphics2->FillEllipse(Brushes::Black, xPrev, yPrev, x - xPrev, y - yPrev);

			pictureBox1->Invalidate();

		}
		if (tool == 55){
			
			currentLayer->drawBrush(brush, xPrev - currentSize/2, yPrev - currentSize/2, currentSize, currentSize);
			pictureBox1->Invalidate();
			xPrev = x;
			yPrev = y;
		
		}


	}
}
private: System::Void pictureBox1_MouseUp_1(System::Object^  sender, System::Windows::Forms::MouseEventArgs^  e) {
	if (currentLayer == nullptr || !currentLayer->isVisible) {
		
		return;
	}
	listBox1->Invalidate();
	
	int x = e->X;
	int y = e->Y;
	drawing = false;
	clicked = 0;

	if (tool == 2) {
		
		currentLayer->drawNormalLine(pen, xLine, yLine, x, y);
				
		graphics2->Clear(Color::Transparent);
		pictureBox1->Invalidate();
	}
	if (tool == 3) {
		if (FillOrNot == false) {
			if (y - yPrev < 0 && x - xPrev < 0) {
				currentLayer->PolygonRectangle(pen, x, y, abs(x - xPrev), abs(y - yPrev));
			}
			else if (y - yPrev < 0 && x - xPrev > 0) {
				currentLayer->PolygonRectangle(pen, xPrev, y, abs(x - xPrev), abs(y - yPrev));
			}
			else if (y - yPrev > 0 && x - xPrev < 0) {
				currentLayer->PolygonRectangle(pen, x, yPrev, abs(x - xPrev), abs(y - yPrev));
			}
			else if (y - yPrev > 0 && x - xPrev > 0) {
				currentLayer->PolygonRectangle(pen, xPrev, yPrev, abs(x - xPrev), abs(y - yPrev));
			}

			
		}else{
			if (y - yPrev < 0 && x - xPrev < 0) {
				currentLayer->drawRectangle(brush, x, y, abs(x - xPrev), abs(y - yPrev));
			}
			else if (y - yPrev < 0 && x - xPrev > 0) {
				currentLayer->drawRectangle(brush, xPrev, y, abs(x - xPrev), abs(y - yPrev));
			}
			else if (y - yPrev > 0 && x - xPrev < 0) {
				currentLayer->drawRectangle(brush, x, yPrev, abs(x - xPrev), abs(y - yPrev));
			}
			else if (y - yPrev > 0 && x - xPrev > 0) {
				currentLayer->drawRectangle(brush, xPrev, yPrev, abs(x - xPrev), abs(y - yPrev));
			}
			
			//currentLayer->drawRectangle(brush, xPrev, yPrev, x - xPrev, y - yPrev);
		
		}
		
		

		graphics2->Clear(Color::Transparent);
		pictureBox1->Invalidate();
		listBox1->Invalidate();
	}
	if (tool == 5) {
		if (FillOrNot == false) {
			currentLayer->PolygonEllipse(pen, xPrev, yPrev, x - xPrev, y - yPrev);
		}
		else {
			currentLayer->drawEllipse(brush, xPrev, yPrev, x - xPrev, y - yPrev);
		}
		
		
		


		graphics2->Clear(Color::Transparent);
		pictureBox1->Invalidate();
	}
	
}
private: System::Void pictureBox1_Paint_1(System::Object^  sender, System::Windows::Forms::PaintEventArgs^  e) {
	
	Graphics^ g = e->Graphics;
	g->FillRectangle(Brushes::White, 0, 0, 640, 480);
	renderLayers(g);
	
	
}
private: System::Void textBox1_TextChanged(System::Object^  sender, System::EventArgs^  e) {
}

private: System::Void �������������ToolStripMenuItem_Click(System::Object^  sender, System::EventArgs^  e) {
	tool = 3;
}


private: System::Void ��������ToolStripMenuItem_Click(System::Object^  sender, System::EventArgs^  e) {
	tool = 4;
}
private: System::Void ����������ToolStripMenuItem_Click(System::Object^  sender, System::EventArgs^  e) {
	tool = 5;
}
private: System::Void �������ToolStripMenuItem1_Click(System::Object^  sender, System::EventArgs^  e) {
	
	newLayer();


	
}


private: System::Void toolStripMenuItem2_Click(System::Object^  sender, System::EventArgs^  e) {
	ChangePen(1);
	
}
private: System::Void toolStripMenuItem3_Click(System::Object^  sender, System::EventArgs^  e) {
	ChangePen(2);
}
private: System::Void toolStripMenuItem4_Click(System::Object^  sender, System::EventArgs^  e) {
	ChangePen(3);
}
private: System::Void toolStripMenuItem5_Click(System::Object^  sender, System::EventArgs^  e) {
	ChangePen(4);
}
private: System::Void toolStripMenuItem6_Click(System::Object^  sender, System::EventArgs^  e) {
	ChangePen(5);
}
private: System::Void toolStripMenuItem7_Click(System::Object^  sender, System::EventArgs^  e) {
	ChangePen(6);
}
private: System::Void toolStripMenuItem8_Click(System::Object^  sender, System::EventArgs^  e) {
	ChangePen(7);
}







private: System::Void ����ToolStripMenuItem_DropDownOpening(System::Object^  sender, System::EventArgs^  e) {
	if (currentLayer == nullptr) {
		return;
	}

	�������ToolStripMenuItem->Checked = currentLayer->isVisible;
}

private: System::Void listBox1_SelectedIndexChanged(System::Object^  sender, System::EventArgs^  e) {
	if (layers == nullptr) {
		return;
	}

	if (listBox1->SelectedIndex < 0 || listBox1->SelectedIndex >= layers->Count) {
		refreshLayerList();
	}
	else {
		currentLayer = layers[listBox1->SelectedIndex];
	}
	listBox1->Invalidate();
}


private: System::Void �������ToolStripMenuItem_Click(System::Object^  sender, System::EventArgs^  e) {
	if (layers == nullptr || listBox1->SelectedIndex < 0) {
		return;
	}

	delete layers[listBox1->SelectedIndex];
	layers->RemoveAt(listBox1->SelectedIndex);

	refreshLayerList();
	pictureBox1->Invalidate();
	listBox1->Invalidate();
}
private: System::Void Form1_FormClosed(System::Object^  sender, System::Windows::Forms::FormClosedEventArgs^  e) {
	if (layers == nullptr) {
		return;
	}

	for each (auto layer in layers) {
		delete layer;
	}
}


private: System::Void �������ToolStripMenuItem_Click(System::Object^  sender, System::EventArgs^  e) {
	
	dialog->ShowDialog();
	checkColor = true;
	
		
	

}

private: System::Void ������ToolStripMenuItem1_Click(System::Object^  sender, System::EventArgs^  e) {
	button1->Visible = true;
	button1->Enabled = true;

	trackBar1->Visible = true;
	trackBar1->Enabled = true;

	pictureBox2->Visible = true;
	pictureBox2->Enabled = true;
}
private: System::Void trackBar1_Scroll(System::Object^  sender, System::EventArgs^  e) {

}
private: System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) {
	button1->Visible = false;
	button1->Enabled = false;

	trackBar1->Visible = false;
	trackBar1->Enabled = false;

	pictureBox2->Visible = false;
	pictureBox2->Enabled = false;
}
private: System::Void trackBar1_ValueChanged(System::Object^  sender, System::EventArgs^  e) {
	currentSize = trackBar1->Value;
}
private: System::Void testBrushToolStripMenuItem_Click(System::Object^  sender, System::EventArgs^  e) {
	tool = 55;
}

private: System::Void ������������ToolStripMenuItem_Click(System::Object^  sender, System::EventArgs^  e) {
	if (currentLayer == nullptr || !currentLayer->isVisible) {

		return;
	}
	SaveFileDialog^ dial = gcnew SaveFileDialog;
	
	dial->Filter = "BitMap files (*.bmp)|*.bmp|JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png";
	dial->FilterIndex = 3;
	dial->RestoreDirectory = true;
	dial->ShowDialog();
	dial->OverwritePrompt = true;
	if (dial->ShowDialog() == System::Windows::Forms::DialogResult::OK) {
		
		currentLayer->image->Save(dial->FileName, System::Drawing::Imaging::ImageFormat::Png);
	}		
}
private: System::Void �������ToolStripMenuItem_Click(System::Object^  sender, System::EventArgs^  e) {
	if (currentLayer == nullptr || !currentLayer->isVisible) {

		return;
	}
	OpenFileDialog^ openDial = gcnew OpenFileDialog;
	openDial->Filter = "BitMap files (*.bmp)|*.bmp|JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png";
	openDial->FilterIndex = 3;
	openDial->RestoreDirectory = true;
	openDial->ShowDialog();
	if (openDial->ShowDialog() == System::Windows::Forms::DialogResult::OK) {
		//currentLayer->image->FromFile(openDial->FileName);
		openImage = gcnew Bitmap(openDial->FileName);
		//pictureBox3->Image = Image::FromFile(openDial->FileName);
		this->pictureBox1->Size = openImage->Size;
		pictureBox1->Image = openImage;
		currentLayer->image = openImage;
		
		pictureBox1->Invalidate();
		
	}
}

private: System::Void �����ToolStripMenuItem_Click(System::Object^  sender, System::EventArgs^  e) {
	//DialogResult result = MessageBox::Show("Do you want to save?", "Warning", MessageBoxButtons::YesNoCancel, MessageBoxIcon::Question);
	
	System::Windows::Forms::DialogResult result = MessageBox::Show("Do you want to save?", "Warning", MessageBoxButtons::YesNoCancel, MessageBoxIcon::Question);
	
	if (result == System::Windows::Forms::DialogResult::Yes) {
		//saveAstestToolStripMenuItem->CheckOnClick = true;
		saveAstestToolStripMenuItem_Click(nullptr, nullptr);
	
	}
	
	if (result == System::Windows::Forms::DialogResult::No) {
		Application::Exit();
	}	
}
private: System::Void saveAstestToolStripMenuItem_Click(System::Object^  sender, System::EventArgs^  e) {
	if (layers == nullptr) {
		return;
	}

	SaveFileDialog^ sfd = gcnew SaveFileDialog();
	sfd->Filter = "Layered Images (*.lim)|*.lim";
	sfd->DefaultExt = "lim";
	sfd->OverwritePrompt = true;

	if (sfd->ShowDialog() == System::Windows::Forms::DialogResult::OK) {
		LayeredImage::saveToFile(sfd->FileName, layers->ToArray());
	}

}
private: System::Void opentestToolStripMenuItem_Click(System::Object^  sender, System::EventArgs^  e) {
	OpenFileDialog^ ofd = gcnew OpenFileDialog();

	ofd->Filter = "Layered Images (*.lim)|*.lim";
	ofd->DefaultExt = "lim";

	if (ofd->ShowDialog() == System::Windows::Forms::DialogResult::OK) {
		auto layers = LayeredImage::loadFromFile(ofd->FileName);
		if (layers == nullptr || layers->Length < 1) {
			return;
		}

		if (this->layers != nullptr) {
			for each (auto layer in this->layers) {
				delete layer;
			}
		}

		width = layers[0]->getSize().Width;
		height = layers[0]->getSize().Height;

		this->layers = gcnew List<Layer^>();
		this->layers->AddRange(layers);

		currentLayer = this->layers[0];

		enableUI(true);
		refreshLayerList();
		pictureBox1->Size = System::Drawing::Size(width, height);
		pictureBox1->Invalidate();
		listBox1->Invalidate();
	}
}
private: System::Void �������ToolStripMenuItem_Click(System::Object^  sender, System::EventArgs^  e) {
	tool = 10;
}
private: System::Void pictureBox1_Click(System::Object^  sender, System::EventArgs^  e) {
	
}
private: System::Void pictureBox1_MouseClick(System::Object^  sender, System::Windows::Forms::MouseEventArgs^  e) {
	if (tool == 10) {
		checkColor = false;
		pictureBox1->DrawToBitmap(New, pictureBox1->ClientRectangle);
		
		color = New->GetPixel(e->X, e->Y);		
	}
}
private: System::Void �������ToolStripMenuItem_CheckedChanged_1(System::Object^  sender, System::EventArgs^  e) {
	if (currentLayer == nullptr) {
		return;
	}

	currentLayer->isVisible = �������ToolStripMenuItem->Checked;
	pictureBox1->Invalidate();
	listBox1->Invalidate();
}


private: System::Void �������ToolStripMenuItem1_CheckedChanged(System::Object^  sender, System::EventArgs^  e) {
	if (!�������ToolStripMenuItem1->Checked) {
		FillOrNot = false;
	}
	else {
		FillOrNot = true;
	}
}
private: System::Void �������ToolStripMenuItem_Click(System::Object^  sender, System::EventArgs^  e) {
}
private: System::Void listBox1_DrawItem(System::Object^  sender, System::Windows::Forms::DrawItemEventArgs^  e) {
	Layer^ item = nullptr;

	try {
		item = (Layer^)listBox1->Items[e->Index];
	}
	catch (Exception^ ex) {
		return;
	}

	if (item == nullptr)
		return;

	//Background
	Brush^ bgBrush = Brushes::White;

	if (e->Index == listBox1->SelectedIndex) {
		bgBrush = Brushes::CornflowerBlue;
	}

	e->Graphics->FillRectangle(bgBrush, e->Bounds);

	//Preview
	int xx = e->Bounds.Left;
	int yy = e->Bounds.Top;

	Image^ preview = item->previewImage(44);
	e->Graphics->DrawRectangle(Pens::Black, xx + 2, yy + 2, 46, 46);
	e->Graphics->DrawImage(preview, xx + 3, yy + 3);
	delete preview;

	//Title
	float textPad = 50;
	RectangleF rect = RectangleF(e->Bounds.Left + textPad, e->Bounds.Top, e->Bounds.Width - textPad, e->Bounds.Height);
	e->Graphics->DrawString(item->name, listBox1->Font, Brushes::Black, rect);

	//Visibility
	Image^ icon = layerVisibleImage;
	if (!item->isVisible) {
		icon = layerHiddenImage;
	}

	e->Graphics->DrawImage(icon, e->Bounds.Right - 26, e->Bounds.Bottom - 26);
}
private: System::Void Form1_Load(System::Object^  sender, System::EventArgs^  e) {
}
private: System::Void ���������ToolStripMenuItem_Click(System::Object^  sender, System::EventArgs^  e) {
	tool = 12;
}
};

}
