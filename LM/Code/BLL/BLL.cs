using LM.Forms;
using LM.Properties;
using LM.UI_Formularios;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace LM.Code
{
    class BLL
    {
        DAL bd = new DAL();
        readonly Code.DTO DTO = new Code.DTO();

        int timerCounter = 0;
        int IDregistro = 0;
        public static int TemaSelecionado = Settings.Default.Tema;
        public static string TemaAtual;

        //Método Verificar, para criar a Base de Dados, caso necessário:
        public void Verificar()
        {
            bd.VerificarDB();
        }

        //Método VerificaTema:
        public void VerificaTema(//Parametros
                                 MetroFramework.Controls.MetroGrid dataGridViewProdutos,
                                 MetroFramework.Controls.MetroGrid dataGridViewConsultas)
        {         
            //Armazena o Formulário de Configurações em uma Variável:
            frmAdm frmADM = new frmAdm();

            if (Settings.Default.Tema <= 1)
            {
                //Tema Padrão - 1:
                MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(frmADM);
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

                // Definindo um esquema de Cor para formulário com tom Rosa
                materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Pink100, Primary.Pink300,
                Primary.Pink200, Accent.Pink200,
                TextShade.WHITE);

                TemaAtual = "1";
                dataGridViewProdutos.Theme = MetroFramework.MetroThemeStyle.Light;
                dataGridViewConsultas.Theme = MetroFramework.MetroThemeStyle.Light;

            }

            else if (Settings.Default.Tema == 2)
            {
                //Tema Escuro - 2:
                MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(frmADM);
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

                // Definindo um esquema de Cor para formulário com tom Rosa
                materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Pink100, Primary.Pink300,
                Primary.Pink200, Accent.Pink200,
                TextShade.BLACK);

                TemaAtual = "2";
                dataGridViewProdutos.Theme = MetroFramework.MetroThemeStyle.Dark;
                dataGridViewConsultas.Theme = MetroFramework.MetroThemeStyle.Dark;
            }

            else if (Settings.Default.Tema == 3)
            {
                //Tema Claro - 3:
                MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(frmADM);
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

                // Definindo um esquema de Cor para formulário com tom Rosa
                materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Pink100, Primary.Pink300,
                Primary.Pink200, Accent.Pink200,
                TextShade.WHITE);

                TemaAtual = "3";
                dataGridViewProdutos.Theme = MetroFramework.MetroThemeStyle.Light;
                dataGridViewConsultas.Theme = MetroFramework.MetroThemeStyle.Light;
            }
        }

        //Método Sair:
        public void Sair(//Parametros
                            MaterialSkin.Controls.MaterialSingleLineTextField txtProduto,
                            MaterialSkin.Controls.MaterialSingleLineTextField txtCategoria,
                            MaterialSkin.Controls.MaterialSingleLineTextField txtQuantidade)
        {
            //Verifica se tem algum dado em aberto a ser inserido:
            if (txtProduto.Text != string.Empty || txtCategoria.Text != string.Empty || txtQuantidade.Text != string.Empty)
            {
                if (MessageBox.Show("Há dados não salvos nos campos. Deseja salvar?", "LM-Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //Dialog Yes:
                }
                else
                {
                    //Dialog No:
                    Application.Exit();
                }
            }
            else 
            {
                Application.Exit();
            }
        }

        //Método Tema:
        public void SalvarTema(//Parametros
                            MaterialSkin.Controls.MaterialRadioButton rdbPadrao,
                            MaterialSkin.Controls.MaterialRadioButton rdbEscuro,
                            MaterialSkin.Controls.MaterialRadioButton rdbClaro,
                            MetroFramework.Controls.MetroGrid dataGridViewProdutos,
                            MetroFramework.Controls.MetroGrid dataGridViewConsultas,
                            System.Windows.Forms.Timer timer1)
        {
            //Armazena o Formulário de Configurações em uma Variável:
            frmConfiguracao frm = new frmConfiguracao();
            frmAdm frm2 = new frmAdm();

            //Verifica qual RadioButton está marcado:
            if (rdbPadrao.Checked == true)
            {
                //Tema Padrão - 1:
                MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(frm);
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

                // Definindo um esquema de Cor para formulário com tom Rosa
                materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Pink100, Primary.Pink300,
                Primary.Pink200, Accent.Pink200,
                TextShade.WHITE);
                
                TemaSelecionado = 1;
                Properties.Settings.Default.Tema = TemaSelecionado;
                TemaAtual = "1";
                dataGridViewProdutos.Theme = MetroFramework.MetroThemeStyle.Default;
                dataGridViewConsultas.Theme = MetroFramework.MetroThemeStyle.Default;
            }

            else if (rdbEscuro.Checked == true)
            {
                //Tema Escuro - 2:
                MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(frm);
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

                // Definindo um esquema de Cor para formulário com tom Rosa
                materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Pink100, Primary.Pink300,
                Primary.Pink200, Accent.Pink200,
                TextShade.BLACK);
                
                //Define a Variável como 2:
                TemaSelecionado = 2;
                Properties.Settings.Default.Tema = TemaSelecionado;
                TemaAtual = "2";
                dataGridViewProdutos.Theme = MetroFramework.MetroThemeStyle.Dark;
                dataGridViewConsultas.Theme = MetroFramework.MetroThemeStyle.Dark;
            }

            else if (rdbClaro.Checked == true)
            {
                //Tema Claro - 3:
                MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(frm);
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

                // Definindo um esquema de Cor para formulário com tom Rosa
                materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Pink100, Primary.Pink300,
                Primary.Pink200, Accent.Pink200,
                TextShade.WHITE);
               
                //Define a Váriavel como 3:
                TemaSelecionado = 3;
                Properties.Settings.Default.Tema = TemaSelecionado;
                TemaAtual = "3";
                dataGridViewProdutos.Theme = MetroFramework.MetroThemeStyle.Light;
                dataGridViewConsultas.Theme = MetroFramework.MetroThemeStyle.Light;
            }
            //Ao final, salva o valor Tema:
            Properties.Settings.Default.Save();

            //Ativa o Timer de animação:
            timer1.Enabled = true;

            MessageBox.Show("O sistema será reiniciado para aplicar as alterações.", "LM-Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Restart();
        }

        //Método AlteraCorGrid:
        public void AlterarCor(//Parametros
                              System.Windows.Forms.ColorDialog colorDialogGrid,
                              MaterialSkin.Controls.MaterialDivider formaCorAtual,
                              MetroFramework.Controls.MetroGrid dataGridViewProdutos)
        {
            frmAdm frm = new frmAdm();
            Color corSelecionada = colorDialogGrid.Color;

            //Abre o Dialog:
            colorDialogGrid.ShowDialog();
           
            //Atribuições:
            formaCorAtual.BackColor = corSelecionada;
            dataGridViewProdutos.BackgroundColor = corSelecionada;
        }

        //Método AtualizaCor:
        public void AtualizaCorLabel(//Parametros
                            MaterialSkin.Controls.MaterialLabel lblConfiguracao,
                            MaterialSkin.Controls.MaterialLabel lblSair)
        {
            if (BLL.TemaAtual == "1")
            {
                lblConfiguracao.ForeColor = System.Drawing.Color.White;
                lblSair.ForeColor = System.Drawing.Color.White;
            }
            else if (BLL.TemaAtual == "2")
            {
                lblConfiguracao.ForeColor = System.Drawing.Color.Black;
                lblSair.ForeColor = System.Drawing.Color.Black;
            }
            else if (BLL.TemaAtual == "3")
            {
                lblConfiguracao.ForeColor = System.Drawing.Color.White;
                lblSair.ForeColor = System.Drawing.Color.White;
            }
        }

        //Método Animação:
        public void AtivaAnimacao(//Parametros
                                 MaterialSkin.Controls.MaterialFlatButton btnSalvar,
                                 MaterialSkin.Controls.MaterialFlatButton btnCancelar,
                                 MaterialSkin.Controls.MaterialFlatButton btnPadrao,
                                 MaterialSkin.Controls.MaterialRadioButton rdbPadrao,
                                 MaterialSkin.Controls.MaterialRadioButton rdbEscuro,
                                 MaterialSkin.Controls.MaterialRadioButton rdbClaro,
                                 MetroFramework.Controls.MetroPanel metroPanelSalvar,
                                 System.Windows.Forms.Timer timer1)
        {
            try
            {
                //Desativa enquanto salva:
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
                btnPadrao.Enabled = false;

                rdbPadrao.Enabled = false;
                rdbEscuro.Enabled = false;
                rdbClaro.Enabled = false;

                //Incrementa:
                timerCounter++;
                metroPanelSalvar.Visible = true;
                if (timerCounter >= 100)
                {
                    timer1.Stop();

                    //Seta os padrões novamente:
                    metroPanelSalvar.Visible = false;
                    timer1.Enabled = false;
                    timerCounter = 0;

                    //Ativa após salvar:
                    btnSalvar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnPadrao.Enabled = true;

                    rdbPadrao.Enabled = true;
                    rdbEscuro.Enabled = true;
                    rdbClaro.Enabled = true;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        //Método AjustaStartADM:
        public void AjustaStartADM(//Parametros                            
                            System.Windows.Forms.ToolStripStatusLabel lblStatus,
                            MetroFramework.Controls.MetroGrid dataGridViewProdutos,
                            MetroFramework.Controls.MetroGrid dataGridViewConsultas)
        {
            //Exibe o nome do Usuário em uma label no menu Status Strip:
            lblStatus.Text = "Olá, " + Environment.UserName;

            //Método Carregar:
            Carregar(dataGridViewProdutos, dataGridViewConsultas);
        }

        //Método Carregar:
        public void Carregar(//Parametros
                             MetroFramework.Controls.MetroGrid dataGridViewProdutos,
                             MetroFramework.Controls.MetroGrid dataGridViewConsultas)
        {
            string var = DAL.conexao;
            SQLiteConnection conn = new SQLiteConnection(var);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM PRODUTOS", conn);
            SQLiteDataReader datareader = cmd.ExecuteReader();
            List<LM.Code.DTO> lista = new List<LM.Code.DTO>();

            while (datareader.Read())
            {
                lista.Add(new LM.Code.DTO
                {
                    Id = Convert.ToInt32(datareader["ID"]),
                    Produto = datareader["PRODUTO"].ToString(),
                    Categoria = datareader["CATEGORIA"].ToString(),
                    Quantidade = datareader["QUANTIDADE"].ToString()
                });
            }

            //Define o DataSource do DataGrid:
            dataGridViewProdutos.DataSource = lista;
            dataGridViewConsultas.DataSource = lista;
        }

        //Método Limpar Campos:
        public void LimparCampo(//Parametros
                                MaterialSkin.Controls.MaterialSingleLineTextField txtProduto,
                                MaterialSkin.Controls.MaterialSingleLineTextField txtCategoria,
                                MaterialSkin.Controls.MaterialSingleLineTextField txtQuantidade,
                                MaterialSkin.Controls.MaterialSingleLineTextField txtID)
        {
            txtProduto.Text = "";
            txtCategoria.Text = "";
            txtQuantidade.Text = "";
            txtID.Text = "";
        }

        //Método Seleciona Campo:
        public void SelecionarCampo(//Parametros
                                   MaterialSkin.Controls.MaterialSingleLineTextField txtProduto,
                                   MaterialSkin.Controls.MaterialSingleLineTextField txtCategoria,
                                   MaterialSkin.Controls.MaterialSingleLineTextField txtQuantidade,
                                   MaterialSkin.Controls.MaterialSingleLineTextField txtID,
                                   MaterialSkin.Controls.MaterialFlatButton btnLimpar,
                                   MaterialSkin.Controls.MaterialFlatButton btnAtualizar,
                                   MaterialSkin.Controls.MaterialFlatButton btnDeletar,
                                   MaterialSkin.Controls.MaterialFlatButton btnInserir,
                                   MetroFramework.Controls.MetroGrid dataGridViewProdutos,
                                   MetroFramework.Controls.MetroGrid dataGridViewConsultas)
        {
            //Ao clicar em um registro, os dados do mesmo serão passados para as TXT em modo ReadOnly:
            string DataGrid_Id = dataGridViewProdutos.SelectedRows[0].Cells[0].Value + string.Empty;
            string DataGrid_Produto = dataGridViewProdutos.SelectedRows[0].Cells[1].Value + string.Empty;
            string DataGrid_Categoria = dataGridViewProdutos.SelectedRows[0].Cells[2].Value + string.Empty;
            string DataGrid_Quantidade = dataGridViewProdutos.SelectedRows[0].Cells[3].Value + string.Empty;

            //Modo ReadyOnly:
            txtProduto.Enabled = false;
            txtCategoria.Enabled = false;
            txtQuantidade.Enabled = false;
            btnLimpar.Enabled = false;
            btnAtualizar.Enabled = false;
            btnDeletar.Enabled = false;
            btnInserir.Enabled = false;
            
            //Atribuições:
            txtID.Text = DataGrid_Id;
            txtProduto.Text = DataGrid_Produto;
            txtCategoria.Text = DataGrid_Categoria;
            txtQuantidade.Text = DataGrid_Quantidade;
        }

        //Método SelecionarParaEditar:
        public void SelecionarEditar(//Parametros
                                     MaterialSkin.Controls.MaterialSingleLineTextField txtProduto,
                                     MaterialSkin.Controls.MaterialSingleLineTextField txtCategoria,
                                     MaterialSkin.Controls.MaterialSingleLineTextField txtQuantidade,
                                     MaterialSkin.Controls.MaterialSingleLineTextField txtID,
                                     MaterialSkin.Controls.MaterialFlatButton btnLimpar,
                                     MaterialSkin.Controls.MaterialFlatButton btnAtualizar,
                                     MaterialSkin.Controls.MaterialFlatButton btnDeletar,
                                     MaterialSkin.Controls.MaterialFlatButton btnInserir,
                                     MetroFramework.Controls.MetroGrid dataGridViewProdutos,
                                     MetroFramework.Controls.MetroGrid dataGridViewConsultas)
        {
            SelecionarCampo(txtProduto, txtCategoria, txtQuantidade, txtID, btnLimpar, btnAtualizar, btnDeletar, btnInserir, dataGridViewProdutos, dataGridViewConsultas);

            //Desativa o Modo ReadyOnly:
            txtProduto.Enabled = true;
            txtCategoria.Enabled = true;
            txtQuantidade.Enabled = true;
            btnLimpar.Enabled = true;
            btnAtualizar.Enabled = true;
            btnDeletar.Enabled = true;
            btnInserir.Enabled = true;
        }

        //Método Inserir:
        public void Inserir(//Parametros
                            MaterialSkin.Controls.MaterialSingleLineTextField txtProduto,
                            MaterialSkin.Controls.MaterialSingleLineTextField txtCategoria,
                            MaterialSkin.Controls.MaterialSingleLineTextField txtQuantidade,
                            MaterialSkin.Controls.MaterialSingleLineTextField txtID,
                            MetroFramework.Controls.MetroGrid dataGridViewProdutos,
                            MetroFramework.Controls.MetroGrid dataGridViewConsultas)
        {
            //Verifica se campos estão preenchidos:
            if (txtProduto.Text == "" || txtCategoria.Text == "" || txtQuantidade.Text == "")
            {
                MessageBox.Show("Preencha os campos corretamente.", "LM-Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Define a variável como sendo a variável de conexão da classe Cliente DAL:
                string var = DAL.conexao;
                SQLiteConnection conn = new SQLiteConnection(var);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                //Instancia o Model Pessoas:
                DTO model = new LM.Code.DTO
                {
                    Produto = txtProduto.Text,
                    Categoria = txtCategoria.Text,
                    Quantidade = txtQuantidade.Text
                };

                SQLiteCommand cmd = new SQLiteCommand("INSERT INTO PRODUTOS (PRODUTO, CATEGORIA, QUANTIDADE) VALUES (@PRODUTO, @CATEGORIA, @QUANTIDADE)", conn);
                cmd.Parameters.AddWithValue("PRODUTO", model.Produto);
                cmd.Parameters.AddWithValue("CATEGORIA", model.Categoria);
                cmd.Parameters.AddWithValue("QUANTIDADE", model.Quantidade);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro salvo com sucesso", "LM-Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Após Inserir, limpa o campo:
                    txtProduto.Text = string.Empty;
                    txtCategoria.Text = string.Empty;
                    txtQuantidade.Text = string.Empty;

                    txtProduto.Focus();

                    //Exibe as ultimas alterações:
                    Carregar(dataGridViewProdutos, dataGridViewConsultas);

                }
                catch (Exception ex)
                {
                    //Exibe erro:
                    MessageBox.Show("Erro ao salvar registro: " + ex.Message, "LM-Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        //Método Atualizar:
        public void Atualizar(//Parametros
                              MaterialSkin.Controls.MaterialSingleLineTextField txtProduto,
                              MaterialSkin.Controls.MaterialSingleLineTextField txtCategoria,
                              MaterialSkin.Controls.MaterialSingleLineTextField txtQuantidade,
                              MaterialSkin.Controls.MaterialSingleLineTextField txtID,
                              MaterialSkin.Controls.MaterialFlatButton btnLimpar,
                              MaterialSkin.Controls.MaterialFlatButton btnAtualizar,
                              MaterialSkin.Controls.MaterialFlatButton btnDeletar,
                              MaterialSkin.Controls.MaterialFlatButton btnInserir,
                              MetroFramework.Controls.MetroGrid dataGridViewProdutos,
                              MetroFramework.Controls.MetroGrid dataGridViewConsultas)
        {
            //Verifica se campos estão preenchidos:
            if (txtProduto.Text == "" || txtCategoria.Text == "" || txtQuantidade.Text == "")
            {
                MessageBox.Show("Preencha os campos corretamente.", "LM-Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Deseja atualizar este registro?", "LM-Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {   //Dialog Yes:
                    IDregistro = LM.Forms.frmAdm.IDregistro;
                    if (IDregistro > 0)
                    {
                        //Define a variável como sendo a variável de conexão da classe Cliente DAL:
                        string var = DAL.conexao;
                        SQLiteConnection conn = new SQLiteConnection(var);
                        if (conn.State == ConnectionState.Closed)
                            conn.Open();

                        //Instancia o Model Pessoas:
                        LM.Code.DTO model = new LM.Code.DTO
                        {
                            Produto = txtProduto.Text,
                            Categoria = txtCategoria.Text,
                            Quantidade = txtQuantidade.Text
                        };

                        SQLiteCommand cmd = new SQLiteCommand("UPDATE PRODUTOS SET PRODUTO = :PRODUTO, CATEGORIA = :CATEGORIA, QUANTIDADE = :QUANTIDADE WHERE ID = @ID", conn);
                        cmd.Parameters.AddWithValue("ID", IDregistro);
                        cmd.Parameters.AddWithValue("PRODUTO", model.Produto);
                        cmd.Parameters.AddWithValue("CATEGORIA", model.Categoria);
                        cmd.Parameters.AddWithValue("QUANTIDADE", model.Quantidade);

                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Registro atualizado com sucesso", "LM-Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Após Inserir, limpa o campo:
                            txtProduto.Text = string.Empty;
                            txtCategoria.Text = string.Empty;
                            txtQuantidade.Text = string.Empty;

                            txtProduto.Focus();

                            //Exibe as ultimas alterações:
                            Carregar(dataGridViewProdutos, dataGridViewConsultas);
                        }
                        catch (Exception ex)
                        {
                            //Exibe erro:
                            MessageBox.Show("Erro ao atualizar registro: " + ex.Message, "LM-Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }                    
                }
                else //Dialog No: 
                {                   
                    //Ao cliar em um registro, os dados do mesmo serão passados para as TXT em modo de Edição:
                    string DataGrid_ID = dataGridViewProdutos.SelectedRows[0].Cells[0].Value + string.Empty;
                    string DataGrid_Produto = dataGridViewProdutos.SelectedRows[0].Cells[1].Value + string.Empty;
                    string DataGrid_Categoria = dataGridViewProdutos.SelectedRows[0].Cells[2].Value + string.Empty;
                    string DataGrid_Quantidade = dataGridViewProdutos.SelectedRows[0].Cells[3].Value + string.Empty;

                    txtProduto.Text = DataGrid_Produto;
                    txtCategoria.Text = DataGrid_Categoria;
                    txtQuantidade.Text = DataGrid_Quantidade;              
                }
            }
        }

        //Método Deletar:
        public void Deletar(//Parametros
                           MaterialSkin.Controls.MaterialSingleLineTextField txtProduto,
                           MaterialSkin.Controls.MaterialSingleLineTextField txtCategoria,
                           MaterialSkin.Controls.MaterialSingleLineTextField txtQuantidade,
                           MaterialSkin.Controls.MaterialSingleLineTextField txtID,
                           MetroFramework.Controls.MetroGrid dataGridViewProdutos,
                           MetroFramework.Controls.MetroGrid dataGridViewConsultas)
        {
            IDregistro = LM.Forms.frmAdm.IDregistro;
            if (IDregistro > 0)
            {
                //Define a variável como sendo a variável de conexão da classe Cliente DAL:
                string var = DAL.conexao;
                SQLiteConnection conn = new SQLiteConnection(var);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SQLiteCommand cmd = new SQLiteCommand("DELETE FROM PRODUTOS WHERE ID = @ID", conn);
                cmd.Parameters.AddWithValue("ID", IDregistro);

                if (MessageBox.Show("Deseja deletar este registro?", "LM-Manager",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {   
                    //Dialog Yes
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro deletado com sucesso", "LM-Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Limpa os Campos:
                        LimparCampo(txtProduto, txtCategoria, txtQuantidade, txtID);

                        //Exibe as ultimas alterações:
                        Carregar(dataGridViewProdutos, dataGridViewConsultas);
                        txtProduto.Focus();
                    }
                    catch (Exception ex)
                    {
                        //Exibe erro:
                        MessageBox.Show("Erro ao deletar registro: " + ex.Message, "LM-Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    //Dialog No:
                }                                      
            }
        }

        //Método Pesquisar:
        public DataTable PesquisarDados(//Parametros
                             MaterialSkin.Controls.MaterialSingleLineTextField txtID)
        {
            string var = DAL.conexao;
            SQLiteConnection conn = new SQLiteConnection(var);

            string sql = "SELECT ID, PRODUTO FROM PRODUTOS WHERE PRODUTO LIKE '" + txtID.Text + "%'";
            using (SQLiteConnection connection = new SQLiteConnection(var))
            {
                conn.Open();
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn))
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                    catch (SQLiteException ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }        
    }        
}