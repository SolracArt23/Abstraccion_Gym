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
            troll t = new troll();
            web.Parent= t;
            web.Dock= DockStyle.Fill;
            web.Url = new Uri("https://www.bing.com/videos/search?q=rickr+roll+vim&view=detail&mid=CFAC16CA30B5EF2ADD68CFAC16CA30B",true);
            //web.Navigate("https://www.bing.com/videos/search?q=rickr+roll+vim&view=detail&mid=CFAC16CA30B5EF2ADD68CFAC16CA30B");
     
            //t.Show();
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