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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private _2018_11_07_계산기만들기_곽정민.Form1 ParentForm1;
        private void button1_Click(object sender, EventArgs e)
        {
            ParentForm1 = new _2018_11_07_계산기만들기_곽정민.Form1();
            ParentForm1.Owner = this;
            ParentForm1.Show();
            this.Hide();
        }
    }
}
