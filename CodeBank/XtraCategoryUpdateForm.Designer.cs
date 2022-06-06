
namespace CodeBank
{
    partial class XtraCategoryUpdateForm
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
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.ToggleIsArchived = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCategoryName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleIsArchived.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoryName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(174, 192);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(177, 46);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ToggleIsArchived
            // 
            this.ToggleIsArchived.EditValue = true;
            this.ToggleIsArchived.Location = new System.Drawing.Point(174, 123);
            this.ToggleIsArchived.Name = "ToggleIsArchived";
            this.ToggleIsArchived.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ToggleIsArchived.Properties.Appearance.Options.UseFont = true;
            this.ToggleIsArchived.Properties.AutoHeight = false;
            this.ToggleIsArchived.Properties.OffText = "Pasif";
            this.ToggleIsArchived.Properties.OnText = "Aktif";
            this.ToggleIsArchived.Size = new System.Drawing.Size(120, 47);
            this.ToggleIsArchived.TabIndex = 9;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(82, 85);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 16);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Kategori Adı";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.EditValue = "";
            this.txtCategoryName.Location = new System.Drawing.Point(174, 82);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(177, 22);
            this.txtCategoryName.TabIndex = 7;
            // 
            // XtraCategoryUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 666);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.ToggleIsArchived);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtCategoryName);
            this.Name = "XtraCategoryUpdateForm";
            this.Text = "XtraCategoryUpdateForm";
            ((System.ComponentModel.ISupportInitialize)(this.ToggleIsArchived.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoryName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.ToggleSwitch ToggleIsArchived;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.TextEdit txtCategoryName;
    }
}