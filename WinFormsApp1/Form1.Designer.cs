namespace WinFormsApp1
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			bindingSource1 = new BindingSource(components);
			button1 = new Button();
			checkBox1 = new CheckBox();
			checkedListBox1 = new CheckedListBox();
			color = new ColorDialog();
			comboBox1 = new ComboBox();
			contextMenuStrip1 = new ContextMenuStrip(components);
			inicioToolStripMenuItem = new ToolStripMenuItem();
			dataGridView1 = new DataGridView();
			domainUpDown1 = new DomainUpDown();
			errorProvider1 = new ErrorProvider(components);
			fileSystemWatcher1 = new FileSystemWatcher();
			flowLayoutPanel1 = new FlowLayoutPanel();
			fontDialog1 = new FontDialog();
			imageList1 = new ImageList(components);
			label1 = new Label();
			linkLabel1 = new LinkLabel();
			listBox1 = new ListBox();
			maskedTextBox1 = new MaskedTextBox();
			pictureBox1 = new PictureBox();
			timer1 = new System.Windows.Forms.Timer(components);
			splitContainer1 = new SplitContainer();
			toolStripContainer1 = new ToolStripContainer();
			progressBar1 = new ProgressBar();
			treeView1 = new TreeView();
			radioButton1 = new RadioButton();
			tableLayoutPanel1 = new TableLayoutPanel();
			toolTip1 = new ToolTip(components);
			richTextBox1 = new RichTextBox();
			notifyIcon1 = new NotifyIcon(components);
			numericUpDown1 = new NumericUpDown();
			vScrollBar1 = new VScrollBar();
			((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
			contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.SuspendLayout();
			toolStripContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			SuspendLayout();
			// 
			// backgroundWorker1
			// 
			backgroundWorker1.DoWork += backgroundWorker1_DoWork;
			// 
			// bindingSource1
			// 
			bindingSource1.CurrentChanged += bindingSource1_CurrentChanged;
			// 
			// button1
			// 
			button1.BackColor = Color.IndianRed;
			button1.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button1.ForeColor = Color.White;
			button1.Location = new Point(23, 85);
			button1.Name = "button1";
			button1.Size = new Size(120, 50);
			button1.TabIndex = 0;
			button1.Text = "Hello ";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			checkBox1.ForeColor = Color.Maroon;
			checkBox1.Location = new Point(149, 85);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(96, 19);
			checkBox1.TabIndex = 1;
			checkBox1.Text = "Sleep 8 hours";
			checkBox1.UseVisualStyleBackColor = true;
			checkBox1.CheckedChanged += checkBox1_CheckedChanged;
			// 
			// checkedListBox1
			// 
			checkedListBox1.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			checkedListBox1.ForeColor = Color.Tomato;
			checkedListBox1.FormattingEnabled = true;
			checkedListBox1.Items.AddRange(new object[] { "Hello", "my name is Silvia ", "holaaaaaaaaaaaa" });
			checkedListBox1.Location = new Point(23, 141);
			checkedListBox1.Name = "checkedListBox1";
			checkedListBox1.Size = new Size(141, 52);
			checkedListBox1.TabIndex = 2;
			checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
			// 
			// color
			// 
			color.Color = Color.Gray;
			color.SolidColorOnly = true;
			// 
			// comboBox1
			// 
			comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			comboBox1.BackColor = Color.DarkOrange;
			comboBox1.Font = new Font("PMingLiU-ExtB", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "pollo", "nuggets", "ensalada" });
			comboBox1.Location = new Point(23, 199);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(170, 21);
			comboBox1.TabIndex = 3;
			comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem });
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.ShowCheckMargin = true;
			contextMenuStrip1.Size = new Size(126, 26);
			// 
			// inicioToolStripMenuItem
			// 
			inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
			inicioToolStripMenuItem.Size = new Size(125, 22);
			inicioToolStripMenuItem.Text = "Inicio";
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(326, 36);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(198, 99);
			dataGridView1.TabIndex = 4;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// domainUpDown1
			// 
			domainUpDown1.Location = new Point(326, 141);
			domainUpDown1.Name = "domainUpDown1";
			domainUpDown1.Size = new Size(205, 23);
			domainUpDown1.TabIndex = 5;
			domainUpDown1.Text = "domainUpDown1";
			domainUpDown1.SelectedItemChanged += domainUpDown1_SelectedItemChanged;
			// 
			// errorProvider1
			// 
			errorProvider1.ContainerControl = this;
			// 
			// fileSystemWatcher1
			// 
			fileSystemWatcher1.EnableRaisingEvents = true;
			fileSystemWatcher1.SynchronizingObject = this;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Location = new Point(12, 245);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(122, 89);
			flowLayoutPanel1.TabIndex = 6;
			flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
			// 
			// fontDialog1
			// 
			fontDialog1.Tag = "Holaa";
			// 
			// imageList1
			// 
			imageList1.ColorDepth = ColorDepth.Depth8Bit;
			imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
			imageList1.TransparentColor = Color.Transparent;
			imageList1.Images.SetKeyName(0, "R.png");
			imageList1.Images.SetKeyName(1, "3.png");
			imageList1.Images.SetKeyName(2, "4.png");
			imageList1.Images.SetKeyName(3, "5.png");
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(254, 190);
			label1.Name = "label1";
			label1.Size = new Size(38, 15);
			label1.TabIndex = 7;
			label1.Text = "label1";
			label1.Click += label1_Click;
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Location = new Point(218, 246);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(60, 15);
			linkLabel1.TabIndex = 8;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "linkLabel1";
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 15;
			listBox1.Items.AddRange(new object[] { "h", "e", "l", "l", "o" });
			listBox1.Location = new Point(336, 182);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(171, 94);
			listBox1.TabIndex = 9;
			listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
			// 
			// maskedTextBox1
			// 
			maskedTextBox1.Location = new Point(167, 301);
			maskedTextBox1.Name = "maskedTextBox1";
			maskedTextBox1.Size = new Size(125, 23);
			maskedTextBox1.TabIndex = 10;
			maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.Class;
			pictureBox1.Location = new Point(555, 36);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(135, 112);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 11;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// timer1
			// 
			timer1.Tick += timer1_Tick;
			// 
			// splitContainer1
			// 
			splitContainer1.Location = new Point(696, 36);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
			splitContainer1.Size = new Size(150, 100);
			splitContainer1.TabIndex = 12;
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.ContentPanel
			// 
			toolStripContainer1.ContentPanel.Size = new Size(256, 58);
			toolStripContainer1.Location = new Point(555, 166);
			toolStripContainer1.Name = "toolStripContainer1";
			toolStripContainer1.Size = new Size(256, 83);
			toolStripContainer1.TabIndex = 13;
			toolStripContainer1.Text = "toolStripContainer1";
			// 
			// progressBar1
			// 
			progressBar1.ForeColor = Color.IndianRed;
			progressBar1.Location = new Point(341, 301);
			progressBar1.Name = "progressBar1";
			progressBar1.Size = new Size(236, 23);
			progressBar1.TabIndex = 14;
			progressBar1.Click += progressBar1_Click;
			// 
			// treeView1
			// 
			treeView1.ImageIndex = 0;
			treeView1.ImageList = imageList1;
			treeView1.Location = new Point(852, 36);
			treeView1.Name = "treeView1";
			treeView1.SelectedImageIndex = 0;
			treeView1.Size = new Size(120, 87);
			treeView1.TabIndex = 15;
			// 
			// radioButton1
			// 
			radioButton1.AutoSize = true;
			radioButton1.Location = new Point(622, 267);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(94, 19);
			radioButton1.TabIndex = 16;
			radioButton1.TabStop = true;
			radioButton1.Text = "radioButton1";
			radioButton1.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 5;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			tableLayoutPanel1.Location = new Point(813, 267);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 3;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel1.Size = new Size(200, 100);
			tableLayoutPanel1.TabIndex = 17;
			// 
			// richTextBox1
			// 
			richTextBox1.BorderStyle = BorderStyle.FixedSingle;
			richTextBox1.Cursor = Cursors.WaitCursor;
			richTextBox1.Enabled = false;
			richTextBox1.Font = new Font("MV Boli", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
			richTextBox1.Location = new Point(23, 8);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(255, 71);
			richTextBox1.TabIndex = 18;
			richTextBox1.Text = "El dia de hoy nos encontramos usando las clases y creacion de objetos de la caja de herramientas";
			// 
			// notifyIcon1
			// 
			notifyIcon1.Text = "notifyIcon1";
			notifyIcon1.Visible = true;
			// 
			// numericUpDown1
			// 
			numericUpDown1.Location = new Point(196, 269);
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(120, 23);
			numericUpDown1.TabIndex = 19;
			// 
			// vScrollBar1
			// 
			vScrollBar1.Location = new Point(117, 359);
			vScrollBar1.Name = "vScrollBar1";
			vScrollBar1.Size = new Size(17, 80);
			vScrollBar1.TabIndex = 20;
			vScrollBar1.Scroll += vScrollBar1_Scroll;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1025, 484);
			Controls.Add(vScrollBar1);
			Controls.Add(numericUpDown1);
			Controls.Add(richTextBox1);
			Controls.Add(tableLayoutPanel1);
			Controls.Add(radioButton1);
			Controls.Add(treeView1);
			Controls.Add(progressBar1);
			Controls.Add(toolStripContainer1);
			Controls.Add(splitContainer1);
			Controls.Add(pictureBox1);
			Controls.Add(maskedTextBox1);
			Controls.Add(listBox1);
			Controls.Add(linkLabel1);
			Controls.Add(label1);
			Controls.Add(flowLayoutPanel1);
			Controls.Add(domainUpDown1);
			Controls.Add(dataGridView1);
			Controls.Add(comboBox1);
			Controls.Add(checkedListBox1);
			Controls.Add(checkBox1);
			Controls.Add(button1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
			contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			toolStripContainer1.ResumeLayout(false);
			toolStripContainer1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private BindingSource bindingSource1;
		private Button button1;
		private CheckBox checkBox1;
		private CheckedListBox checkedListBox1;
		private ColorDialog color;
		private ComboBox comboBox1;
		private ContextMenuStrip contextMenuStrip1;
		private ToolStripMenuItem inicioToolStripMenuItem;
		private DataGridView dataGridView1;
		private DomainUpDown domainUpDown1;
		private ErrorProvider errorProvider1;
		private FileSystemWatcher fileSystemWatcher1;
		private FlowLayoutPanel flowLayoutPanel1;
		private FontDialog fontDialog1;
		private ImageList imageList1;
		private MaskedTextBox maskedTextBox1;
		private ListBox listBox1;
		private LinkLabel linkLabel1;
		private Label label1;
		private PictureBox pictureBox1;
		private System.Windows.Forms.Timer timer1;
		private SplitContainer splitContainer1;
		private ProgressBar progressBar1;
		private ToolStripContainer toolStripContainer1;
		private TreeView treeView1;
		private TableLayoutPanel tableLayoutPanel1;
		private RadioButton radioButton1;
		private RichTextBox richTextBox1;
		private ToolTip toolTip1;
		private NumericUpDown numericUpDown1;
		private NotifyIcon notifyIcon1;
		private VScrollBar vScrollBar1;
	}
}
