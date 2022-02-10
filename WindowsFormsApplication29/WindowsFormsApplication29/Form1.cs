using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt32(textBox1.Text);
            if (sayi < 10)
            {
                sayi++;
            }
            textBox1.Text = sayi.ToString();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt32(textBox1.Text);
            if (sayi > 0)
            {
                sayi--;
            }
            textBox1.Text = sayi.ToString();
           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi;
            listBox1.Items.Clear();
            sayi = Convert.ToInt32(textBox1.Text);

            

            for (int i=0; i < 11; i++)
            {

                listBox1.Items.Add(i + "x" + textBox1.Text + "=" + i * sayi);
           }
                
            

        }
    }
}
