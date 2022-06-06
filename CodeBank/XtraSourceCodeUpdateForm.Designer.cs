
namespace CodeBank
{
    partial class XtraSourceCodeUpdateForm
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
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.txtTitle = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.ToggleIsArchived = new DevExpress.XtraEditors.ToggleSwitch();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel3 = new DevExpress.XtraEditors.SidePanel();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.sidePanel4 = new DevExpress.XtraEditors.SidePanel();
            this.txtContent = new DevExpress.XtraRichEdit.RichEditControl();
            this.sidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleIsArchived.Properties)).BeginInit();
            this.sidePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            this.sidePanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel2
            // 
            this.sidePanel2.Controls.Add(this.txtTitle);
            this.sidePanel2.Controls.Add(this.labelControl1);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel2.Location = new System.Drawing.Point(0, 0);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(1149, 68);
            this.sidePanel2.TabIndex = 2;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Location = new System.Drawing.Point(72, 22);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtTitle.Properties.Appearance.Options.UseFont = true;
            this.txtTitle.Size = new System.Drawing.Size(1065, 28);
            this.txtTitle.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Başlık";
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.ToggleIsArchived);
            this.sidePanel1.Controls.Add(this.simpleButton1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel1.Location = new System.Drawing.Point(0, 752);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1149, 102);
            this.sidePanel1.TabIndex = 3;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // ToggleIsArchived
            // 
            this.ToggleIsArchived.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ToggleIsArchived.EditValue = true;
            this.ToggleIsArchived.Location = new System.Drawing.Point(869, 25);
            this.ToggleIsArchived.Name = "ToggleIsArchived";
            this.ToggleIsArchived.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ToggleIsArchived.Properties.Appearance.Options.UseFont = true;
            this.ToggleIsArchived.Properties.AutoHeight = false;
            this.ToggleIsArchived.Properties.OffText = "Pasif";
            this.ToggleIsArchived.Properties.OnText = "Aktif";
            this.ToggleIsArchived.Size = new System.Drawing.Size(120, 47);
            this.ToggleIsArchived.TabIndex = 3;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Location = new System.Drawing.Point(995, 31);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(122, 41);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Güncelle";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // sidePanel3
            // 
            this.sidePanel3.Controls.Add(this.listBoxControl1);
            this.sidePanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel3.Location = new System.Drawing.Point(0, 68);
            this.sidePanel3.Name = "sidePanel3";
            this.sidePanel3.Size = new System.Drawing.Size(424, 684);
            this.sidePanel3.TabIndex = 4;
            this.sidePanel3.Text = "sidePanel3";
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.DataSource = typeof(DAL.Entities.Category);
            this.listBoxControl1.DisplayMember = "CategoryName";
            this.listBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxControl1.Location = new System.Drawing.Point(0, 0);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(423, 684);
            this.listBoxControl1.TabIndex = 0;
            this.listBoxControl1.ValueMember = "Id";
            // 
            // sidePanel4
            // 
            this.sidePanel4.Controls.Add(this.txtContent);
            this.sidePanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel4.Location = new System.Drawing.Point(424, 68);
            this.sidePanel4.Name = "sidePanel4";
            this.sidePanel4.Size = new System.Drawing.Size(725, 684);
            this.sidePanel4.TabIndex = 5;
            this.sidePanel4.Text = "sidePanel4";
            // 
            // txtContent
            // 
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.Location = new System.Drawing.Point(0, 0);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(725, 684);
            this.txtContent.TabIndex = 0;
            // 
            // XtraSourceCodeUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 854);
            this.Controls.Add(this.sidePanel4);
            this.Controls.Add(this.sidePanel3);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.sidePanel2);
            this.Name = "XtraSourceCodeUpdateForm";
            this.Text = "XtraSourceCodeUpdateForm";
            this.sidePanel2.ResumeLayout(false);
            this.sidePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ToggleIsArchived.Properties)).EndInit();
            this.sidePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            this.sidePanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.TextEdit txtTitle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.ToggleSwitch ToggleIsArchived;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SidePanel sidePanel3;
        public DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.SidePanel sidePanel4;
        private DevExpress.XtraRichEdit.RichEditControl txtContent;
    }
}