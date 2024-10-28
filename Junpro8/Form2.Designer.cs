namespace Junpro8
{
    partial class Form2
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
            this.pbQR = new System.Windows.Forms.PictureBox();
            this.lbQR = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).BeginInit();
            this.SuspendLayout();
            // 
            // pbQR
            // 
            this.pbQR.Location = new System.Drawing.Point(30, 25);
            this.pbQR.Name = "pbQR";
            this.pbQR.Size = new System.Drawing.Size(626, 186);
            this.pbQR.TabIndex = 0;
            this.pbQR.TabStop = false;
            // 
            // lbQR
            // 
            this.lbQR.AutoSize = true;
            this.lbQR.Location = new System.Drawing.Point(27, 235);
            this.lbQR.Name = "lbQR";
            this.lbQR.Size = new System.Drawing.Size(35, 13);
            this.lbQR.TabIndex = 1;
            this.lbQR.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbQR);
            this.Controls.Add(this.pbQR);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbQR;
        private System.Windows.Forms.Label lbQR;
    }
}