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
using DevExpress.XtraEditors;

namespace CodeBank
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DialogResult[] dialog = {
            DialogResult.OK
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XtraCategoriesForm categoriesForm = new XtraCategoriesForm();
            categoriesForm.MdiParent = this;
            categoriesForm.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraCategoryCreateForm categoryCreate = new XtraCategoryCreateForm();
            categoryCreate.MdiParent = this;
            if (Application.OpenForms[categoryCreate.Name] == null)
            {
                categoryCreate.Show();
            }
            else
            {
                categoryCreate.Focus();
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraCategoriesForm categoriesForm = new XtraCategoriesForm();
            categoriesForm.MdiParent = this;

            if (Application.OpenForms[categoriesForm.Name] == null)
            {
                categoriesForm.Show();
            }
            else
            {
                categoriesForm.Focus();
            }
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraSourceCodeCreateForm sourceCodeCreateForm = new XtraSourceCodeCreateForm();
            sourceCodeCreateForm.MdiParent = this;

            if (Application.OpenForms[sourceCodeCreateForm.Name] == null)
            {
                sourceCodeCreateForm.Show();
            }
            else
            {
                sourceCodeCreateForm.Focus();
            }

        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraSourceCodesForm sourceCodesForm = new XtraSourceCodesForm();
            sourceCodesForm.MdiParent = this;

            if (Application.OpenForms[sourceCodesForm.Name] == null)
            {
                sourceCodesForm.Show();
            }
            else
            {
                sourceCodesForm.Focus();
            }
        }
    }
}
