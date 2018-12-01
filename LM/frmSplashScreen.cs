using LM.Forms;
using System;
using System.Windows.Forms;

namespace LM
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                rectangleShape2.Width += 10;
                if (rectangleShape2.Width >= 500)
                {
                    timer1.Stop();
                    this.Hide();

                    //Abre Formulário de Login:
                    frmAdm frm = new frmAdm();
                    frm.Show();
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            lblRegistrado.Text = "Registrado para: " + Environment.UserName;
        }
    }
}
