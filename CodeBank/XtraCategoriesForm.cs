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
    }
}