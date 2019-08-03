namespace AlphabetProgram
{
    partial class FrmSentence
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSentence = new System.Windows.Forms.Label();
            this.txtSentence = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSentence
            // 
            this.lblSentence.AutoSize = true;
            this.lblSentence.Location = new System.Drawing.Point(185, 18);
            this.lblSentence.MaximumSize = new System.Drawing.Size(200, 300);
            this.lblSentence.Name = "lblSentence";
            this.lblSentence.Size = new System.Drawing.Size(104, 13);
            this.lblSentence.TabIndex = 0;
            this.lblSentence.Text = "Ingrese una oracion:";
            // 
            // txtSentence
            // 
            this.txtSentence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSentence.Location = new System.Drawing.Point(54, 46);
            this.txtSentence.MaxLength = 255;
            this.txtSentence.Multiline = true;
            this.txtSentence.Name = "txtSentence";
            this.txtSentence.Size = new System.Drawing.Size(377, 86);
            this.txtSentence.TabIndex = 1;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(188, 147);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(101, 33);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "Contar Caracteres";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // FrmSentence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(513, 213);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.txtSentence);
            this.Controls.Add(this.lblSentence);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmSentence";
            this.Text = "Programa de Conteo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSentence;
        private System.Windows.Forms.TextBox txtSentence;
        private System.Windows.Forms.Button btnCount;
    }
}

