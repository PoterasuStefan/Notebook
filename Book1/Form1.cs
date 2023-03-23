using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book1
{
    public partial class Form1 : Form
    {

        int Current_page=1;
        string[] Page = new string[10];

        public Form1()
        {
            InitializeComponent();
            label2.Text = Current_page.ToString();
           
        }





        private void button1_Click(object sender, EventArgs e)
        {
            if (Current_page >= 1 && Current_page < 10)
            {
                Current_page++;
               
            }
            textBox1.Text = Page[Current_page];
            label2.Text = Current_page.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Current_page > 1 && Current_page <= 10)
            {
                Current_page--;
            }
            textBox1.Text = Page[Current_page];
            label2.Text = Current_page.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Page[Current_page] = textBox1.Text;
        }
        
    }
}
