namespace LicensedControlTest
{
    partial class Form1
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
            this.licensableControl1 = new LicensedControlDemo.LicensableControl();
            this.SuspendLayout();
            // 
            // licensableControl1
            // 
            this.licensableControl1.LicenseKey = "c8ec56f0-ad96-4759-bd28-10d956ed2ed4-fefe409e";
            this.licensableControl1.Location = new System.Drawing.Point(69, 12);
            this.licensableControl1.Name = "licensableControl1";
            this.licensableControl1.Size = new System.Drawing.Size(292, 119);
            this.licensableControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 184);
            this.Controls.Add(this.licensableControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private LicensedControlDemo.LicensableControl licensableControl1;


    }
}

