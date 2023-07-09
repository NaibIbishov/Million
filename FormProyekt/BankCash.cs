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
    public partial class BankCash : Form
    {
        public BankCash()
        {
            InitializeComponent();
        }
        public string Borrow = "1000 AZN";
        public string Borro = "238";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BankCash_Load(object sender, EventArgs e)
        {
            label1.Text = Borrow;
            label4.Text = Borro;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Rekvizit rekvizit = new Rekvizit();
            rekvizit.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Cash cash = new Cash();
            cash.ShowDialog();
        }
    }
}
