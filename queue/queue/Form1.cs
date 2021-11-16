using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace queue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox2.Items.Add(listBox1.Items[0]);
                listBox1.Items.RemoveAt(0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var yeni = (new Random().Next(0, 10).ToString());
            if (!listBox1.Items.Contains(yeni) && !listBox2.Items.Contains(yeni))
                listBox1.Items.Add(yeni);
        }
    }
}
