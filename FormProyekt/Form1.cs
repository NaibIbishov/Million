namespace FormProyekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Azercell azercell = new Azercell();
            azercell.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bakcell bakcell = new Bakcell();
            bakcell.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Banklar banklar=new Banklar();
            banklar.ShowDialog();
        }
    }
}