namespace XMLEditor
{
    partial class CharacterMap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterMap));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.favoritesButton = new System.Windows.Forms.ToolStripButton();
            this.basicLatinButton = new System.Windows.Forms.ToolStripButton();
            this.latinSupplementButton = new System.Windows.Forms.ToolStripButton();
            this.latinExtendedButton = new System.Windows.Forms.ToolStripButton();
            this.greekButton = new System.Windows.Forms.ToolStripButton();
            this.superscriptButton = new System.Windows.Forms.ToolStripButton();
            this.mathButton = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.basicLatinPage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.addToFavouritesMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьВИзбранноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFromFavouritesMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.addToFavouritesMenuStrip.SuspendLayout();
            this.removeFromFavouritesMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.favoritesButton,
            this.basicLatinButton,
            this.latinSupplementButton,
            this.latinExtendedButton,
            this.greekButton,
            this.superscriptButton,
            this.mathButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(674, 32);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Click += new System.EventHandler(this.toolStrip1_Click);
            // 
            // favoritesButton
            // 
            this.favoritesButton.CheckOnClick = true;
            this.favoritesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.favoritesButton.Image = global::XMLEditor.Properties.Resources.heart_16xLG;
            this.favoritesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.favoritesButton.Name = "favoritesButton";
            this.favoritesButton.Size = new System.Drawing.Size(23, 29);
            this.favoritesButton.Text = "toolStripButton1";
            // 
            // basicLatinButton
            // 
            this.basicLatinButton.Checked = true;
            this.basicLatinButton.CheckOnClick = true;
            this.basicLatinButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.basicLatinButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.basicLatinButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.basicLatinButton.Image = ((System.Drawing.Image)(resources.GetObject("basicLatinButton.Image")));
            this.basicLatinButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.basicLatinButton.MergeIndex = 1;
            this.basicLatinButton.Name = "basicLatinButton";
            this.basicLatinButton.Size = new System.Drawing.Size(29, 29);
            this.basicLatinButton.Text = "A";
            // 
            // latinSupplementButton
            // 
            this.latinSupplementButton.CheckOnClick = true;
            this.latinSupplementButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.latinSupplementButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.latinSupplementButton.Image = ((System.Drawing.Image)(resources.GetObject("latinSupplementButton.Image")));
            this.latinSupplementButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.latinSupplementButton.MergeIndex = 1;
            this.latinSupplementButton.Name = "latinSupplementButton";
            this.latinSupplementButton.Size = new System.Drawing.Size(29, 29);
            this.latinSupplementButton.Text = "À";
            // 
            // latinExtendedButton
            // 
            this.latinExtendedButton.CheckOnClick = true;
            this.latinExtendedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.latinExtendedButton.Image = ((System.Drawing.Image)(resources.GetObject("latinExtendedButton.Image")));
            this.latinExtendedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.latinExtendedButton.MergeIndex = 1;
            this.latinExtendedButton.Name = "latinExtendedButton";
            this.latinExtendedButton.Size = new System.Drawing.Size(29, 29);
            this.latinExtendedButton.Text = "Ā";
            // 
            // greekButton
            // 
            this.greekButton.CheckOnClick = true;
            this.greekButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.greekButton.Image = ((System.Drawing.Image)(resources.GetObject("greekButton.Image")));
            this.greekButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.greekButton.MergeIndex = 1;
            this.greekButton.Name = "greekButton";
            this.greekButton.Size = new System.Drawing.Size(27, 29);
            this.greekButton.Text = "Σ";
            // 
            // superscriptButton
            // 
            this.superscriptButton.CheckOnClick = true;
            this.superscriptButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.superscriptButton.Image = ((System.Drawing.Image)(resources.GetObject("superscriptButton.Image")));
            this.superscriptButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.superscriptButton.MergeIndex = 1;
            this.superscriptButton.Name = "superscriptButton";
            this.superscriptButton.Size = new System.Drawing.Size(23, 29);
            this.superscriptButton.Text = "¹";
            // 
            // mathButton
            // 
            this.mathButton.CheckOnClick = true;
            this.mathButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mathButton.Image = ((System.Drawing.Image)(resources.GetObject("mathButton.Image")));
            this.mathButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mathButton.MergeIndex = 1;
            this.mathButton.Name = "mathButton";
            this.mathButton.Size = new System.Drawing.Size(29, 29);
            this.mathButton.Text = "±";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.basicLatinPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(0, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(674, 419);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // basicLatinPage
            // 
            this.basicLatinPage.Location = new System.Drawing.Point(4, 5);
            this.basicLatinPage.Name = "basicLatinPage";
            this.basicLatinPage.Padding = new System.Windows.Forms.Padding(3);
            this.basicLatinPage.Size = new System.Drawing.Size(666, 410);
            this.basicLatinPage.TabIndex = 0;
            this.basicLatinPage.Text = "tabPage1";
            this.basicLatinPage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(666, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // addToFavouritesMenuStrip
            // 
            this.addToFavouritesMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьВИзбранноеToolStripMenuItem});
            this.addToFavouritesMenuStrip.Name = "addToFavouritesMenuStrip";
            this.addToFavouritesMenuStrip.Size = new System.Drawing.Size(198, 26);
            // 
            // добавитьВИзбранноеToolStripMenuItem
            // 
            this.добавитьВИзбранноеToolStripMenuItem.Name = "добавитьВИзбранноеToolStripMenuItem";
            this.добавитьВИзбранноеToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.добавитьВИзбранноеToolStripMenuItem.Text = "Добавить в избранное";
            this.добавитьВИзбранноеToolStripMenuItem.Click += new System.EventHandler(this.addToFavourites);
            // 
            // removeFromFavouritesMenuStrip
            // 
            this.removeFromFavouritesMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem});
            this.removeFromFavouritesMenuStrip.Name = "removeFromFavouritesMenuStrip";
            this.removeFromFavouritesMenuStrip.Size = new System.Drawing.Size(153, 48);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.deleteFavouritesClick);
            // 
            // CharacterMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 451);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CharacterMap";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CharacterMap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CharacterMap_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.addToFavouritesMenuStrip.ResumeLayout(false);
            this.removeFromFavouritesMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton basicLatinButton;
        private System.Windows.Forms.ToolStripButton latinSupplementButton;
        private System.Windows.Forms.ToolStripButton latinExtendedButton;
        private System.Windows.Forms.ToolStripButton greekButton;
        private System.Windows.Forms.ToolStripButton superscriptButton;
        private System.Windows.Forms.ToolStripButton mathButton;
        private System.Windows.Forms.ToolStripButton favoritesButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage basicLatinPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip addToFavouritesMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem добавитьВИзбранноеToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip removeFromFavouritesMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
    }
}