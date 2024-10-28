namespace Modul9._2
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
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.rbSetor = new System.Windows.Forms.RadioButton();
            this.rbTarik = new System.Windows.Forms.RadioButton();
            this.tbMoney = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnLanjut = new System.Windows.Forms.Button();
            this.lblSaldoAngka = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(116, 39);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(95, 13);
            this.lblSaldo.TabIndex = 0;
            this.lblSaldo.Text = "Saldo Akun Umum";
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(61, 102);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(43, 13);
            this.lblAction.TabIndex = 1;
            this.lblAction.Text = "Action :";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(29, 130);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(75, 13);
            this.lblMoney.TabIndex = 2;
            this.lblMoney.Text = "Jumlah Uang :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(45, 163);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password :";
            // 
            // rbSetor
            // 
            this.rbSetor.AutoSize = true;
            this.rbSetor.Location = new System.Drawing.Point(119, 102);
            this.rbSetor.Name = "rbSetor";
            this.rbSetor.Size = new System.Drawing.Size(50, 17);
            this.rbSetor.TabIndex = 4;
            this.rbSetor.TabStop = true;
            this.rbSetor.Text = "Setor";
            this.rbSetor.UseVisualStyleBackColor = true;
            // 
            // rbTarik
            // 
            this.rbTarik.AutoSize = true;
            this.rbTarik.Location = new System.Drawing.Point(190, 102);
            this.rbTarik.Name = "rbTarik";
            this.rbTarik.Size = new System.Drawing.Size(49, 17);
            this.rbTarik.TabIndex = 5;
            this.rbTarik.TabStop = true;
            this.rbTarik.Text = "Tarik";
            this.rbTarik.UseVisualStyleBackColor = true;
            // 
            // tbMoney
            // 
            this.tbMoney.Location = new System.Drawing.Point(119, 130);
            this.tbMoney.Name = "tbMoney";
            this.tbMoney.Size = new System.Drawing.Size(100, 20);
            this.tbMoney.TabIndex = 6;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(119, 160);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 7;
            // 
            // btnLanjut
            // 
            this.btnLanjut.Location = new System.Drawing.Point(235, 158);
            this.btnLanjut.Name = "btnLanjut";
            this.btnLanjut.Size = new System.Drawing.Size(75, 23);
            this.btnLanjut.TabIndex = 8;
            this.btnLanjut.Text = "Lanjut";
            this.btnLanjut.UseVisualStyleBackColor = true;
            this.btnLanjut.Click += new System.EventHandler(this.btnLanjut_Click);
            // 
            // lblSaldoAngka
            // 
            this.lblSaldoAngka.AutoSize = true;
            this.lblSaldoAngka.Location = new System.Drawing.Point(142, 72);
            this.lblSaldoAngka.Name = "lblSaldoAngka";
            this.lblSaldoAngka.Size = new System.Drawing.Size(43, 13);
            this.lblSaldoAngka.TabIndex = 9;
            this.lblSaldoAngka.Text = "143132";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSaldoAngka);
            this.Controls.Add(this.btnLanjut);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbMoney);
            this.Controls.Add(this.rbTarik);
            this.Controls.Add(this.rbSetor);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.lblSaldo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.RadioButton rbSetor;
        private System.Windows.Forms.RadioButton rbTarik;
        private System.Windows.Forms.TextBox tbMoney;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnLanjut;
        private System.Windows.Forms.Label lblSaldoAngka;
    }
}

