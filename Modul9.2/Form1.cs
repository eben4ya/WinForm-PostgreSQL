using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul9._2
{
    public partial class Form1 : Form
    {
        Akun akun1 = new AkunPremium(20000, "benayaihiy");
        //Akun akun1 = new Akun(20000, "hiyahiyahiya");
        public Form1()
        {
            InitializeComponent();
            lblSaldoAngka.Text = akun1.Saldo.ToString();
        }

        private void TarikSaldo(int total)
        {
            akun1.Tarik(total);
            lblSaldoAngka.Text += akun1.Saldo.ToString();
        }

        private void SetorSaldo(int total)
        {
            akun1.Setor(total);
            lblSaldoAngka.Text = akun1.Saldo.ToString();
        }

        private void btnLanjut_Click(object sender, EventArgs e)
        {
           if(akun1.PasswordTervalidasi(tbPassword.Text))
            {
                if (rbSetor.Checked)
                {
                    SetorSaldo(int.Parse(tbMoney.Text));
                }
                else if (rbTarik.Checked)
                {
                    TarikSaldo(int.Parse(tbMoney.Text));
                }
            }
           else
            {
                MessageBox.Show("Password salah");
            }
        }

       
    }
}
