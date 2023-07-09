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
    public partial class Banklar : Form
    {
        public Banklar()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rekvizit cars= new Rekvizit();
            cars.ShowDialog();
        }
    }
}
