using licores.Clases;

namespace licores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (txtUsuario.Text == "Cedula" || String.IsNullOrEmpty(txtUsuario.Text))
            {
                msgError("Por favor ingrese su Cedula.");
            }
            else
            {
                if (txtContra.Text == "Contrase�a" || String.IsNullOrEmpty(txtContra.Text))
                {
                    msgError("Por favor ingrese su Contrase�a.");
                }
                else
                {
                    User user = new User();
                    var validLogin = user.Login(txtUsuario, txtContra);
                    if (validLogin == true)
                    {
                        Home main = new Home();
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        msgError("La cedula o la contrase�a son incorrectas.");
                    }
                }
            }*/
            Home main = new Home();
            main.Show();
            this.Hide();
        }

        private void msgError(string msg)
        {
            lblError.Text = "    " + msg;
            lblError.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
