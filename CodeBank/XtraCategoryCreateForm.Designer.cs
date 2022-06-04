
namespace CodeBank
{
    partial class XtraCategoryCreateForm
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
            this.components = new System.ComponentModel.Container();
            this.txtCategoryName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ToggleIsArchived = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoryName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleIsArchived.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.EditValue = "";
            this.txtCategoryName.Location = new System.Drawing.Point(172, 80);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(177, 22);
            this.txtCategoryName.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(80, 83);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "labelControl1";
            // 
            // ToggleIsArchived
            // 
            this.ToggleIsArchived.EditValue = true;
            this.ToggleIsArchived.Location = new System.Drawing.Point(172, 121);
            this.ToggleIsArchived.Name = "ToggleIsArchived";
            this.ToggleIsArchived.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ToggleIsArchived.Properties.Appearance.Options.UseFont = true;
            this.ToggleIsArchived.Properties.AutoHeight = false;
            this.ToggleIsArchived.Properties.OffText = "Pasif";
            this.ToggleIsArchived.Properties.OnText = "Aktif";
            this.ToggleIsArchived.Size = new System.Drawing.Size(120, 47);
            this.ToggleIsArchived.TabIndex = 2;
            this.ToggleIsArchived.Toggled += new System.EventHandler(this.ToggleIsArchived_Toggled);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(80, 135);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "labelControl2";
            // 
            // xtraOpenFileDialog1
            // 
            this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(172, 190);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 46);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // XtraCategoryCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 788);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.ToggleIsArchived);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtCategoryName);
            this.Name = "XtraCategoryCreateForm";
            this.Text = "XtraCategoryCreateForm";
            this.Load += new System.EventHandler(this.XtraCategoryCreateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoryName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleIsArchived.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ToggleSwitch ToggleIsArchived;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
        public DevExpress.XtraEditors.TextEdit txtCategoryName;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}