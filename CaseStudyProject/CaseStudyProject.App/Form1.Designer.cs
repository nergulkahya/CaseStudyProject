namespace CaseStudyProject.App
{
    partial class FrmGenerateCode
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
            this.lstCodeList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstCodeList
            // 
            this.lstCodeList.FormattingEnabled = true;
            this.lstCodeList.ItemHeight = 15;
            this.lstCodeList.Location = new System.Drawing.Point(12, 67);
            this.lstCodeList.Name = "lstCodeList";
            this.lstCodeList.Size = new System.Drawing.Size(204, 364);
            this.lstCodeList.TabIndex = 1;
            // 
            // FrmGenerateCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstCodeList);
            this.Name = "FrmGenerateCode";
            this.Text = "GenerateCode";
            this.Load += new System.EventHandler(this.FrmGenerateCode_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private ListBox lstCodeList;
    }
}