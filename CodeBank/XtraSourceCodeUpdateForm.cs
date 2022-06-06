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
    public partial class XtraSourceCodeUpdateForm : DevExpress.XtraEditors.XtraForm
    {
        private AppDbContext context = new AppDbContext();
        private SourceCodeService sourceCodeService = new SourceCodeService();
        private SourceCode sourceCode;
        public XtraSourceCodeUpdateForm(SourceCode sourceCode)
        {
            InitializeComponent();
            this.sourceCode = sourceCode;
            ComponentDoldur();
        }
        public XtraSourceCodeUpdateForm()
        {
            InitializeComponent();
        }

        public void ComponentDoldur()
        {            
            txtTitle.Text = sourceCode.Title;
            txtContent.Text = sourceCode.Content;
            ToggleIsArchived.IsOn = sourceCode.isArchived;
        }

        public void veriGuncelle()
        {
            sourceCode.Title = txtTitle.Text;
            sourceCode.Content = txtContent.Text;
            sourceCode.isArchived = ToggleIsArchived.IsOn;
            sourceCode.CategoryId = (int)listBoxControl1.SelectedValue;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            veriGuncelle();
            if (sourceCodeService.AddOrUpdate(context, sourceCode))
            {
                sourceCodeService.Save(context);
                MessageBox.Show("Kaynak kod güncellendi.");
            }
        }
    }
}