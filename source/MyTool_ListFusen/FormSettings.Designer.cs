﻿namespace MyTool_ListFusen
{
	partial class FormSettings
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.checkBoxAutoSave = new System.Windows.Forms.CheckBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.comboBoxTick = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonResetLB = new System.Windows.Forms.Button();
			this.buttonFColorLB = new System.Windows.Forms.Button();
			this.buttonFStyleLB = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.checkBoxDeactiveSave = new System.Windows.Forms.CheckBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.buttonResetTB = new System.Windows.Forms.Button();
			this.buttonFColorTB = new System.Windows.Forms.Button();
			this.buttonFStyleTB = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.checkBoxWordWrap = new System.Windows.Forms.CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			this.colorDialogLB = new System.Windows.Forms.ColorDialog();
			this.colorDialogTB = new System.Windows.Forms.ColorDialog();
			this.fontDialogTB = new System.Windows.Forms.FontDialog();
			this.fontDialogLB = new System.Windows.Forms.FontDialog();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.buttonResetPC2 = new System.Windows.Forms.Button();
			this.buttonResetPC1 = new System.Windows.Forms.Button();
			this.buttonPColor2 = new System.Windows.Forms.Button();
			this.buttonPColor1 = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.colorDialogPC = new System.Windows.Forms.ColorDialog();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(16, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "文字設定";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label3.Location = new System.Drawing.Point(38, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(165, 20);
			this.label3.TabIndex = 1;
			this.label3.Text = "オートセーブを有効にする";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label4.Location = new System.Drawing.Point(254, 30);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(165, 20);
			this.label4.TabIndex = 4;
			this.label4.Text = "オートセーブの間隔（分）";
			// 
			// checkBoxAutoSave
			// 
			this.checkBoxAutoSave.AutoSize = true;
			this.checkBoxAutoSave.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.checkBoxAutoSave.Location = new System.Drawing.Point(20, 33);
			this.checkBoxAutoSave.Name = "checkBoxAutoSave";
			this.checkBoxAutoSave.Size = new System.Drawing.Size(15, 14);
			this.checkBoxAutoSave.TabIndex = 0;
			this.checkBoxAutoSave.UseVisualStyleBackColor = true;
			this.checkBoxAutoSave.CheckedChanged += new System.EventHandler(this.checkBoxAutoSave_CheckedChanged);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(175)))), ((int)(((byte)(50)))));
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(482, 7);
			this.panel1.TabIndex = 0;
			// 
			// comboBoxTick
			// 
			this.comboBoxTick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTick.FormattingEnabled = true;
			this.comboBoxTick.Items.AddRange(new object[] {
            "60",
            "30",
            "10",
            "5"});
			this.comboBoxTick.Location = new System.Drawing.Point(258, 55);
			this.comboBoxTick.Name = "comboBoxTick";
			this.comboBoxTick.Size = new System.Drawing.Size(53, 28);
			this.comboBoxTick.TabIndex = 5;
			this.comboBoxTick.TextChanged += new System.EventHandler(this.comboBoxTick_TextChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
			this.groupBox1.Controls.Add(this.buttonResetLB);
			this.groupBox1.Controls.Add(this.buttonFColorLB);
			this.groupBox1.Controls.Add(this.buttonFStyleLB);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.groupBox1.Location = new System.Drawing.Point(12, 141);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(311, 68);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "リスト";
			// 
			// buttonResetLB
			// 
			this.buttonResetLB.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonResetLB.Location = new System.Drawing.Point(237, 26);
			this.buttonResetLB.Name = "buttonResetLB";
			this.buttonResetLB.Size = new System.Drawing.Size(60, 27);
			this.buttonResetLB.TabIndex = 4;
			this.buttonResetLB.Text = "初期値";
			this.buttonResetLB.UseVisualStyleBackColor = true;
			this.buttonResetLB.Click += new System.EventHandler(this.buttonResetLB_Click);
			// 
			// buttonFColorLB
			// 
			this.buttonFColorLB.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonFColorLB.Location = new System.Drawing.Point(189, 26);
			this.buttonFColorLB.Name = "buttonFColorLB";
			this.buttonFColorLB.Size = new System.Drawing.Size(27, 27);
			this.buttonFColorLB.TabIndex = 3;
			this.buttonFColorLB.Text = "...";
			this.buttonFColorLB.UseVisualStyleBackColor = true;
			this.buttonFColorLB.Click += new System.EventHandler(this.buttonFColorLB_Click);
			// 
			// buttonFStyleLB
			// 
			this.buttonFStyleLB.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonFStyleLB.Location = new System.Drawing.Point(83, 27);
			this.buttonFStyleLB.Name = "buttonFStyleLB";
			this.buttonFStyleLB.Size = new System.Drawing.Size(27, 27);
			this.buttonFStyleLB.TabIndex = 1;
			this.buttonFStyleLB.Text = "...";
			this.buttonFStyleLB.UseVisualStyleBackColor = true;
			this.buttonFStyleLB.Click += new System.EventHandler(this.buttonFStyleLB_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label2.Location = new System.Drawing.Point(122, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "文字の色";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.comboBoxTick);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.checkBoxDeactiveSave);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.checkBoxAutoSave);
			this.groupBox2.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.groupBox2.Location = new System.Drawing.Point(12, 222);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(459, 98);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "セーブ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label6.Location = new System.Drawing.Point(38, 61);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(191, 20);
			this.label6.TabIndex = 3;
			this.label6.Text = "ツール非アクティブ時にセーブ";
			// 
			// checkBoxDeactiveSave
			// 
			this.checkBoxDeactiveSave.AutoSize = true;
			this.checkBoxDeactiveSave.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.checkBoxDeactiveSave.Location = new System.Drawing.Point(20, 64);
			this.checkBoxDeactiveSave.Name = "checkBoxDeactiveSave";
			this.checkBoxDeactiveSave.Size = new System.Drawing.Size(15, 14);
			this.checkBoxDeactiveSave.TabIndex = 2;
			this.checkBoxDeactiveSave.UseVisualStyleBackColor = true;
			this.checkBoxDeactiveSave.CheckedChanged += new System.EventHandler(this.checkBoxDeactiveSave_CheckedChanged);
			// 
			// buttonOK
			// 
			this.buttonOK.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonOK.Location = new System.Drawing.Point(377, 328);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(94, 27);
			this.buttonOK.TabIndex = 4;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
			this.groupBox3.Controls.Add(this.buttonResetTB);
			this.groupBox3.Controls.Add(this.buttonFColorTB);
			this.groupBox3.Controls.Add(this.buttonFStyleTB);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.checkBoxWordWrap);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.groupBox3.Location = new System.Drawing.Point(12, 17);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(311, 111);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "テキストエディタ";
			// 
			// buttonResetTB
			// 
			this.buttonResetTB.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonResetTB.Location = new System.Drawing.Point(237, 26);
			this.buttonResetTB.Name = "buttonResetTB";
			this.buttonResetTB.Size = new System.Drawing.Size(60, 27);
			this.buttonResetTB.TabIndex = 4;
			this.buttonResetTB.Text = "初期値";
			this.buttonResetTB.UseVisualStyleBackColor = true;
			this.buttonResetTB.Click += new System.EventHandler(this.buttonResetTB_Click);
			// 
			// buttonFColorTB
			// 
			this.buttonFColorTB.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonFColorTB.Location = new System.Drawing.Point(189, 26);
			this.buttonFColorTB.Name = "buttonFColorTB";
			this.buttonFColorTB.Size = new System.Drawing.Size(27, 27);
			this.buttonFColorTB.TabIndex = 3;
			this.buttonFColorTB.Text = "...";
			this.buttonFColorTB.UseVisualStyleBackColor = true;
			this.buttonFColorTB.Click += new System.EventHandler(this.buttonFColorTB_Click);
			// 
			// buttonFStyleTB
			// 
			this.buttonFStyleTB.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonFStyleTB.Location = new System.Drawing.Point(83, 27);
			this.buttonFStyleTB.Name = "buttonFStyleTB";
			this.buttonFStyleTB.Size = new System.Drawing.Size(27, 27);
			this.buttonFStyleTB.TabIndex = 1;
			this.buttonFStyleTB.Text = "...";
			this.buttonFStyleTB.UseVisualStyleBackColor = true;
			this.buttonFStyleTB.Click += new System.EventHandler(this.buttonFStyleTB_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label5.Location = new System.Drawing.Point(122, 31);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 20);
			this.label5.TabIndex = 2;
			this.label5.Text = "文字の色";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label8.Location = new System.Drawing.Point(38, 72);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(165, 20);
			this.label8.TabIndex = 6;
			this.label8.Text = "テキストを右端で折り返す";
			// 
			// checkBoxWordWrap
			// 
			this.checkBoxWordWrap.AutoSize = true;
			this.checkBoxWordWrap.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.checkBoxWordWrap.Location = new System.Drawing.Point(20, 75);
			this.checkBoxWordWrap.Name = "checkBoxWordWrap";
			this.checkBoxWordWrap.Size = new System.Drawing.Size(15, 14);
			this.checkBoxWordWrap.TabIndex = 5;
			this.checkBoxWordWrap.UseVisualStyleBackColor = true;
			this.checkBoxWordWrap.CheckedChanged += new System.EventHandler(this.checkBoxWordWrap_CheckedChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label7.Location = new System.Drawing.Point(16, 31);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(61, 20);
			this.label7.TabIndex = 0;
			this.label7.Text = "文字設定";
			// 
			// colorDialogLB
			// 
			this.colorDialogLB.Color = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(208)))));
			// 
			// colorDialogTB
			// 
			this.colorDialogTB.Color = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(208)))));
			// 
			// fontDialogTB
			// 
			this.fontDialogTB.AllowVerticalFonts = false;
			this.fontDialogTB.Color = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(208)))));
			this.fontDialogTB.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.fontDialogTB.FontMustExist = true;
			this.fontDialogTB.ShowEffects = false;
			// 
			// fontDialogLB
			// 
			this.fontDialogLB.AllowVerticalFonts = false;
			this.fontDialogLB.Color = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(208)))));
			this.fontDialogLB.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.fontDialogLB.FontMustExist = true;
			this.fontDialogLB.ShowEffects = false;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.buttonResetPC2);
			this.groupBox4.Controls.Add(this.buttonResetPC1);
			this.groupBox4.Controls.Add(this.buttonPColor2);
			this.groupBox4.Controls.Add(this.buttonPColor1);
			this.groupBox4.Controls.Add(this.label10);
			this.groupBox4.Controls.Add(this.label9);
			this.groupBox4.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Bold);
			this.groupBox4.Location = new System.Drawing.Point(339, 17);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(132, 192);
			this.groupBox4.TabIndex = 5;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "アクセントカラー";
			// 
			// buttonResetPC2
			// 
			this.buttonResetPC2.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonResetPC2.Location = new System.Drawing.Point(51, 151);
			this.buttonResetPC2.Name = "buttonResetPC2";
			this.buttonResetPC2.Size = new System.Drawing.Size(60, 27);
			this.buttonResetPC2.TabIndex = 7;
			this.buttonResetPC2.Text = "初期値";
			this.buttonResetPC2.UseVisualStyleBackColor = true;
			this.buttonResetPC2.Click += new System.EventHandler(this.buttonResetPC2_Click);
			// 
			// buttonResetPC1
			// 
			this.buttonResetPC1.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonResetPC1.Location = new System.Drawing.Point(51, 60);
			this.buttonResetPC1.Name = "buttonResetPC1";
			this.buttonResetPC1.Size = new System.Drawing.Size(60, 27);
			this.buttonResetPC1.TabIndex = 7;
			this.buttonResetPC1.Text = "初期値";
			this.buttonResetPC1.UseVisualStyleBackColor = true;
			this.buttonResetPC1.Click += new System.EventHandler(this.buttonResetPC1_Click);
			// 
			// buttonPColor2
			// 
			this.buttonPColor2.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonPColor2.Location = new System.Drawing.Point(84, 118);
			this.buttonPColor2.Name = "buttonPColor2";
			this.buttonPColor2.Size = new System.Drawing.Size(27, 27);
			this.buttonPColor2.TabIndex = 6;
			this.buttonPColor2.Text = "...";
			this.buttonPColor2.UseVisualStyleBackColor = true;
			this.buttonPColor2.Click += new System.EventHandler(this.buttonPColor2_Click);
			// 
			// buttonPColor1
			// 
			this.buttonPColor1.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonPColor1.Location = new System.Drawing.Point(84, 27);
			this.buttonPColor1.Name = "buttonPColor1";
			this.buttonPColor1.Size = new System.Drawing.Size(27, 27);
			this.buttonPColor1.TabIndex = 6;
			this.buttonPColor1.Text = "...";
			this.buttonPColor1.UseVisualStyleBackColor = true;
			this.buttonPColor1.Click += new System.EventHandler(this.buttonPColor1_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label10.Location = new System.Drawing.Point(17, 123);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(48, 20);
			this.label10.TabIndex = 5;
			this.label10.Text = "サブ色";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label9.Location = new System.Drawing.Point(17, 32);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(61, 20);
			this.label9.TabIndex = 5;
			this.label9.Text = "メイン色";
			// 
			// colorDialogPC
			// 
			this.colorDialogPC.Color = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(208)))));
			// 
			// FormSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(482, 367);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormSettings";
			this.ShowInTaskbar = false;
			this.Text = "List Fusen ツール設定";
			this.Load += new System.EventHandler(this.FormSettings_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox checkBoxAutoSave;
		private System.Windows.Forms.ComboBox comboBoxTick;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button buttonFStyleLB;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox checkBoxDeactiveSave;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonFColorLB;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button buttonFColorTB;
		private System.Windows.Forms.Button buttonFStyleTB;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ColorDialog colorDialogLB;
		private System.Windows.Forms.ColorDialog colorDialogTB;
		private System.Windows.Forms.FontDialog fontDialogTB;
		private System.Windows.Forms.FontDialog fontDialogLB;
		private System.Windows.Forms.Button buttonResetLB;
		private System.Windows.Forms.Button buttonResetTB;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.CheckBox checkBoxWordWrap;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button buttonResetPC2;
		private System.Windows.Forms.Button buttonResetPC1;
		private System.Windows.Forms.Button buttonPColor2;
		private System.Windows.Forms.Button buttonPColor1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ColorDialog colorDialogPC;
		private System.Windows.Forms.Panel panel1;
	}
}