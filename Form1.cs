using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace CloneBGA
{
	/// <summary>
	/// Form1 �̊T�v�̐����ł��B
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Windows �t�H�[�� �f�U�C�i �T�|�[�g�ɕK�v�ł��B
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent �Ăяo���̌�ɁA�R���X�g���N�^ �R�[�h��ǉ����Ă��������B
			//
		}

		/// <summary>
		/// �g�p����Ă��郊�\�[�X�Ɍ㏈�������s���܂��B
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows �t�H�[�� �f�U�C�i�Ő������ꂽ�R�[�h 
		/// <summary>
		/// �f�U�C�i �T�|�[�g�ɕK�v�ȃ��\�b�h�ł��B���̃��\�b�h�̓��e��
		/// �R�[�h �G�f�B�^�ŕύX���Ȃ��ł��������B
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItemExit = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkBoxCom = new System.Windows.Forms.CheckBox();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonDel = new System.Windows.Forms.Button();
			this.listBoxTo = new System.Windows.Forms.ListBox();
			this.checkBoxTex = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxFrom = new System.Windows.Forms.TextBox();
			this.buttonOpen = new System.Windows.Forms.Button();
			this.openFileDialogBMS = new System.Windows.Forms.OpenFileDialog();
			this.buttonClone = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.labelFileName = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem2});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem3,
																					  this.menuItem4,
																					  this.menuItem5,
																					  this.menuItemExit});
			this.menuItem1.Text = "�t�@�C�� (&F)";
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 0;
			this.menuItem3.Text = "�R�s�[�����J�� (&O)";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 1;
			this.menuItem4.Text = "�R�s�[����J�� (&P)";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 2;
			this.menuItem5.Text = "-";
			// 
			// menuItemExit
			// 
			this.menuItemExit.Index = 3;
			this.menuItemExit.Text = "�I�� (&X)";
			this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem6,
																					  this.menuItem7,
																					  this.menuItem8,
																					  this.menuItem9,
																					  this.menuItem10,
																					  this.menuItem11});
			this.menuItem2.Text = "�w���v (&H)";
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 0;
			this.menuItem6.Text = "�t���̃e�L�X�g���J�� (&R)";
			this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 1;
			this.menuItem7.Text = "-";
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 2;
			this.menuItem8.Text = "��҂̃E�F�u�T�C�g���J�� (&V)";
			this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 3;
			this.menuItem9.Text = "�o�O�񍐂����� (&B)";
			this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 4;
			this.menuItem10.Text = "-";
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 5;
			this.menuItem11.Text = "�o�[�W������� (&A)";
			this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBoxCom);
			this.groupBox1.Controls.Add(this.buttonClear);
			this.groupBox1.Controls.Add(this.buttonAdd);
			this.groupBox1.Controls.Add(this.buttonDel);
			this.groupBox1.Controls.Add(this.listBoxTo);
			this.groupBox1.Controls.Add(this.checkBoxTex);
			this.groupBox1.Location = new System.Drawing.Point(12, 40);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(312, 188);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "�R�s�[��";
			// 
			// checkBoxCom
			// 
			this.checkBoxCom.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxCom.Location = new System.Drawing.Point(208, 96);
			this.checkBoxCom.Name = "checkBoxCom";
			this.checkBoxCom.Size = new System.Drawing.Size(88, 16);
			this.checkBoxCom.TabIndex = 5;
			this.checkBoxCom.Text = "#COMMENT";
			this.toolTip1.SetToolTip(this.checkBoxCom, "#COMMENT���R�s�[�Ώۂɂ��܂��B");
			// 
			// buttonClear
			// 
			this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonClear.Location = new System.Drawing.Point(204, 148);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(92, 23);
			this.buttonClear.TabIndex = 3;
			this.buttonClear.Text = "�N���A (&C)";
			this.toolTip1.SetToolTip(this.buttonClear, "���X�g�������ׂăN���A���܂��B");
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonAdd.Location = new System.Drawing.Point(204, 24);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(92, 23);
			this.buttonAdd.TabIndex = 2;
			this.buttonAdd.Text = "�ǉ� (&A)";
			this.toolTip1.SetToolTip(this.buttonAdd, "���ʂ����BMS��ǉ����܂��B��x�ɕ����ǉ��ł��܂��B");
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonDel
			// 
			this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonDel.Location = new System.Drawing.Point(204, 56);
			this.buttonDel.Name = "buttonDel";
			this.buttonDel.Size = new System.Drawing.Size(92, 23);
			this.buttonDel.TabIndex = 1;
			this.buttonDel.Text = "�폜 (&D)";
			this.toolTip1.SetToolTip(this.buttonDel, "���X�g����I�����ꂽ���ڂ��폜���܂��B");
			this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
			// 
			// listBoxTo
			// 
			this.listBoxTo.AllowDrop = true;
			this.listBoxTo.ItemHeight = 12;
			this.listBoxTo.Location = new System.Drawing.Point(16, 24);
			this.listBoxTo.Name = "listBoxTo";
			this.listBoxTo.Size = new System.Drawing.Size(176, 148);
			this.listBoxTo.TabIndex = 0;
			this.toolTip1.SetToolTip(this.listBoxTo, "���ʂ����BMS�t�@�C���ꗗ�ł��B�ǉ��{�^���A�������̓t�@�C���h���b�v�Œǉ����܂��B");
			this.listBoxTo.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxTo_DragDrop);
			this.listBoxTo.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBoxTo_DragEnter);
			// 
			// checkBoxTex
			// 
			this.checkBoxTex.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxTex.Location = new System.Drawing.Point(208, 120);
			this.checkBoxTex.Name = "checkBoxTex";
			this.checkBoxTex.Size = new System.Drawing.Size(88, 16);
			this.checkBoxTex.TabIndex = 5;
			this.checkBoxTex.Text = "#TEXT";
			this.toolTip1.SetToolTip(this.checkBoxTex, "#TEXT/ch99���R�s�[�Ώۂɂ��܂��B#SONG�͖��Ή��ł��B");
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "�R�s�[��";
			// 
			// textBoxFrom
			// 
			this.textBoxFrom.AllowDrop = true;
			this.textBoxFrom.Location = new System.Drawing.Point(64, 12);
			this.textBoxFrom.Name = "textBoxFrom";
			this.textBoxFrom.Size = new System.Drawing.Size(232, 19);
			this.textBoxFrom.TabIndex = 2;
			this.textBoxFrom.Text = "";
			this.toolTip1.SetToolTip(this.textBoxFrom, "�R�s�[����BGA�f�[�^�������Ă���BMS���w�肵�܂��B");
			this.textBoxFrom.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxFrom_DragDrop);
			this.textBoxFrom.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxFrom_DragEnter);
			// 
			// buttonOpen
			// 
			this.buttonOpen.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonOpen.Location = new System.Drawing.Point(304, 12);
			this.buttonOpen.Name = "buttonOpen";
			this.buttonOpen.Size = new System.Drawing.Size(20, 19);
			this.buttonOpen.TabIndex = 2;
			this.buttonOpen.Text = "...";
			this.buttonOpen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.toolTip1.SetToolTip(this.buttonOpen, "�R�s�[����BGA�f�[�^�������Ă���BMS���w�肵�܂��B");
			this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
			// 
			// openFileDialogBMS
			// 
			this.openFileDialogBMS.Filter = "BMS File (*.bms;*.bme;*.bml;*.pms)|*.bms;*bme;*.bml;*.pms|Be-Music Script (*.bms)" +
				"|*.bms|Be-Music Script Extended (*.bme)|*.bme|Be-Music Script Longnote (*.bml)|*" +
				".bml|Be-Music Script Pomu (*.pms)|*.pms";
			// 
			// buttonClone
			// 
			this.buttonClone.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonClone.Location = new System.Drawing.Point(12, 240);
			this.buttonClone.Name = "buttonClone";
			this.buttonClone.Size = new System.Drawing.Size(312, 23);
			this.buttonClone.TabIndex = 3;
			this.buttonClone.Text = "Clone &BGA !";
			this.toolTip1.SetToolTip(this.buttonClone, "���ʂ��J�n���܂��B���ʂ��ꂽ�t�@�C����\"���̃t�@�C����_bga.bms\"�Ƃ��ĕۑ�����܂��B");
			this.buttonClone.Click += new System.EventHandler(this.buttonClone_Click);
			// 
			// toolTip1
			// 
			this.toolTip1.AutoPopDelay = 32767;
			this.toolTip1.InitialDelay = 500;
			this.toolTip1.ReshowDelay = 100;
			// 
			// labelFileName
			// 
			this.labelFileName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelFileName.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.labelFileName.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.labelFileName.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.labelFileName.Location = new System.Drawing.Point(0, 274);
			this.labelFileName.Name = "labelFileName";
			this.labelFileName.Size = new System.Drawing.Size(338, 16);
			this.labelFileName.TabIndex = 4;
			this.labelFileName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Form1
			// 
			this.AcceptButton = this.buttonClone;
			this.AllowDrop = true;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.ClientSize = new System.Drawing.Size(338, 290);
			this.Controls.Add(this.labelFileName);
			this.Controls.Add(this.buttonClone);
			this.Controls.Add(this.textBoxFrom);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonOpen);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// �A�v���P�[�V�����̃��C�� �G���g�� �|�C���g�ł��B
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.EnableVisualStyles();
			Application.Run(new Form1());
		}

		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonDel;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Button buttonOpen;
		private System.Windows.Forms.TextBox textBoxFrom;
		private System.Windows.Forms.ListBox listBoxTo;
		private System.Windows.Forms.MenuItem menuItemExit;
		private System.Windows.Forms.OpenFileDialog openFileDialogBMS;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.Button buttonClone;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;

		// �U�E�ϐ�
		string titletext = "CloneBGA 0.3";
		private System.Windows.Forms.CheckBox checkBoxCom;
		private System.Windows.Forms.CheckBox checkBoxTex;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label labelFileName;
		string exepath = Application.StartupPath;

		#region ini�ǂݍ��ݗp

		/// <summary>
		/// ini �t�@�C���̓ǂݍ��ݗp�̊֐�(GetPrivateProfileString)�̐錾����
		/// </summary>
		[DllImport("kernel32.dll", EntryPoint="GetPrivateProfileString")]
		private static extern uint GetPrivateProfileString( string lpApplicationName, string lpEntryName, string lpDefault, System.Text.StringBuilder lpReturnedString, uint nSize, string lpFileName ); 

		/// <summary>
		/// ini �t�@�C���̏������ݗp�̊֐�(WritePrivateProfileString)�̐錾����
		/// </summary>
		[DllImport("kernel32.dll", EntryPoint="WritePrivateProfileString")]
		private static extern uint WritePrivateProfileString( string lpApplicationName, string lpEntryName, string lpEntryString, string lpFileName );

		#endregion

		# region ini�ϐ�

		string ini = Application.StartupPath + @"\CloneBGA.ini";

		string Form_X;
		string Form_Y;

		string TEXTChk;
		string COMMENTChk;

		#endregion

		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.Text = titletext;
			this.Font = SystemInformation.MenuFont;

			uint entryLength;
			string strEntryStringValue;
			System.Text.StringBuilder strEntryString = new System.Text.StringBuilder( 256 );

			#region//Form_X
			entryLength = GetPrivateProfileString( "Main",
				"Form_X",
				"0",
				strEntryString, (uint)(strEntryString.Capacity), ini);
			strEntryStringValue = strEntryString.ToString();
			if(strEntryStringValue != "0")
			{
				this.Left = Convert.ToInt32(strEntryStringValue);
			}
			#endregion

			#region//Form_Y
			entryLength = GetPrivateProfileString( "Main",
				"Form_Y",
				"0",
				strEntryString, (uint)(strEntryString.Capacity), ini);
			strEntryStringValue = strEntryString.ToString();
			if(strEntryStringValue != "0")
			{
				this.Top = Convert.ToInt32(strEntryStringValue);
			}
			#endregion

			#region//TEXTChk
			entryLength = GetPrivateProfileString( "Main",
				"TEXTChk",
				"True",
				strEntryString, (uint)(strEntryString.Capacity), ini);
			strEntryStringValue = strEntryString.ToString();
			switch(strEntryStringValue)
			{
				case "True":
					checkBoxTex.Checked = true;
					break;
				case "False":
					checkBoxTex.Checked = false;
					break;
			}
			#endregion

			#region//COMMENTChk
			entryLength = GetPrivateProfileString( "Main",
				"COMMENTChk",
				"True",
				strEntryString, (uint)(strEntryString.Capacity), ini);
			strEntryStringValue = strEntryString.ToString();
			switch(strEntryStringValue)
			{
				case "True":
					checkBoxCom.Checked = true;
					break;
				case "False":
					checkBoxCom.Checked = false;
					break;
			}
			#endregion

		}

		private void menuItemExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void listBoxTo_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			if(e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.All;
			else
				e.Effect = DragDropEffects.None;
		}

		private void listBoxTo_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			string[] s = (string[]) e.Data.GetData(DataFormats.FileDrop, false);
			int i;
			for(i = 0; i < s.Length; i++)
				if(
					s[i].ToLower().EndsWith(".bms") ||
					s[i].ToLower().EndsWith(".bme") ||
					s[i].ToLower().EndsWith(".bml") ||
					s[i].ToLower().EndsWith(".pms")
					)
				{
					listBoxTo.Items.Add(s[i]);
				}
		}

		private void textBoxFrom_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			// �i�[����Ă���f�[�^�̌`�����m�F����
			if ( e.Data.GetDataPresent( DataFormats.FileDrop ) ) 
			{
				e.Effect = DragDropEffects.Move;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void textBoxFrom_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			string[] files = (string[])e.Data.GetData( DataFormats.FileDrop, false );
			if(
				files[0].ToLower().EndsWith(".bms") ||
				files[0].ToLower().EndsWith(".bme") ||
				files[0].ToLower().EndsWith(".bml") ||
				files[0].ToLower().EndsWith(".pms")
				)
			{
				textBoxFrom.Text = files[0];
				// currentpath = files[0].Substring(0, files[0].LastIndexOf(@"\"));
			}
		}

		private void buttonOpen_Click(object sender, System.EventArgs e)
		{
			openFileDialogBMS.Multiselect = false;
			string tmp = textBoxFrom.Text;
			openFileDialogBMS.ShowDialog();
			string path = openFileDialogBMS.FileName;
			textBoxFrom.Text = path;

			if(openFileDialogBMS.FileName == "")
			{
				textBoxFrom.Text = tmp;
			}

		}

		private void buttonAdd_Click(object sender, System.EventArgs e)
		{
			//�����̃t�@�C����I���ł���悤�ɂ���
			openFileDialogBMS.Multiselect = true;
			//�_�C�A���O��\������
			if (openFileDialogBMS.ShowDialog() == DialogResult.OK)
			{
				//OK�{�^�����N���b�N���ꂽ�Ƃ�
				//�I�����ꂽ�t�@�C���������ׂĕ\������
				foreach (string fn in openFileDialogBMS.FileNames)
				{
					if(
						fn.ToLower().EndsWith(".bms") ||
						fn.ToLower().EndsWith(".bme") ||
						fn.ToLower().EndsWith(".bml") ||
						fn.ToLower().EndsWith(".pms")
						)
					listBoxTo.Items.Add(fn);
				}
			}
		}

		private void buttonClear_Click(object sender, System.EventArgs e)
		{
			listBoxTo.Items.Clear();
		}

		private void buttonDel_Click(object sender, System.EventArgs e)
		{
			if(listBoxTo.SelectedIndex != -1)
			{
				listBoxTo.Items.RemoveAt(listBoxTo.SelectedIndex);
			}
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			buttonOpen.PerformClick();
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			buttonAdd.PerformClick();
		}

		private void buttonClone_Click(object sender, System.EventArgs e)
		{
			string str = "\r\n*---------------------- Added by CloneBGA\r\n\r\n";
			string str2 = "";

			try
			{
				if(System.IO.File.Exists(textBoxFrom.Text) == true && listBoxTo.Items.Count > 0)
				{

					// �v���Z�X�\��
					this.Text = titletext + " Cloning...";
					labelFileName.Text = textBoxFrom.Text.Substring(textBoxFrom.Text.LastIndexOf(@"\")).Replace(@"\","") 
						+ " Loading BGA field...";
					labelFileName.Refresh();

					// ���t�@�C������K�v�ȃf�[�^�������Ă���
					System.IO.StreamReader reader =
						new System.IO.StreamReader (textBoxFrom.Text,System.Text.Encoding.Default);
					string bmsline;
					while ((bmsline = reader.ReadLine()) != null)
					{
						if (bmsline.ToUpper().StartsWith("#BMP") ||
							bmsline.ToUpper().StartsWith("#EXBMP") ||
							bmsline.ToUpper().StartsWith("#BGA") ||
							bmsline.ToUpper().StartsWith("#@BGA") ||
							bmsline.ToUpper().StartsWith("#BACKBMP") ||
							bmsline.ToUpper().StartsWith("#POORBGA") ||
							bmsline.ToUpper().StartsWith("#SWBGA") ||
							bmsline.ToUpper().StartsWith("#BANNER") ||
							bmsline.ToUpper().StartsWith("#ARGB") ||
							bmsline.ToUpper().StartsWith("#STAGEFILE") ||
							bmsline.ToUpper().StartsWith("#VIDEOFILE") ||
							bmsline.ToUpper().StartsWith("#VIDEOF/S") ||
							bmsline.ToUpper().StartsWith("#VIDEOCOLORS") ||
							bmsline.ToUpper().StartsWith("#VIDEODLY") ||
							bmsline.ToUpper().StartsWith("#CHARFILE") ||
							bmsline.ToUpper().StartsWith("#MATERIALSBMP")
							)
						{
							str += bmsline + "\r\n";
						}

						if ((Regex.Match(bmsline.ToUpper(), "#[0-9][0-9][0-9][A-Z_0-9][A-Z_0-9][:]")).Success == true)
						{
							string ch = bmsline.Substring(4,2).ToUpper();
							if (Regex.Match(ch, "04").Success == true || 
								Regex.Match(ch, "0[6-7]").Success == true || 
								Regex.Match(ch, "0[A-E]").Success == true || 
								Regex.Match(ch, "A[1-5]").Success == true
								)
							{
								str += bmsline + "\r\n";
							}
						}
						if (checkBoxCom.Checked == true)
						{
							if (bmsline.ToUpper().StartsWith("#COMMENT"))
							{
								str += bmsline + "\r\n";
							}
						}
						if (checkBoxTex.Checked == true)
						{
							if (bmsline.ToUpper().StartsWith("#TEXT"))
							{
								str += bmsline + "\r\n";
							}
							if ((Regex.Match(bmsline.ToUpper(), "#[0-9][0-9][0-9][A-Z_0-9][A-Z_0-9][:]")).Success == true)
							{
								string ch = bmsline.Substring(4,2).ToUpper();
								if (Regex.Match(ch, "99").Success == true)
								{
									str += bmsline + "\r\n";
								}
							}
						}
					}
					reader.Close();

					/*
					// comment���R�s�[�Ώۂ̂Ƃ�
					if (checkBoxCom.Checked == true)
					{
						System.IO.StreamReader readercomment =
							new System.IO.StreamReader (textBoxFrom.Text,System.Text.Encoding.Default);
						string bmsline2;
						while ((bmsline2 = readercomment.ReadLine()) != null)
						{
							if (bmsline2.ToUpper().StartsWith("#COMMENT"))
							{
								str += bmsline2 + "\r\n";
							}
						}
						readercomment.Close();
					}

					// text���R�s�[�Ώۂ̂Ƃ�
					if (checkBoxTex.Checked == true)
					{
						System.IO.StreamReader readertext =
							new System.IO.StreamReader (textBoxFrom.Text,System.Text.Encoding.Default);
						string bmsline3;
						while ((bmsline3 = readertext.ReadLine()) != null)
						{
							if (bmsline3.ToUpper().StartsWith("#TEXT"))
							{
								str += bmsline3 + "\r\n";
							}
							if ((Regex.Match(bmsline3.ToUpper(), "#[0-9][0-9][0-9][A-Z_0-9][A-Z_0-9][:]")).Success == true)
							{
								string ch = bmsline3.Substring(4,2).ToUpper();
								if (Regex.Match(ch, "99").Success == true)
								{
									str += bmsline3 + "\r\n";
								}
							}
						}
						readertext.Close();
						
					}*/

					// �s�K�v�ȃf�[�^���R�s�[�悩�甲���Ă��܂��ł�
					for(int i = 0; i < listBoxTo.Items.Count; i++)
					{
						labelFileName.Text = textBoxFrom.Text.Substring(textBoxFrom.Text.LastIndexOf(@"\")).Replace(@"\","") 
							+ " -> " + listBoxTo.Items[i].ToString().Substring(listBoxTo.Items[i].ToString().LastIndexOf(@"\")).Replace(@"\","");
						labelFileName.Refresh();
						str2 = "";

						System.IO.StreamReader reader2 =
							new System.IO.StreamReader (listBoxTo.Items[i].ToString(),
							System.Text.Encoding.Default);
						string copytoline;
						while ((copytoline = reader2.ReadLine()) != null)
						{

							if (checkBoxCom.Checked == true)
							{
								if (copytoline.ToUpper().StartsWith("#COMMENT"))continue;
							}

							if (checkBoxTex.Checked == true)
							{
								if (copytoline.ToUpper().StartsWith("#TEXT"))continue;

								if ((Regex.Match(copytoline.ToUpper(), "#[0-9][0-9][0-9][A-Z_0-9][A-Z_0-9][:]")).Success == true)
								{
									string ch = copytoline.Substring(4,2).ToUpper();
									if (Regex.Match(ch, "99").Success == true)continue;
								}
							}

							if(copytoline.ToUpper().StartsWith("#BMP") ||
								copytoline.ToUpper().StartsWith("#EXBMP") ||
								copytoline.ToUpper().StartsWith("#BGA") ||
								copytoline.ToUpper().StartsWith("#@BGA") ||
								copytoline.ToUpper().StartsWith("#BACKBMP") ||
								copytoline.ToUpper().StartsWith("#POORBGA") ||
								copytoline.ToUpper().StartsWith("#SWBGA") ||
								copytoline.ToUpper().StartsWith("#BANNER") ||
								copytoline.ToUpper().StartsWith("#ARGB") ||
								copytoline.ToUpper().StartsWith("#STAGEFILE") ||
								copytoline.ToUpper().StartsWith("#VIDEOFILE") ||
								copytoline.ToUpper().StartsWith("#VIDEOF/S") ||
								copytoline.ToUpper().StartsWith("#VIDEOCOLORS") ||
								copytoline.ToUpper().StartsWith("#VIDEODLY") ||
								copytoline.ToUpper().StartsWith("#CHARFILE") ||
								copytoline.ToUpper().StartsWith("#MATERIALSBMP") ||
								copytoline.StartsWith("*---------------------- Added by CloneBGA")
								)continue;

							if ((Regex.Match(copytoline.ToUpper(), "#[0-9][0-9][0-9][A-Z_0-9][A-Z_0-9][:]")).Success == true)
							{
								string ch = copytoline.Substring(4,2).ToUpper();
								if (Regex.Match(ch, "04").Success == true || 
									Regex.Match(ch, "0[6-7]").Success == true || 
									Regex.Match(ch, "0[A-E]").Success == true || 
									Regex.Match(ch, "A[1-5]").Success == true
									)continue;
							}

							str2 += copytoline + "\r\n";
						}
						reader2.Close();

						// �����`
						string filename = listBoxTo.Items[i].ToString().Insert(listBoxTo.Items[i].ToString().LastIndexOf("."),"_bga");
						System.IO.StreamWriter writer = 
							new System.IO.StreamWriter (filename, false,
							System.Text.Encoding.Default);
						writer.Write (str2 + str);
						writer.Close();
					}
					MessageBox.Show("�������I�����܂����B","���s����");
					listBoxTo.Items.Clear();
					textBoxFrom.Clear();
					this.Text = titletext;
					labelFileName.Text = "";
				}

				else if (listBoxTo.Items.Count == 0)
				{
					MessageBox.Show("�R�s�[��̃t�@�C�����ЂƂ�����܂���B","�G���[");
				}
			
				else
				{
					MessageBox.Show("�R�s�[���̃t�@�C�������݂��܂���B","�G���[");
				}
			}

			catch
			{
				MessageBox.Show("�G���[���������܂����B","�G���[");
			}
		}

		private void menuItem11_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(titletext
				+ "\nCopyright 2004 nulltask.\n\n"
				+ "Thanks to :\n"
				+ "gekikarato, Ruzeea, testers, users...","About CloneBGA");
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			if (System.IO.File.Exists(exepath + @"\CloneBGA.txt"))
			{
				System.Diagnostics.Process.Start(exepath + @"\CloneBGA.txt");
			}
			else
			{
				MessageBox.Show("���A���[�h�~�[���Ȃ�����Ȃ����I\n�ȁA�Ȃ�Ă������I�I�I�I","�G���[");
			}
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("http://nulltask.bms.bz/");
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("http://nulltask.bms.bz/cgi-bin/patio/patio.cgi?mode=view&no=3");
		}

		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			uint entryLength;

			#region TEXTChk
			switch(checkBoxTex.Checked.ToString())
			{
				case "True":
					entryLength = WritePrivateProfileString( "Main", "TEXTChk", "True", ini );
					break;
				case "False":
					entryLength = WritePrivateProfileString( "Main", "TEXTChk", "False", ini );
					break;
			}
			#endregion

			#region COMMENTChk
			switch(checkBoxCom.Checked.ToString())
			{
				case "True":
					entryLength = WritePrivateProfileString( "Main", "COMMENTChk", "True", ini );
					break;
				case "False":
					entryLength = WritePrivateProfileString( "Main", "COMMENTChk", "False", ini );
					break;
			}
			#endregion

			string str = this.Left.ToString();
			entryLength = WritePrivateProfileString( "Main", "Form_X", str, ini );

			str = this.Top.ToString();
			entryLength = WritePrivateProfileString( "Main", "Form_Y", str, ini );

		}
	}
}
