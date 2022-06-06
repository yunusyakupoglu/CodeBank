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
using System.Data.Entity;
using DAL;
using DAL.Entities;
using BLL.Service;

namespace CodeBank
{
    public partial class XtraCategoriesForm : DevExpress.XtraEditors.XtraForm
    {
        private AppDbContext context = new AppDbContext();
        private CategoryService categoryService = new CategoryService();
        public XtraCategoriesForm()
        {
            InitializeComponent();
            gridControl1.DataSource = categoryService.GetAll(context);
        }

        private void XtraCategoriesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'codeBankDbDataSet.Kategoriler' table. You can move, or remove it, as needed.

        }
        public void KategoriListele()
        {
            gridControl1.DataSource = categoryService.GetAll(context);
        }
        private void repositoryItemButtonEdit5_Click(object sender, EventArgs e)
        {
            int seciliId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            if (MessageBox.Show("Seçili kayıt silinecek. Onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                categoryService.Delete(context, s => s.Id == seciliId);
                categoryService.Save(context);
                KategoriListele();
            }
        }

        private void repositoryItemButtonEdit4_Click(object sender, EventArgs e)
        {
            int seciliId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            XtraCategoryUpdateForm frm = new XtraCategoryUpdateForm(categoryService.GetByFilter(context, s => s.Id == seciliId)); 
            frm.Text = seciliId.ToString() + " numaralı kategoriyi düzenle";
            frm.MdiParent = this.ParentForm;
            frm.Show();
        }
    }
}