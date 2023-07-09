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
    public partial class Bakcell : Form
    {
        public Bakcell()
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

        private void button13_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Bakcell bakcell = new Bakcell();
            bakcell.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 10)
            {
                Cash odenis = new Cash();
                odenis.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nümunə:050-XXX-XX-XX");
            }
        }
    }
}