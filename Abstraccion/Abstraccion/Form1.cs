namespace Abstraccion
{
    using System.Diagnostics;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            WebBrowser web = new WebBrowser();
            web.Navigate("https://github.com/SolracArt23/lector",true);
        }

        private void Validacion_Click(object sender, EventArgs e)
        {
            var pass = password.Text;
            if (pass == "1234") {

                //Mensaje de confimacion
                label49.Text= "contrasena correcta";

                //Inicial la aplicacion
                Gimnasio_Roble.Form1 incial = new Gimnasio_Roble.Form1();
                incial.ShowDialog();
            }
            else 
            {
                //mensaje de denegacion
                label49.Text= "contrasena incorrecta";
            }
        }
    }
}