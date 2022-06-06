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
using DAL.Entities;
using DAL;
using BLL.Service;
using System.Diagnostics;

namespace CodeBank
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        AppDbContext context = new AppDbContext();
        Category category;
        SourceCode sourceCode;

        CategoryService categoryService = new CategoryService();
        SourceCodeService sourceCodeService = new SourceCodeService();
        DialogResult[] dialog = {
            DialogResult.OK
        };
        public Form1()
        {
            InitializeComponent();
            Thread.Sleep(1000);
            category = new Category();
            sourceCode = new SourceCode();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        void FormKontrol(Form AcilanForm)
        {
            bool Acikmi = false;
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (AcilanForm.Name == MdiChildren[i].Name)
                {
                    this.MdiChildren[i].Focus();
                    Acikmi = true;
                }
            }
            if (Acikmi == false)
            {
                AcilanForm.MdiParent = this;
                AcilanForm.Show();
            }
            else
            {
                AcilanForm.Dispose();
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraCategoryCreateForm categoryCreate = new XtraCategoryCreateForm();
            FormKontrol(categoryCreate);
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraCategoriesForm categoriesForm = new XtraCategoriesForm();
            FormKontrol(categoriesForm);

        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraSourceCodeCreateForm sourceCodeCreateForm = new XtraSourceCodeCreateForm();
            FormKontrol(sourceCodeCreateForm);

        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraSourceCodesForm sourceCodesForm = new XtraSourceCodesForm();
            FormKontrol(sourceCodesForm);
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraUserInformationsForm userInformationsForm = new XtraUserInformationsForm();
            FormKontrol(userInformationsForm);
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraUserUpdateForm userUpdateForm = new XtraUserUpdateForm();
            FormKontrol(userUpdateForm);
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraUserImageUpdateForm userImageUpdateForm = new XtraUserImageUpdateForm();
            FormKontrol(userImageUpdateForm);
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraPasswordUpdateForm passwordUpdateForm = new XtraPasswordUpdateForm();
            FormKontrol(passwordUpdateForm);
        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start("C:\\Program Files\\Microsoft Office\\root\\Office16\\outlook.exe");
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
        }
    }
}
