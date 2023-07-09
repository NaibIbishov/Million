using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormProyekt
{
    public partial class Cash : Form
    {
        public Cash()
        {
            InitializeComponent();
        }
        public void Show(object sender)
        {
            Button btn = (Button)sender;
            richTextBox1.Text += btn.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Show(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Show(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Show(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Show(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Show(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Show(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Show(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Show(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Show(sender);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Show(sender);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
           Form1 form = new Form1();
            form.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show($" {richTextBox1.Text} Azn ödəniş edildi");
            Form1 form = new Form1();
            form.ShowDialog();
        }
    }
}
