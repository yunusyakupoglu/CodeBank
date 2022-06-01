
namespace CodeBank
{
    partial class XtraSourceCodeCreateForm
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
            this.ımageComboBoxEdit1 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.ımageComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageComboBoxEdit1
            // 
            this.ımageComboBoxEdit1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ımageComboBoxEdit1.Location = new System.Drawing.Point(0, 0);
            this.ımageComboBoxEdit1.Name = "ımageComboBoxEdit1";
            this.ımageComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ımageComboBoxEdit1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("C#", null, -1)});
            this.ımageComboBoxEdit1.Properties.Sorted = true;
            this.ımageComboBoxEdit1.Size = new System.Drawing.Size(203, 22);
            this.ımageComboBoxEdit1.TabIndex = 0;
            // 
            // richEditControl1
            // 
            this.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl1.Location = new System.Drawing.Point(203, 0);
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Size = new System.Drawing.Size(631, 616);
            this.richEditControl1.TabIndex = 1;
            this.richEditControl1.Text = "richEditControl1";
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(12, 43);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toggleSwitch1.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitch1.Properties.AutoHeight = false;
            this.toggleSwitch1.Properties.OffText = "Pasif";
            this.toggleSwitch1.Properties.OnText = "Aktif";
            this.toggleSwitch1.Size = new System.Drawing.Size(120, 47);
            this.toggleSwitch1.TabIndex = 4;
            // 
            // XtraSourceCodeCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 616);
            this.Controls.Add(this.toggleSwitch1);
            this.Controls.Add(this.richEditControl1);
            this.Controls.Add(this.ımageComboBoxEdit1);
            this.Name = "XtraSourceCodeCreateForm";
            this.Text = "XtraSourceCodeCreateForm";
            ((System.ComponentModel.ISupportInitialize)(this.ımageComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ImageComboBoxEdit ımageComboBoxEdit1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
    }
}