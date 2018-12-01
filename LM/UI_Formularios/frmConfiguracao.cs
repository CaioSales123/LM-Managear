using LM.Code;
using LM.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;

namespace LM.UI_Formularios
{
    public partial class frmConfiguracao : MaterialForm
    {
        Code.BLL BLL = new Code.BLL();
        frmAdm frm2 = new frmAdm();

        public frmConfiguracao()
        {
            InitializeComponent();           
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            //Instancia o método SalvarTema:
            var SalvarTema = new BLL();
            SalvarTema.SalvarTema(rdbPadrao, rdbEscuro, rdbClaro, frm2.dataGridViewProdutos, frm2.dataGridViewConsultas, timer1);           
        }

        private void frmConfiguracao_Load(object sender, EventArgs e)
        {
            lblFonteAtual.Text = Font.Name;
                      
            //Se Tema = 1:
            if (Properties.Settings.Default.Tema <= 1)
            {                
                //Tema Padrão - 1:
                MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

                // Definindo um esquema de Cor para formulário com tom Rosa
                materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Pink100, Primary.Pink300,
                Primary.Pink200, Accent.Pink200,
                TextShade.WHITE);
                rdbPadrao.Checked = true;
            }

            //Se Tema = 2:
            else if (Properties.Settings.Default.Tema == 2)
            {               
                //Tema Escuro - 2:
                MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

                // Definindo um esquema de Cor para formulário com tom Rosa
                materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Pink100, Primary.Pink300,
                Primary.Pink200, Accent.Pink200,
                TextShade.BLACK);
                rdbEscuro.Checked = true;
            }

            //Se Tema = 3:
            else if (Properties.Settings.Default.Tema == 3)
            {                
                //Tema Claro - 3:
                MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

                // Definindo um esquema de Cor para formulário com tom Rosa
                materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Pink100, Primary.Pink300,
                Primary.Pink200, Accent.Pink200,
                TextShade.WHITE);
                rdbClaro.Checked = true;
            }          
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPadrao_Click(object sender, EventArgs e)
        {           
            //Retorna ao padrão:
            //Instancia o método SalvarTema:
            var SalvarTema = new BLL();
            SalvarTema.SalvarTema(rdbPadrao, rdbEscuro, rdbClaro, frm2.dataGridViewProdutos, frm2.dataGridViewConsultas, timer1);

            //Instancia o método AtivaAnimação:
            var AtivaAnimação = new BLL();
            AtivaAnimação.AtivaAnimacao(btnSalvar, btnCancelar, btnPadrao, rdbPadrao, rdbEscuro, rdbClaro, metroPanelSalvar, timer1);     
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Instancia o método AtivaAnimação:
            var AtivaAnimacao = new BLL();
            AtivaAnimacao.AtivaAnimacao(btnSalvar, btnCancelar, btnPadrao, rdbPadrao, rdbEscuro, rdbClaro, metroPanelSalvar, timer1);    
        }

        private void btnProcurarCor_Click(object sender, EventArgs e)
        {
            //Instancia o método AlterarCor:
            var AlterarCor = new BLL();
            AlterarCor.AlterarCor(colorDialogGrid, formaCorAtual, frm2.dataGridViewProdutos);    
        }

        private void rdbCor_CorSolida_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCor_CorSolida.Checked == true)
            {
                btnProcurarCor.Enabled = true;
            }
            else
            {
                btnProcurarCor.Enabled = false;
            } 
        }
    }
}