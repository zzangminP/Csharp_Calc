using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2018_11_07_계산기만들기_곽정민
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void 일반용계산기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             this.Owner.Show();
             this.Close();
            
        }

        private void 공학용계산기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Owner.Close();
            this.Show();
        }
    }
}
