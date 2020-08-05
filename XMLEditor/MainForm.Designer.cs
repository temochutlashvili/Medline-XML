namespace XMLEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.yearTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.issueTextBox = new System.Windows.Forms.TextBox();
            this.volumeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.issnTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.monthTextBox = new System.Windows.Forms.MaskedTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton_AddClipboard = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem_AddClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_AddClipboardRewrite = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton_Add = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.stopJobButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripProgressBar_importClipboard = new System.Windows.Forms.ToolStripProgressBar();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.undoButton = new System.Windows.Forms.ToolStripButton();
            this.rawXML = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.newButton = new System.Windows.Forms.ToolStripButton();
            this.openButton = new System.Windows.Forms.ToolStripButton();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.publisherTextBox = new XMLEditor.HighlightedTextBox();
            this.accordion1 = new Opulos.Core.UI.Accordion();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1390, 537);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            this.tabControl1.Deselected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Deselected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1382, 511);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Общие параметры";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(831, 451);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры номера";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.yearTextBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.issueTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.volumeTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.publisherTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.issnTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.monthTextBox, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(38, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(643, 283);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(92, 243);
            this.yearTextBox.Mask = "0000";
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(47, 20);
            this.yearTextBox.TabIndex = 12;
            this.yearTextBox.TextChanged += new System.EventHandler(this.paramsChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Месяц";
            // 
            // issueTextBox
            // 
            this.issueTextBox.Location = new System.Drawing.Point(92, 163);
            this.issueTextBox.Name = "issueTextBox";
            this.issueTextBox.Size = new System.Drawing.Size(291, 20);
            this.issueTextBox.TabIndex = 9;
            this.issueTextBox.TextChanged += new System.EventHandler(this.paramsChanged);
            // 
            // volumeTextBox
            // 
            this.volumeTextBox.Location = new System.Drawing.Point(92, 123);
            this.volumeTextBox.Name = "volumeTextBox";
            this.volumeTextBox.Size = new System.Drawing.Size(291, 20);
            this.volumeTextBox.TabIndex = 7;
            this.volumeTextBox.TextChanged += new System.EventHandler(this.paramsChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Наименование";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Издатель";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(92, 43);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(291, 20);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.Text = "Geogian Medical News";
            this.nameTextBox.TextChanged += new System.EventHandler(this.paramsChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ISSN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Volume";
            this.label4.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Issue";
            // 
            // issnTextBox
            // 
            this.issnTextBox.Location = new System.Drawing.Point(92, 83);
            this.issnTextBox.Name = "issnTextBox";
            this.issnTextBox.Size = new System.Drawing.Size(291, 20);
            this.issnTextBox.TabIndex = 5;
            this.issnTextBox.Text = "Geogian Medical News";
            this.issnTextBox.TextChanged += new System.EventHandler(this.paramsChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Год";
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(92, 203);
            this.monthTextBox.Mask = "00";
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(34, 20);
            this.monthTextBox.TabIndex = 11;
            this.monthTextBox.TextChanged += new System.EventHandler(this.paramsChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.toolStrip1);
            this.tabPage2.Controls.Add(this.accordion1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1382, 511);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Статьи";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton_AddClipboard,
            this.toolStripButton_Add,
            this.toolStripSeparator1,
            this.stopJobButton,
            this.toolStripProgressBar_importClipboard});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1376, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton_AddClipboard
            // 
            this.toolStripSplitButton_AddClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton_AddClipboard.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_AddClipboard,
            this.toolStripMenuItem_AddClipboardRewrite});
            this.toolStripSplitButton_AddClipboard.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton_AddClipboard.Image")));
            this.toolStripSplitButton_AddClipboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton_AddClipboard.Name = "toolStripSplitButton_AddClipboard";
            this.toolStripSplitButton_AddClipboard.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton_AddClipboard.Text = "Добавить из буфера";
            this.toolStripSplitButton_AddClipboard.ButtonClick += new System.EventHandler(this.ImportClipboard_ButtonClick);
            // 
            // toolStripMenuItem_AddClipboard
            // 
            this.toolStripMenuItem_AddClipboard.Name = "toolStripMenuItem_AddClipboard";
            this.toolStripMenuItem_AddClipboard.Size = new System.Drawing.Size(270, 22);
            this.toolStripMenuItem_AddClipboard.Text = "Добавить из буфера";
            this.toolStripMenuItem_AddClipboard.ToolTipText = "Добавить из буфера";
            // 
            // toolStripMenuItem_AddClipboardRewrite
            // 
            this.toolStripMenuItem_AddClipboardRewrite.Name = "toolStripMenuItem_AddClipboardRewrite";
            this.toolStripMenuItem_AddClipboardRewrite.Size = new System.Drawing.Size(270, 22);
            this.toolStripMenuItem_AddClipboardRewrite.Text = "Добавить из буфера с перезаписью";
            this.toolStripMenuItem_AddClipboardRewrite.ToolTipText = "Добавить из буфера с перезаписью";
            this.toolStripMenuItem_AddClipboardRewrite.Click += new System.EventHandler(this.importOverwrite_ButtonClick);
            // 
            // toolStripButton_Add
            // 
            this.toolStripButton_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Add.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Add.Image")));
            this.toolStripButton_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Add.Name = "toolStripButton_Add";
            this.toolStripButton_Add.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Add.Text = "Добавить";
            this.toolStripButton_Add.ToolTipText = "Добавить";
            this.toolStripButton_Add.Click += new System.EventHandler(this.AddArticle_ButtonClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // stopJobButton
            // 
            this.stopJobButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.stopJobButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopJobButton.Image = global::XMLEditor.Properties.Resources.BreakpointEnabled_6584_16x;
            this.stopJobButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopJobButton.Name = "stopJobButton";
            this.stopJobButton.Size = new System.Drawing.Size(23, 22);
            this.stopJobButton.Text = "Stop";
            this.stopJobButton.Visible = false;
            this.stopJobButton.Click += new System.EventHandler(this.stopButtonClick);
            // 
            // toolStripProgressBar_importClipboard
            // 
            this.toolStripProgressBar_importClipboard.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar_importClipboard.Name = "toolStripProgressBar_importClipboard";
            this.toolStripProgressBar_importClipboard.Size = new System.Drawing.Size(300, 22);
            this.toolStripProgressBar_importClipboard.Visible = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.toolStrip3);
            this.tabPage4.Controls.Add(this.rawXML);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1382, 511);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Raw";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoButton});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(1376, 25);
            this.toolStrip3.TabIndex = 1;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // undoButton
            // 
            this.undoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.undoButton.Enabled = false;
            this.undoButton.Image = ((System.Drawing.Image)(resources.GetObject("undoButton.Image")));
            this.undoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(86, 22);
            this.undoButton.Text = "Восстановить";
            this.undoButton.Click += new System.EventHandler(this.undoClick);
            // 
            // rawXML
            // 
            this.rawXML.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rawXML.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rawXML.Location = new System.Drawing.Point(3, 31);
            this.rawXML.Name = "rawXML";
            this.rawXML.Size = new System.Drawing.Size(1376, 477);
            this.rawXML.TabIndex = 0;
            this.rawXML.Text = "";
            this.rawXML.TextChanged += new System.EventHandler(this.rawXML_TextChanged);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newButton,
            this.openButton,
            this.saveButton,
            this.toolStripButton1});
            this.toolStrip2.Location = new System.Drawing.Point(4, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1382, 25);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // newButton
            // 
            this.newButton.Image = global::XMLEditor.Properties.Resources.action_create_16xLG;
            this.newButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(65, 22);
            this.newButton.Text = "Новый";
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // openButton
            // 
            this.openButton.Image = global::XMLEditor.Properties.Resources.folder_Open_16xLG;
            this.openButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(74, 22);
            this.openButton.Text = "Открыть";
            this.openButton.Click += new System.EventHandler(this.openFileClick);
            // 
            // saveButton
            // 
            this.saveButton.Image = global::XMLEditor.Properties.Resources.save_16xLG;
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(86, 22);
            this.saveButton.Text = "Сохранить";
            this.saveButton.Click += new System.EventHandler(this.saveButtonClick);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::XMLEditor.Properties.Resources.Symbols_Attribute_32xLG;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.characterMapClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 568);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1389, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Sgml file|*.sgml";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Location = new System.Drawing.Point(92, 3);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(291, 20);
            this.publisherTextBox.TabIndex = 1;
            this.publisherTextBox.Text = "Georgian Medical News";
            this.publisherTextBox.TextChanged += new System.EventHandler(this.paramsChanged);
            // 
            // accordion1
            // 
            this.accordion1.AddResizeBars = true;
            this.accordion1.AllowMouseResize = true;
            this.accordion1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accordion1.AnimateCloseEffect = ((Opulos.Core.UI.AnimateWindowFlags)(((Opulos.Core.UI.AnimateWindowFlags.VerticalNegative | Opulos.Core.UI.AnimateWindowFlags.Hide) 
            | Opulos.Core.UI.AnimateWindowFlags.Slide)));
            this.accordion1.AnimateCloseMillis = 300;
            this.accordion1.AnimateOpenEffect = ((Opulos.Core.UI.AnimateWindowFlags)(((Opulos.Core.UI.AnimateWindowFlags.VerticalPositive | Opulos.Core.UI.AnimateWindowFlags.Show) 
            | Opulos.Core.UI.AnimateWindowFlags.Slide)));
            this.accordion1.AnimateOpenMillis = 300;
            this.accordion1.AutoFixDockStyle = true;
            this.accordion1.AutoScroll = true;
            this.accordion1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.accordion1.CheckBoxFactory = null;
            this.accordion1.CheckBoxMargin = null;
            this.accordion1.ContentBackColor = null;
            this.accordion1.ContentMargin = null;
            this.accordion1.ContentPadding = new System.Windows.Forms.Padding(5);
            this.accordion1.ControlBackColor = null;
            this.accordion1.ControlMinimumHeightIsItsPreferredHeight = true;
            this.accordion1.ControlMinimumWidthIsItsPreferredWidth = true;
            this.accordion1.DownArrow = null;
            this.accordion1.FillHeight = true;
            this.accordion1.FillLastOpened = false;
            this.accordion1.FillModeGrowOnly = false;
            this.accordion1.FillResetOnCollapse = false;
            this.accordion1.FillWidth = true;
            this.accordion1.GrabCursor = System.Windows.Forms.Cursors.SizeNS;
            this.accordion1.GrabRequiresPositiveFillWeight = true;
            this.accordion1.GrabWidth = 6;
            this.accordion1.GrowAndShrink = true;
            this.accordion1.Insets = new System.Windows.Forms.Padding(0);
            this.accordion1.Location = new System.Drawing.Point(3, 31);
            this.accordion1.Name = "accordion1";
            this.accordion1.OpenOnAdd = true;
            this.accordion1.OpenOneOnly = false;
            this.accordion1.ResizeBarFactory = null;
            this.accordion1.ResizeBarsAlign = 0.5D;
            this.accordion1.ResizeBarsArrowKeyDelta = 10;
            this.accordion1.ResizeBarsFadeInMillis = 800;
            this.accordion1.ResizeBarsFadeOutMillis = 800;
            this.accordion1.ResizeBarsFadeProximity = 24;
            this.accordion1.ResizeBarsFill = 1D;
            this.accordion1.ResizeBarsKeepFocusAfterMouseDrag = false;
            this.accordion1.ResizeBarsKeepFocusIfControlOutOfView = true;
            this.accordion1.ResizeBarsKeepFocusOnClick = true;
            this.accordion1.ResizeBarsMargin = null;
            this.accordion1.ResizeBarsMinimumLength = 50;
            this.accordion1.ResizeBarsStayInViewOnArrowKey = true;
            this.accordion1.ResizeBarsStayInViewOnMouseDrag = true;
            this.accordion1.ResizeBarsStayVisibleIfFocused = true;
            this.accordion1.ResizeBarsTabStop = true;
            this.accordion1.ShowPartiallyVisibleResizeBars = false;
            this.accordion1.ShowToolMenu = true;
            this.accordion1.ShowToolMenuOnHoverWhenClosed = false;
            this.accordion1.ShowToolMenuOnRightClick = true;
            this.accordion1.ShowToolMenuRequiresPositiveFillWeight = false;
            this.accordion1.Size = new System.Drawing.Size(1376, 477);
            this.accordion1.TabIndex = 0;
            this.accordion1.UpArrow = null;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1389, 590);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Enter += new System.EventHandler(this.FocusEnter);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        public Opulos.Core.UI.Accordion accordion1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RichTextBox rawXML;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private HighlightedTextBox publisherTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox issnTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox volumeTextBox;
        private System.Windows.Forms.TextBox issueTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Add;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton_AddClipboard;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_AddClipboard;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_AddClipboardRewrite;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar_importClipboard;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton newButton;
        private System.Windows.Forms.ToolStripButton openButton;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton undoButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox yearTextBox;
        private System.Windows.Forms.MaskedTextBox monthTextBox;
        private System.Windows.Forms.ToolStripButton stopJobButton;
    }
}

