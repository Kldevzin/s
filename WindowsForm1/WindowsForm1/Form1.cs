namespace WindowsForm1
{
    public partial class Form1 : Form
    {
        public string User = "Facinoficial_";
        public string Password = "123456789";
        // texto de interação com o usuário
        public string usuario = null;
        public string senha = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_usuario_TextChanged(object sender, EventArgs e)
        {

            usuario = textBox1_usuario.Text;
        }

        private void textBox_senha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
