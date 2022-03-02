using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalancedSubstring
{
    public partial class StringInput : Form
    {
        public StringInput()
        {
            InitializeComponent();
        }

        private void Button_CalculateSubstring_Click(object sender, EventArgs e)
        {
            Label_Answer.Text = SubstringCalc.CalculateBalancedSubstring(TxtBox_EnterString.Text);
        }
    }
}
