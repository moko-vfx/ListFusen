namespace MyTool_ListFusen
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panelButton = new System.Windows.Forms.Panel();
			this.panelLine = new System.Windows.Forms.Panel();
			this.buttonFront = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonSettings = new System.Windows.Forms.Button();
			this.buttonRedo = new System.Windows.Forms.Button();
			this.buttonUndo = new System.Windows.Forms.Button();
			this.buttonExport = new System.Windows.Forms.Button();
			this.buttonDel = new System.Windows.Forms.Button();
			this.buttonReName = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonDown = new System.Windows.Forms.Button();
			this.buttonUp = new System.Windows.Forms.Button();
			this.panelLabel2 = new System.Windows.Forms.Panel();
			this.panelUP = new System.Windows.Forms.Panel();
			this.panelLabel1 = new System.Windows.Forms.Panel();
			this.labelEsc = new System.Windows.Forms.Label();
			this.labelSaved = new System.Windows.Forms.Label();
			this.labelTitle = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.panelLeft = new System.Windows.Forms.Panel();
			this.panelLabel3 = new System.Windows.Forms.Panel();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.panelRight = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panelBarTop = new System.Windows.Forms.Panel();
			this.panelBarBottom = new System.Windows.Forms.Panel();
			this.panelBarLeft = new System.Windows.Forms.Panel();
			this.panelBarRight = new System.Windows.Forms.Panel();
			this.panelDirty = new System.Windows.Forms.Panel();
			this.panelButton.SuspendLayout();
			this.panelUP.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panelLeft.SuspendLayout();
			this.panelRight.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelButton
			// 
			this.panelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(7)))), ((int)(((byte)(10)))));
			this.panelButton.Controls.Add(this.panelDirty);
			this.panelButton.Controls.Add(this.panelLine);
			this.panelButton.Controls.Add(this.buttonFront);
			this.panelButton.Controls.Add(this.buttonSave);
			this.panelButton.Controls.Add(this.buttonSettings);
			this.panelButton.Controls.Add(this.buttonRedo);
			this.panelButton.Controls.Add(this.buttonUndo);
			this.panelButton.Controls.Add(this.buttonExport);
			this.panelButton.Controls.Add(this.buttonDel);
			this.panelButton.Controls.Add(this.buttonReName);
			this.panelButton.Controls.Add(this.buttonAdd);
			this.panelButton.Controls.Add(this.buttonDown);
			this.panelButton.Controls.Add(this.buttonUp);
			this.panelButton.Controls.Add(this.panelLabel2);
			this.panelButton.Controls.Add(this.panelUP);
			this.panelButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelButton.Location = new System.Drawing.Point(5, 5);
			this.panelButton.Name = "panelButton";
			this.panelButton.Size = new System.Drawing.Size(674, 58);
			this.panelButton.TabIndex = 1;
			this.panelButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelButton_MouseDown);
			this.panelButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelButton_MouseMove);
			// 
			// panelLine
			// 
			this.panelLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
			this.panelLine.Location = new System.Drawing.Point(226, 25);
			this.panelLine.Name = "panelLine";
			this.panelLine.Size = new System.Drawing.Size(4, 26);
			this.panelLine.TabIndex = 3;
			// 
			// buttonFront
			// 
			this.buttonFront.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonFront.BackgroundImage = global::MyTool_ListFusen.Properties.Resources.front;
			this.buttonFront.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonFront.FlatAppearance.BorderSize = 0;
			this.buttonFront.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonFront.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonFront.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonFront.Location = new System.Drawing.Point(617, 18);
			this.buttonFront.Name = "buttonFront";
			this.buttonFront.Size = new System.Drawing.Size(33, 37);
			this.buttonFront.TabIndex = 2;
			this.buttonFront.TabStop = false;
			this.toolTip1.SetToolTip(this.buttonFront, "最前面表示をON・OFFします");
			this.buttonFront.UseVisualStyleBackColor = true;
			this.buttonFront.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonFront_MouseClick);
			// 
			// buttonSave
			// 
			this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSave.BackgroundImage = global::MyTool_ListFusen.Properties.Resources.save;
			this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonSave.FlatAppearance.BorderSize = 0;
			this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSave.Location = new System.Drawing.Point(576, 18);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(33, 37);
			this.buttonSave.TabIndex = 2;
			this.buttonSave.TabStop = false;
			this.toolTip1.SetToolTip(this.buttonSave, "押すと全てのデータを保存します（Ctrl + S）");
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonSave_MouseClick);
			this.buttonSave.MouseEnter += new System.EventHandler(this.buttonSave_MouseEnter);
			this.buttonSave.MouseLeave += new System.EventHandler(this.buttonSave_MouseLeave);
			// 
			// buttonSettings
			// 
			this.buttonSettings.BackgroundImage = global::MyTool_ListFusen.Properties.Resources.settings;
			this.buttonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonSettings.FlatAppearance.BorderSize = 0;
			this.buttonSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSettings.Location = new System.Drawing.Point(323, 19);
			this.buttonSettings.Name = "buttonSettings";
			this.buttonSettings.Size = new System.Drawing.Size(37, 37);
			this.buttonSettings.TabIndex = 2;
			this.buttonSettings.TabStop = false;
			this.toolTip1.SetToolTip(this.buttonSettings, "ツールの設定ダイアログを開きます");
			this.buttonSettings.UseVisualStyleBackColor = true;
			this.buttonSettings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonSettings_MouseClick);
			this.buttonSettings.MouseEnter += new System.EventHandler(this.buttonSettings_MouseEnter);
			this.buttonSettings.MouseLeave += new System.EventHandler(this.buttonSettings_MouseLeave);
			// 
			// buttonRedo
			// 
			this.buttonRedo.BackgroundImage = global::MyTool_ListFusen.Properties.Resources.redo;
			this.buttonRedo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonRedo.FlatAppearance.BorderSize = 0;
			this.buttonRedo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonRedo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonRedo.Location = new System.Drawing.Point(283, 19);
			this.buttonRedo.Name = "buttonRedo";
			this.buttonRedo.Size = new System.Drawing.Size(33, 37);
			this.buttonRedo.TabIndex = 2;
			this.buttonRedo.TabStop = false;
			this.toolTip1.SetToolTip(this.buttonRedo, "押すたびにメモの内容をアンドゥー・リドゥーします");
			this.buttonRedo.UseVisualStyleBackColor = true;
			this.buttonRedo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonRedo_MouseClick);
			this.buttonRedo.MouseEnter += new System.EventHandler(this.buttonRedo_MouseEnter);
			this.buttonRedo.MouseLeave += new System.EventHandler(this.buttonRedo_MouseLeave);
			// 
			// buttonUndo
			// 
			this.buttonUndo.BackgroundImage = global::MyTool_ListFusen.Properties.Resources.undo;
			this.buttonUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonUndo.FlatAppearance.BorderSize = 0;
			this.buttonUndo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonUndo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonUndo.Location = new System.Drawing.Point(244, 19);
			this.buttonUndo.Name = "buttonUndo";
			this.buttonUndo.Size = new System.Drawing.Size(33, 37);
			this.buttonUndo.TabIndex = 2;
			this.buttonUndo.TabStop = false;
			this.toolTip1.SetToolTip(this.buttonUndo, "押すたびにメモの内容をアンドゥー・リドゥーします");
			this.buttonUndo.UseVisualStyleBackColor = true;
			this.buttonUndo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonUndo_MouseClick);
			this.buttonUndo.MouseEnter += new System.EventHandler(this.buttonUndo_MouseEnter);
			this.buttonUndo.MouseLeave += new System.EventHandler(this.buttonUndo_MouseLeave);
			// 
			// buttonExport
			// 
			this.buttonExport.BackgroundImage = global::MyTool_ListFusen.Properties.Resources.export;
			this.buttonExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonExport.FlatAppearance.BorderSize = 0;
			this.buttonExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonExport.Location = new System.Drawing.Point(368, 19);
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Size = new System.Drawing.Size(33, 37);
			this.buttonExport.TabIndex = 2;
			this.buttonExport.TabStop = false;
			this.toolTip1.SetToolTip(this.buttonExport, "全てのメモを一括エクスポートします（メモ名の重複に注意）");
			this.buttonExport.UseVisualStyleBackColor = true;
			this.buttonExport.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonExport_MouseClick);
			this.buttonExport.MouseEnter += new System.EventHandler(this.buttonExport_MouseEnter);
			this.buttonExport.MouseLeave += new System.EventHandler(this.buttonExport_MouseLeave);
			// 
			// buttonDel
			// 
			this.buttonDel.BackgroundImage = global::MyTool_ListFusen.Properties.Resources.del;
			this.buttonDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonDel.FlatAppearance.BorderSize = 0;
			this.buttonDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDel.Location = new System.Drawing.Point(177, 19);
			this.buttonDel.Name = "buttonDel";
			this.buttonDel.Size = new System.Drawing.Size(33, 37);
			this.buttonDel.TabIndex = 2;
			this.buttonDel.TabStop = false;
			this.toolTip1.SetToolTip(this.buttonDel, "選択したメモを削除します（Del）");
			this.buttonDel.UseVisualStyleBackColor = true;
			this.buttonDel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonDel_MouseClick);
			this.buttonDel.MouseEnter += new System.EventHandler(this.buttonDel_MouseEnter);
			this.buttonDel.MouseLeave += new System.EventHandler(this.buttonDel_MouseLeave);
			// 
			// buttonReName
			// 
			this.buttonReName.BackgroundImage = global::MyTool_ListFusen.Properties.Resources.pen;
			this.buttonReName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonReName.FlatAppearance.BorderSize = 0;
			this.buttonReName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonReName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonReName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonReName.Location = new System.Drawing.Point(137, 19);
			this.buttonReName.Name = "buttonReName";
			this.buttonReName.Size = new System.Drawing.Size(33, 37);
			this.buttonReName.TabIndex = 2;
			this.buttonReName.TabStop = false;
			this.toolTip1.SetToolTip(this.buttonReName, "選択したメモをリネームします（F2）");
			this.buttonReName.UseVisualStyleBackColor = true;
			this.buttonReName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonReName_MouseClick);
			this.buttonReName.MouseEnter += new System.EventHandler(this.buttonReName_MouseEnter);
			this.buttonReName.MouseLeave += new System.EventHandler(this.buttonReName_MouseLeave);
			// 
			// buttonAdd
			// 
			this.buttonAdd.BackgroundImage = global::MyTool_ListFusen.Properties.Resources.add;
			this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonAdd.FlatAppearance.BorderSize = 0;
			this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAdd.Location = new System.Drawing.Point(97, 19);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(33, 37);
			this.buttonAdd.TabIndex = 2;
			this.buttonAdd.TabStop = false;
			this.toolTip1.SetToolTip(this.buttonAdd, "メモを新たに追加します");
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonAdd_MouseClick);
			this.buttonAdd.MouseEnter += new System.EventHandler(this.buttonAdd_MouseEnter);
			this.buttonAdd.MouseLeave += new System.EventHandler(this.buttonAdd_MouseLeave);
			// 
			// buttonDown
			// 
			this.buttonDown.BackgroundImage = global::MyTool_ListFusen.Properties.Resources.down;
			this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonDown.FlatAppearance.BorderSize = 0;
			this.buttonDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDown.Location = new System.Drawing.Point(56, 19);
			this.buttonDown.Name = "buttonDown";
			this.buttonDown.Size = new System.Drawing.Size(33, 37);
			this.buttonDown.TabIndex = 2;
			this.buttonDown.TabStop = false;
			this.toolTip1.SetToolTip(this.buttonDown, "選択したメモを下に移動します");
			this.buttonDown.UseVisualStyleBackColor = true;
			this.buttonDown.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonDown_MouseClick);
			this.buttonDown.MouseEnter += new System.EventHandler(this.buttonDown_MouseEnter);
			this.buttonDown.MouseLeave += new System.EventHandler(this.buttonDown_MouseLeave);
			// 
			// buttonUp
			// 
			this.buttonUp.BackgroundImage = global::MyTool_ListFusen.Properties.Resources.up;
			this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonUp.FlatAppearance.BorderSize = 0;
			this.buttonUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonUp.Location = new System.Drawing.Point(16, 19);
			this.buttonUp.Name = "buttonUp";
			this.buttonUp.Size = new System.Drawing.Size(33, 37);
			this.buttonUp.TabIndex = 2;
			this.buttonUp.TabStop = false;
			this.toolTip1.SetToolTip(this.buttonUp, "選択したメモを上に移動します");
			this.buttonUp.UseVisualStyleBackColor = true;
			this.buttonUp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonUp_MouseClick);
			this.buttonUp.MouseEnter += new System.EventHandler(this.buttonUp_MouseEnter);
			this.buttonUp.MouseLeave += new System.EventHandler(this.buttonUp_MouseLeave);
			// 
			// panelLabel2
			// 
			this.panelLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(130)))), ((int)(((byte)(45)))));
			this.panelLabel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelLabel2.Location = new System.Drawing.Point(0, 17);
			this.panelLabel2.Name = "panelLabel2";
			this.panelLabel2.Size = new System.Drawing.Size(5, 41);
			this.panelLabel2.TabIndex = 0;
			// 
			// panelUP
			// 
			this.panelUP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(35)))));
			this.panelUP.Controls.Add(this.panelLabel1);
			this.panelUP.Controls.Add(this.labelEsc);
			this.panelUP.Controls.Add(this.labelSaved);
			this.panelUP.Controls.Add(this.labelTitle);
			this.panelUP.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelUP.Location = new System.Drawing.Point(0, 0);
			this.panelUP.Name = "panelUP";
			this.panelUP.Size = new System.Drawing.Size(674, 17);
			this.panelUP.TabIndex = 0;
			this.panelUP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelUP_MouseDown);
			this.panelUP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelUP_MouseMove);
			// 
			// panelLabel1
			// 
			this.panelLabel1.BackColor = System.Drawing.Color.Goldenrod;
			this.panelLabel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelLabel1.Location = new System.Drawing.Point(0, 0);
			this.panelLabel1.Name = "panelLabel1";
			this.panelLabel1.Size = new System.Drawing.Size(5, 17);
			this.panelLabel1.TabIndex = 0;
			// 
			// labelEsc
			// 
			this.labelEsc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelEsc.AutoSize = true;
			this.labelEsc.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelEsc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(128)))), ((int)(((byte)(119)))));
			this.labelEsc.Location = new System.Drawing.Point(656, 0);
			this.labelEsc.Name = "labelEsc";
			this.labelEsc.Size = new System.Drawing.Size(16, 18);
			this.labelEsc.TabIndex = 3;
			this.labelEsc.Text = "x";
			this.labelEsc.Click += new System.EventHandler(this.labelEsc_Click);
			// 
			// labelSaved
			// 
			this.labelSaved.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelSaved.AutoSize = true;
			this.labelSaved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(30)))));
			this.labelSaved.Font = new System.Drawing.Font("メイリオ", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelSaved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(8)))), ((int)(((byte)(9)))));
			this.labelSaved.Location = new System.Drawing.Point(561, 1);
			this.labelSaved.Name = "labelSaved";
			this.labelSaved.Size = new System.Drawing.Size(62, 15);
			this.labelSaved.TabIndex = 2;
			this.labelSaved.Text = " S A V E D !";
			this.labelSaved.Visible = false;
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("メイリオ", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(159)))));
			this.labelTitle.Location = new System.Drawing.Point(11, 1);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(125, 15);
			this.labelTitle.TabIndex = 1;
			this.labelTitle.Text = "L I S T  F U S E N　v1.05";
			// 
			// splitContainer1
			// 
			this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
			this.splitContainer1.DataBindings.Add(new System.Windows.Forms.Binding("SplitterDistance", global::MyTool_ListFusen.Properties.Settings.Default, "splitDist", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(5, 63);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.panelLeft);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.panelRight);
			this.splitContainer1.Size = new System.Drawing.Size(674, 408);
			this.splitContainer1.SplitterDistance = global::MyTool_ListFusen.Properties.Settings.Default.splitDist;
			this.splitContainer1.TabIndex = 4;
			// 
			// panelLeft
			// 
			this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
			this.panelLeft.Controls.Add(this.panelLabel3);
			this.panelLeft.Controls.Add(this.listBox1);
			this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelLeft.Location = new System.Drawing.Point(0, 0);
			this.panelLeft.Name = "panelLeft";
			this.panelLeft.Size = new System.Drawing.Size(179, 408);
			this.panelLeft.TabIndex = 3;
			// 
			// panelLabel3
			// 
			this.panelLabel3.BackColor = System.Drawing.Color.Goldenrod;
			this.panelLabel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelLabel3.Location = new System.Drawing.Point(0, 0);
			this.panelLabel3.Name = "panelLabel3";
			this.panelLabel3.Size = new System.Drawing.Size(5, 408);
			this.panelLabel3.TabIndex = 0;
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
			this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::MyTool_ListFusen.Properties.Settings.Default, "listBoxFStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::MyTool_ListFusen.Properties.Settings.Default, "listBoxFColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.listBox1.Font = global::MyTool_ListFusen.Properties.Settings.Default.listBoxFStyle;
			this.listBox1.ForeColor = global::MyTool_ListFusen.Properties.Settings.Default.listBoxFColor;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 20;
			this.listBox1.Location = new System.Drawing.Point(17, 9);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(159, 380);
			this.listBox1.TabIndex = 1;
			this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
			this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
			// 
			// panelRight
			// 
			this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
			this.panelRight.Controls.Add(this.textBox1);
			this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelRight.Location = new System.Drawing.Point(0, 0);
			this.panelRight.Name = "panelRight";
			this.panelRight.Size = new System.Drawing.Size(491, 408);
			this.panelRight.TabIndex = 0;
			// 
			// textBox1
			// 
			this.textBox1.AcceptsTab = true;
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::MyTool_ListFusen.Properties.Settings.Default, "textBoxFStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::MyTool_ListFusen.Properties.Settings.Default, "textBoxFColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBox1.Font = global::MyTool_ListFusen.Properties.Settings.Default.textBoxFStyle;
			this.textBox1.ForeColor = global::MyTool_ListFusen.Properties.Settings.Default.textBoxFColor;
			this.textBox1.Location = new System.Drawing.Point(14, 9);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(465, 390);
			this.textBox1.TabIndex = 0;
			this.textBox1.WordWrap = false;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			// 
			// panelBarTop
			// 
			this.panelBarTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(232)))));
			this.panelBarTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelBarTop.Enabled = false;
			this.panelBarTop.Location = new System.Drawing.Point(0, 0);
			this.panelBarTop.Name = "panelBarTop";
			this.panelBarTop.Size = new System.Drawing.Size(684, 5);
			this.panelBarTop.TabIndex = 5;
			// 
			// panelBarBottom
			// 
			this.panelBarBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(232)))));
			this.panelBarBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelBarBottom.Enabled = false;
			this.panelBarBottom.Location = new System.Drawing.Point(0, 471);
			this.panelBarBottom.Name = "panelBarBottom";
			this.panelBarBottom.Size = new System.Drawing.Size(684, 5);
			this.panelBarBottom.TabIndex = 5;
			// 
			// panelBarLeft
			// 
			this.panelBarLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(232)))));
			this.panelBarLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelBarLeft.Enabled = false;
			this.panelBarLeft.Location = new System.Drawing.Point(0, 5);
			this.panelBarLeft.Name = "panelBarLeft";
			this.panelBarLeft.Size = new System.Drawing.Size(5, 466);
			this.panelBarLeft.TabIndex = 5;
			// 
			// panelBarRight
			// 
			this.panelBarRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(232)))));
			this.panelBarRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.panelBarRight.Enabled = false;
			this.panelBarRight.Location = new System.Drawing.Point(679, 5);
			this.panelBarRight.Name = "panelBarRight";
			this.panelBarRight.Size = new System.Drawing.Size(5, 466);
			this.panelBarRight.TabIndex = 5;
			// 
			// panelDirty
			// 
			this.panelDirty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panelDirty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(30)))));
			this.panelDirty.Location = new System.Drawing.Point(583, 45);
			this.panelDirty.Name = "panelDirty";
			this.panelDirty.Size = new System.Drawing.Size(20, 4);
			this.panelDirty.TabIndex = 1;
			this.panelDirty.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 476);
			this.ControlBox = false;
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.panelButton);
			this.Controls.Add(this.panelBarRight);
			this.Controls.Add(this.panelBarLeft);
			this.Controls.Add(this.panelBarBottom);
			this.Controls.Add(this.panelBarTop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(526, 220);
			this.Name = "Form1";
			this.Text = "ListFusen";
			this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panelButton.ResumeLayout(false);
			this.panelUP.ResumeLayout(false);
			this.panelUP.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.panelLeft.ResumeLayout(false);
			this.panelRight.ResumeLayout(false);
			this.panelRight.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panelButton;
		private System.Windows.Forms.Panel panelLeft;
		private System.Windows.Forms.Panel panelRight;
		private System.Windows.Forms.Panel panelUP;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Label labelEsc;
		private System.Windows.Forms.Panel panelLabel3;
		private System.Windows.Forms.Panel panelLabel1;
		private System.Windows.Forms.Panel panelLabel2;
		private System.Windows.Forms.Label labelSaved;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button buttonUp;
		private System.Windows.Forms.Button buttonDown;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonReName;
		private System.Windows.Forms.Button buttonDel;
		private System.Windows.Forms.Button buttonFront;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonRedo;
		private System.Windows.Forms.Button buttonUndo;
		private System.Windows.Forms.Button buttonExport;
		private System.Windows.Forms.Panel panelLine;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button buttonSettings;
		public System.Windows.Forms.ListBox listBox1;
		public System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Panel panelBarTop;
		private System.Windows.Forms.Panel panelBarBottom;
		private System.Windows.Forms.Panel panelBarLeft;
		private System.Windows.Forms.Panel panelBarRight;
		private System.Windows.Forms.Panel panelDirty;
	}
}

