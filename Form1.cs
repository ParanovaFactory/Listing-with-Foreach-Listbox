using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int[] sayi = { 44, 78, 458, 45, 2121, 65, 1164, 45, 9884, 654 };
            foreach(int s in sayi)
            {
                if (s % 4 == 0)
                {
                    listBox1.Items.Add(s);
                    label1.Text= Convert.ToString(listBox1.Items.Count);
              
                }
                int i = 0;
                while (i<listBox1.Items.Count)
                {
                    toplam = toplam + Convert.ToInt32(listBox1.Items[i]);
                    i++;
                }
                label2.Text = toplam.ToString();

            }
        }
    }
}
