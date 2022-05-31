using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CodeBank
{
    public partial class XtraLoginForm : DevExpress.XtraEditors.XtraForm
    {
        public XtraLoginForm()
        {
            InitializeComponent();
        }

        private void xtraUserControl1_Load(object sender, EventArgs e)
        {
            Thread.Sleep(5000);
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "Admin" && txtParola.Text == "1234")
            {
                this.Hide();
                Form1 form = new Form1();
                form.ShowDialog();
            }
        }
    }
}