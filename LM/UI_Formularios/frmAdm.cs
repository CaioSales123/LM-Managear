using LM.Code;
using LM.UI_Formularios;
using MaterialSkin;
using MaterialSkin.Controls;
using System;

namespace LM.Forms
{
    public partial class frmAdm : MaterialForm
    {
        Code.BLL BLL = new Code.BLL();
        Code.DTO DTO = new Code.DTO();

        //Varíaveis:
        public static int IDregistro;

        public frmAdm()
        {
            InitializeComponent();
            // Criando um material theme manager e adicionando o formulário
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            // Definindo um esquema de Cor para formulário com tom Azul
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Pink100, Primary.Pink300,
                Primary.Pink200, Accent.Pink200,
                TextShade.WHITE
            );
        }
        
        private void Adm_Load(object sender, System.EventArgs e)
        {
            //Instancia o método VerificarDB:
            var metodoVerificarDB = new BLL();
            metodoVerificarDB.Verificar();

            //Instancia o método metodoStart:
            var metodoStart = new BLL();
            metodoStart.AjustaStartADM(lblStatus, dataGridViewProdutos, dataGridViewConsultas);

            //Instancia o método VerificaTema:
            var VerificaTema = new BLL();
            VerificaTema.VerificaTema(dataGridViewProdutos, dataGridViewConsultas);

            //Instancia o método AtualizarCorLabel:
            var AtualizaCorLabel = new BLL();
            AtualizaCorLabel.AtualizaCorLabel(lblConfiguracao, lblSair);
        }

        //---------------------------------------------//
        private void btnLimpar_Click(object sender, System.EventArgs e)
        {
            //Instancia o método LimparCampos:
            var metodoLimparCampos = new BLL();
            metodoLimparCampos.LimparCampo(txtProduto, txtCategoria, txtQuantidade, txtID);
        }

        private void dataGridViewProdutos_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            DAL.IDregistro = IDregistro;
            IDregistro = Convert.ToInt32(dataGridViewProdutos.CurrentRow.Cells[0].Value);

            //Instancia o método SelecionaCampo:
            var metodoSelecionarCampo = new BLL();
            metodoSelecionarCampo.SelecionarCampo(txtProduto, txtCategoria, txtQuantidade, txtID, btnLimpar, btnAtualizar, btnDeletar, btnInserir, dataGridViewProdutos, dataGridViewConsultas);
        }

        private void dataGridViewProdutos_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            DAL.IDregistro = IDregistro;
            IDregistro = Convert.ToInt32(dataGridViewProdutos.CurrentRow.Cells[0].Value);

            //Instancia o método SelecionaCampoEditar:
            var SelecionarEditar = new BLL();
            SelecionarEditar.SelecionarEditar(txtProduto, txtCategoria, txtQuantidade, txtID, btnLimpar, btnAtualizar, btnDeletar, btnInserir, dataGridViewProdutos, dataGridViewConsultas);
        }

        private void btnInserir_Click(object sender, System.EventArgs e)
        {
            //Instancia o método Inserir:
            var metodoInserir = new BLL();
            metodoInserir.Inserir(txtProduto, txtCategoria, txtQuantidade, txtID, dataGridViewProdutos, dataGridViewConsultas);
        }

        private void btnAtualizar_Click(object sender, System.EventArgs e)
        {
            //Instancia o método Atualizar:
            var metodoAtualizar = new BLL();
            metodoAtualizar.Atualizar(txtProduto, txtCategoria, txtQuantidade, txtID, btnAtualizar, btnLimpar, btnDeletar, btnInserir, dataGridViewProdutos, dataGridViewConsultas);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            //Instancia o métoedo Deletar:
            var metodoDeletar = new BLL();
            metodoDeletar.Deletar(txtProduto, txtCategoria, txtQuantidade, txtID, dataGridViewProdutos, dataGridViewConsultas);
        }
        
        private void btnLimparTexto_Click(object sender, EventArgs e)
        {
            txtPesquisar.Text = "";
            //Instancia o método Carregar:
            var metodoCarregar = new BLL();
            metodoCarregar.Carregar(dataGridViewProdutos, dataGridViewConsultas);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Instancia o método Pesquisar:
            var metodoPesquisar = new BLL();
            metodoPesquisar.PesquisarDados(txtID);

            dataGridViewConsultas.DataSource = metodoPesquisar.PesquisarDados(txtPesquisar);
        }

        private void lblConfiguracao_Click(object sender, EventArgs e)
        {
            //Abre Formulário de Configurações:
            frmConfiguracao frm = new frmConfiguracao();
            frmAdm frm2 = new frmAdm();
            frm.Show();          
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            //Instancia o métoedo Sair:
            var metodoSair = new BLL();
            metodoSair.Sair(txtProduto, txtCategoria, txtQuantidade);
        }      
    }
}