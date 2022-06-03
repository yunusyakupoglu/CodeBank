
namespace CodeBank
{
    partial class XtraUserImageUpdateForm
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
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // svgImageBox1
            // 
            this.svgImageBox1.Location = new System.Drawing.Point(72, 57);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(313, 313);
            this.svgImageBox1.TabIndex = 0;
            this.svgImageBox1.Text = "svgImageBox1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(72, 416);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(313, 81);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Dosya Seç";
            // 
            // XtraUserImageUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 632);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.svgImageBox1);
            this.Name = "XtraUserImageUpdateForm";
            this.Text = "XtraUserImageUpdateForm";
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}