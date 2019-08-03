namespace AlphabetProgram
{
    partial class FrmCount
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
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblProm = new System.Windows.Forms.Label();
            this.lblUpper = new System.Windows.Forms.Label();
            this.lblLower = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCount
            // 
            this.txtCount.BackColor = System.Drawing.SystemColors.Window;
            this.txtCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCount.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtCount.Location = new System.Drawing.Point(203, 23);
            this.txtCount.MaxLength = 255;
            this.txtCount.Multiline = true;
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCount.Size = new System.Drawing.Size(123, 125);
            this.txtCount.TabIndex = 0;
            this.txtCount.UseSystemPasswordChar = true;
            // 
            // lblProm
            // 
            this.lblProm.AutoSize = true;
            this.lblProm.Location = new System.Drawing.Point(19, 23);
            this.lblProm.Name = "lblProm";
            this.lblProm.Size = new System.Drawing.Size(54, 13);
            this.lblProm.TabIndex = 1;
            this.lblProm.Text = "Promedio:";
            // 
            // lblUpper
            // 
            this.lblUpper.AutoSize = true;
            this.lblUpper.Location = new System.Drawing.Point(19, 75);
            this.lblUpper.Name = "lblUpper";
            this.lblUpper.Size = new System.Drawing.Size(66, 13);
            this.lblUpper.TabIndex = 2;
            this.lblUpper.Text = "Mayusculas:";
            // 
            // lblLower
            // 
            this.lblLower.AutoSize = true;
            this.lblLower.Location = new System.Drawing.Point(19, 135);
            this.lblLower.Name = "lblLower";
            this.lblLower.Size = new System.Drawing.Size(63, 13);
            this.lblLower.TabIndex = 3;
            this.lblLower.Text = "Minusculas:";
            // 
            // FrmCount
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 173);
            this.Controls.Add(this.lblLower);
            this.Controls.Add(this.lblUpper);
            this.Controls.Add(this.lblProm);
            this.Controls.Add(this.txtCount);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "FrmCount";
            this.Text = "Conteo de Caracteres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label lblProm;
        private System.Windows.Forms.Label lblUpper;
        private System.Windows.Forms.Label lblLower;

        public void setLblProm(string txt)
        {
            lblProm.Text = txt;
        }

        public void setLblUpper(string txt)
        {
            lblUpper.Text = txt;
        }
        public void setLblLower(string txt)
        {
            lblLower.Text = txt;
        }
        
    }
}
