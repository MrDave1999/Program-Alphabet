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

        public void ShowChars(DetectAbc da)
        {
            StringBuilder txt = new StringBuilder();
            for (int i = 0; i != 26; ++i)
            {
                if (da.Alpha.CountUpper[i] != 0)
                    txt.Append("-> ").Append(da.Alpha.Abc[i]).Append(" : ").Append(da.Alpha.CountUpper[i]).Append("\r\n");
                
                if (da.Alpha.CountLower[i] != 0)
                    txt.Append("-> ").Append((char)(da.Alpha.Abc[i] + 32)).Append(" : ").Append(da.Alpha.CountLower[i]).Append("\r\n");        
            }
            txtCount.Text = txt.ToString();
        }
    }
}
