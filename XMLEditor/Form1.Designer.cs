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
            this.accordion1 = new Opulos.Core.UI.Accordion();
            this.SuspendLayout();
            // 
            // accordion1
            // 
            this.accordion1.AllowMouseResize = true;
            this.accordion1.AutoScroll = true;
            this.accordion1.AutoSize = true;
            this.accordion1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.accordion1.CheckBoxFactory = null;
            this.accordion1.CheckBoxMargin = null;
            this.accordion1.ContentBackColor = null;
            this.accordion1.ContentMargin = null;
            this.accordion1.ContentPadding = new System.Windows.Forms.Padding(5);
            this.accordion1.ControlBackColor = null;
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
            this.accordion1.Location = new System.Drawing.Point(12, 12);
            this.accordion1.Name = "accordion1";
            this.accordion1.OpenOnAdd = false;
            this.accordion1.OpenOneOnly = false;
            this.accordion1.ShowToolMenu = true;
            this.accordion1.ShowToolMenuOnHoverWhenClosed = false;
            this.accordion1.ShowToolMenuOnRightClick = true;
            this.accordion1.ShowToolMenuRequiresPositiveFillWeight = false;
            this.accordion1.Size = new System.Drawing.Size(703, 522);
            this.accordion1.TabIndex = 0;
            this.accordion1.UpArrow = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 546);
            this.Controls.Add(this.accordion1);
            this.Name = "MainForm";
            this.Text = "XMLEditor for MedLine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Opulos.Core.UI.Accordion accordion1;
    }
}

