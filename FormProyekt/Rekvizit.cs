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
    public partial class Rekvizit : Form
    {
        public Rekvizit()
        {
            InitializeComponent();
        }
        public void Reader(object sender)
        {
            Button btn = (Button)sender;
            richTextBox1.Text += btn.Text;

        }

        private void Rekvizit_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Reader(sender);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Banklar banklar = new Banklar();
            banklar.ShowDialog();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 7 && richTextBox1.Text == "6A5S2UX")
            {
                BankCash bankCash = new BankCash();
                bankCash.ShowDialog();
            }
            else
            {
                MessageBox.Show("Müştəri tapılmadı");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
