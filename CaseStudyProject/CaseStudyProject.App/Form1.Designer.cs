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
            lstCodeList = new ListBox();
            btnCode = new Button();
            SuspendLayout();
            // 
            // lstCodeList
            // 
            lstCodeList.FormattingEnabled = true;
            lstCodeList.ItemHeight = 15;
            lstCodeList.Location = new Point(12, 67);
            lstCodeList.Name = "lstCodeList";
            lstCodeList.Size = new Size(204, 364);
            lstCodeList.TabIndex = 1;
            // 
            // btnCode
            // 
            btnCode.Location = new Point(12, 21);
            btnCode.Name = "btnCode";
            btnCode.Size = new Size(204, 23);
            btnCode.TabIndex = 2;
            btnCode.Text = "Kod Üret";
            btnCode.UseVisualStyleBackColor = true;
            btnCode.Click += btnCode_Click;
            // 
            // FrmGenerateCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCode);
            Controls.Add(lstCodeList);
            Name = "FrmGenerateCode";
            Text = "GenerateCode";
            Load += FrmGenerateCode_Load;
            ResumeLayout(false);
        }

        #endregion
        private ListBox lstCodeList;
        private Button btnCode;
    }
}