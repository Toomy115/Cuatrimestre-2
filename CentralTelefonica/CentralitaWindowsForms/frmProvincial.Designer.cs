namespace CentralitaWindowsForms
{
    partial class frmProvincial
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
            this.cmbFranja = new System.Windows.Forms.ComboBox();
            this.lblFranja = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbFranja
            // 
            this.cmbFranja.FormattingEnabled = true;
            this.cmbFranja.Location = new System.Drawing.Point(15, 180);
            this.cmbFranja.Name = "cmbFranja";
            this.cmbFranja.Size = new System.Drawing.Size(191, 21);
            this.cmbFranja.TabIndex = 8;
            // 
            // lblFranja
            // 
            this.lblFranja.AutoSize = true;
            this.lblFranja.Location = new System.Drawing.Point(12, 164);
            this.lblFranja.Name = "lblFranja";
            this.lblFranja.Size = new System.Drawing.Size(39, 13);
            this.lblFranja.TabIndex = 9;
            this.lblFranja.Text = "Franja:";
            // 
            // frmProvincial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 262);
            this.Controls.Add(this.lblFranja);
            this.Controls.Add(this.cmbFranja);
            this.Name = "frmProvincial";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.cmbFranja, 0);
            this.Controls.SetChildIndex(this.lblFranja, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFranja;
        private System.Windows.Forms.Label lblFranja;
    }
}