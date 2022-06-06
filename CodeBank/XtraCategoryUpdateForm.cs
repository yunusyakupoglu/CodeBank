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
    public partial class XtraCategoryUpdateForm : DevExpress.XtraEditors.XtraForm
    {
        private Category category = new Category();
        private AppDbContext context = new AppDbContext();
        private CategoryService categoryService = new CategoryService();
        public XtraCategoryUpdateForm(Category category)
        {
            InitializeComponent();
            this.category = category;
            ComponentDoldur();
        }
        public XtraCategoryUpdateForm()
        {
            InitializeComponent();
        }

        public void ComponentDoldur()
        {
            txtCategoryName.Text = category.CategoryName;
            ToggleIsArchived.IsOn = category.isArchived;
        }

        public void veriGuncelle()
        {
            category.CategoryName = txtCategoryName.Text;
            category.isArchived = ToggleIsArchived.IsOn;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            veriGuncelle();
            if (categoryService.AddOrUpdate(context, category))
            {
                categoryService.Save(context);
                MessageBox.Show("Kategori güncellendi.");
            }
        }
    }
}