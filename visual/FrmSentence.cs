using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlphabetProgram
{
    public partial class FrmSentence : Form
    {
        public FrmSentence()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            FrmCount a;
            DetectAbc det;
            int totUpper = 0;
            int totLower = 0;
            string txt;
            double prom;
            txt = txtSentence.Text.Trim();
            if(txt.Length == 0)
            {
                MessageBox.Show("Error: Debes ingresar una oracion.");
                return;
            }
            a  = new FrmCount();
            det = new DetectAbc();
            det.RecSentence(txtSentence.Text);
            a.ShowChars(det);

            prom = det.ShowCounts(ref totLower, ref totUpper);
            txt = "Promedio: " + prom;
            a.setLblProm(txt);

            txt = "Mayusculas: " + totUpper;
            a.setLblUpper(txt);

            txt = "Minusculas: " + totLower;
            a.setLblLower(txt);

            a.ShowDialog();
        }
    }
}
