namespace XMLEditor
{
    partial class AccordionItem
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
            this.pageStartTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pageEndTextBox = new System.Windows.Forms.TextBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.addAuthorButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.authorsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.TableLayoutPanel();
            this.abstractTextBox = new HighlightedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.titleTextBox = new HighlightedTextBox();
            this.previewButton = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageStartTextBox
            // 
            this.pageStartTextBox.Location = new System.Drawing.Point(75, 33);
            this.pageStartTextBox.Name = "pageStartTextBox";
            this.pageStartTextBox.Size = new System.Drawing.Size(45, 20);
            this.pageStartTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Страницы";
            // 
            // pageEndTextBox
            // 
            this.pageEndTextBox.Location = new System.Drawing.Point(126, 33);
            this.pageEndTextBox.Name = "pageEndTextBox";
            this.pageEndTextBox.Size = new System.Drawing.Size(45, 20);
            this.pageEndTextBox.TabIndex = 3;
            // 
            // headerPanel
            // 
            this.headerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.headerPanel.Controls.Add(this.titleTextBox);
            this.headerPanel.Controls.Add(this.addAuthorButton);
            this.headerPanel.Controls.Add(this.label3);
            this.headerPanel.Controls.Add(this.languageComboBox);
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Controls.Add(this.pageStartTextBox);
            this.headerPanel.Controls.Add(this.pageEndTextBox);
            this.headerPanel.Location = new System.Drawing.Point(3, 3);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(530, 59);
            this.headerPanel.TabIndex = 6;
            // 
            // addAuthorButton
            // 
            this.addAuthorButton.Location = new System.Drawing.Point(327, 30);
            this.addAuthorButton.Name = "addAuthorButton";
            this.addAuthorButton.Size = new System.Drawing.Size(114, 23);
            this.addAuthorButton.TabIndex = 9;
            this.addAuthorButton.Text = "Добавить автора";
            this.addAuthorButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Язык";
            // 
            // languageComboBox
            // 
            this.languageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            "EN",
            "RU"});
            this.languageComboBox.Location = new System.Drawing.Point(244, 32);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(41, 21);
            this.languageComboBox.TabIndex = 7;
            // 
            // authorsPanel
            // 
            this.authorsPanel.AutoSize = true;
            this.authorsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.authorsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.authorsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.authorsPanel.Location = new System.Drawing.Point(3, 68);
            this.authorsPanel.Name = "authorsPanel";
            this.authorsPanel.Size = new System.Drawing.Size(530, 1);
            this.authorsPanel.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.ColumnCount = 1;
            this.panel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel1.Controls.Add(this.authorsPanel, 0, 1);
            this.panel1.Controls.Add(this.headerPanel, 0, 0);
            this.panel1.Controls.Add(this.abstractTextBox, 0, 2);
            this.panel1.Controls.Add(this.panel2, 0, 3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.RowCount = 5;
            this.panel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.panel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.panel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel1.Size = new System.Drawing.Size(536, 281);
            this.panel1.TabIndex = 13;
            // 
            // abstractTextBox
            // 
            this.abstractTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.abstractTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.abstractTextBox.Location = new System.Drawing.Point(3, 74);
            this.abstractTextBox.Name = "abstractTextBox";
            this.abstractTextBox.Size = new System.Drawing.Size(530, 174);
            this.abstractTextBox.TabIndex = 8;
            this.abstractTextBox.Text = "";
            this.abstractTextBox.VisibleChanged += new System.EventHandler(this.rtf_VisibilityChange);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.previewButton);
            this.panel2.Controls.Add(this.deleteButton);
            this.panel2.Controls.Add(this.upButton);
            this.panel2.Controls.Add(this.downButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 254);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 24);
            this.panel2.TabIndex = 9;
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.deleteButton.Image = global::XMLEditor.Properties.Resources._1385_Disable_16x16_72;
            this.deleteButton.Location = new System.Drawing.Point(458, 0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(24, 24);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // upButton
            // 
            this.upButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.upButton.Image = global::XMLEditor.Properties.Resources._010_HighPriority_16x16_72;
            this.upButton.Location = new System.Drawing.Point(482, 0);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(24, 24);
            this.upButton.TabIndex = 1;
            this.upButton.UseVisualStyleBackColor = true;
            // 
            // downButton
            // 
            this.downButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.downButton.Image = global::XMLEditor.Properties.Resources._010_LowPriority_16x16_72;
            this.downButton.Location = new System.Drawing.Point(506, 0);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(24, 24);
            this.downButton.TabIndex = 0;
            this.downButton.UseVisualStyleBackColor = true;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTextBox.Location = new System.Drawing.Point(4, 4);
            this.titleTextBox.Multiline = false;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(523, 20);
            this.titleTextBox.TabIndex = 10;
            this.titleTextBox.Text = "";
            this.titleTextBox.VisibleChanged += new System.EventHandler(this.rtf_VisibilityChange);
            // 
            // previewButton
            // 
            this.previewButton.Location = new System.Drawing.Point(0, -2);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(75, 23);
            this.previewButton.TabIndex = 3;
            this.previewButton.Text = "Просм.";
            this.previewButton.UseVisualStyleBackColor = true;
            // 
            // AccordionItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(582, 545);
            this.Controls.Add(this.panel1);
            this.Name = "AccordionItem";
            this.Text = "AccordionItemSampleForm";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pageStartTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pageEndTextBox;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel authorsPanel;
        private System.Windows.Forms.TableLayoutPanel panel1;
        private System.Windows.Forms.RichTextBox abstractTextBox;
        private System.Windows.Forms.Button addAuthorButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.RichTextBox titleTextBox;
        private System.Windows.Forms.Button previewButton;
    }
}