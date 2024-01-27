namespace CaseStudyProject.App
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
            this.btnRandomCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRandomCode
            // 
            this.btnRandomCode.Location = new System.Drawing.Point(129, 80);
            this.btnRandomCode.Name = "btnRandomCode";
            this.btnRandomCode.Size = new System.Drawing.Size(75, 23);
            this.btnRandomCode.TabIndex = 0;
            this.btnRandomCode.Text = "Code Üret";
            this.btnRandomCode.UseVisualStyleBackColor = true;
            this.btnRandomCode.Click += new System.EventHandler(this.btnRandomCode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRandomCode);
            this.Name = "Form1";
            this.Text = "txtGenerateCode";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRandomCode;
    }
}