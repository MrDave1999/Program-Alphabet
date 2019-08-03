using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlphabetProgram
{
    public partial class FrmCount : Form
    {
        public FrmCount()
        {
            InitializeComponent();
        }

        public void ShowChars(DetectAbc abc)
        {
            int[] countUpper = abc.getAbc().getCountUpper();
            int[] countLower = abc.getAbc().getCountLower();
            char[] a = abc.getAbc().getAbc();
            for (int i = 0; i != 26; ++i)
            {
                if (countUpper[i] != 0)
                    txtCount.Text += "-> " + a[i] + " : " + countUpper[i] + "\r\n";
                if (countLower[i] != 0)
                    txtCount.Text += "-> " + (char)(a[i] + 32) + " : " + countLower[i] + "\r\n";
            }
        }
    }
}
