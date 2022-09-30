namespace ExamenParcial1
{
    public partial class Form1 : Form
    {
        string conv = "";
        string txtres = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Conversiones_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Moneda moneda = new Moneda(textBox1.Text, comboBox1.SelectedText, conv, txtres);
            if (moneda.ShowDialog() == DialogResult.OK)
            {
                label3.Text = conv;
                resultado.Text = txtres;
            }

           
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}