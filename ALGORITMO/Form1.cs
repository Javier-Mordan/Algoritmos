namespace ALGORITMO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        int valor1 = 0;
        int valor2 = 0;
        int valor3 = 0;
        int valor4 = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToInt32(textBox1.Text);
            valor2 = Convert.ToInt32(textBox2.Text); ;
            valor3 = Convert.ToInt32(textBox3.Text);
            valor4 = Convert.ToInt32(textBox4.Text);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}