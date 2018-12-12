using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private _2018_11_07_계산기만들기_곽정민.Form1 Parent_Form1;

        private void button1_Click(object sender, EventArgs e)
        {
            Parent_Form1 = new _2018_11_07_계산기만들기_곽정민.Form1();
            Parent_Form1.Show();
            Parent_Form1.Owner = this;
            this.Hide();
        }
    }
}
