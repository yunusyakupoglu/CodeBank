using BLL.Service;
using DAL;
using DAL.Entities;
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

namespace CodeBank
{
    public partial class XtraCategoryCreateForm : DevExpress.XtraEditors.XtraForm
    {
        AppDbContext context = new AppDbContext();
        Category category;

        CategoryService categoryService = new CategoryService();



        public XtraCategoryCreateForm()
        {
            InitializeComponent();
        }


        private void XtraCategoryCreateForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            category = new Category();
            category.CategoryName = txtCategoryName.Text;
            if (ToggleIsArchived.IsOn == true)
            {
                category.isArchived = true;
            }
            else
            {
                category.isArchived = false;
            }
            if (categoryService.AddOrUpdate(context, category))
            {
                categoryService.Save(context);
                MessageBox.Show("Kategori kaydı başarılı.");
            }
        }

        private void ToggleIsArchived_Toggled(object sender, EventArgs e)
        {
            if (ToggleIsArchived.EditValue.ToString() == "True" && XtraMessageBox.Show("Arşivlemek istediğinize emin misiniz?", "Warning:", MessageBoxButtons.YesNo) == DialogResult.Yes ? ToggleIsArchived.IsOn = true : ToggleIsArchived.IsOn = false)
            {

            }
            else 
            {
            
            }
        }
    }
}