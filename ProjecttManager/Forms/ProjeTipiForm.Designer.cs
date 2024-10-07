namespace ProjecttManager.Forms
{
    partial class ProjeTipiForm
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
            this.cmbProjeTipleri = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbProjeTipleri
            // 
            this.cmbProjeTipleri.FormattingEnabled = true;
            this.cmbProjeTipleri.Location = new System.Drawing.Point(367, 113);
            this.cmbProjeTipleri.Name = "cmbProjeTipleri";
            this.cmbProjeTipleri.Size = new System.Drawing.Size(121, 28);
            this.cmbProjeTipleri.TabIndex = 0;
            // 
            // ProjeTipiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbProjeTipleri);
            this.Name = "ProjeTipiForm";
            this.Text = "ProjeTipiForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProjeTipleri;
    }
}