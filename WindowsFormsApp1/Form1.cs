using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 5;
            int y;
            int i = 1;
            y = num + 3;
            string gg = " good game";
            string str = "gj";
            str += gg;
            
            MessageBox.Show("test " + num + y + gg + str);

            int level = 10;

            if (level > 30)
            {
                MessageBox.Show("GJ");
            }
            else if ( level == 30)
            {
                MessageBox.Show("GG");
            }
            else
            {
                MessageBox.Show("GJGJGJGJ");
            }

            while (i < 10)
            {
                i += 1;
                
            }
            MessageBox.Show("i= " + i);

            string text = "";
            for (int j = 1; j<10;  j++)
            {
                text = "test" + j;
            }
            MessageBox.Show(string.Format("text= {0} {1}", text, "   gj"));
        }
    }
}
