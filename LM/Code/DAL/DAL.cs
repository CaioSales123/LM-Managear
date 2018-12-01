using System;
using System.Data.SQLite;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LM.Code
{
    class DAL
    {
        //Variáveis:
        public static string conexao = "Data Source=Banco.db";
        public static string nomebanco = "Banco.db";

        public static int IDregistro;

        public void VerificarDB()
        {
            //Verifica se o arquivo Banco.db já existe:
            string nomebanco = DAL.nomebanco;
            if (!File.Exists(nomebanco))
            {
                SQLiteConnection.CreateFile(nomebanco);
                string var = DAL.conexao;
                SQLiteConnection conn = new SQLiteConnection(var);
                conn.Open();

                //Cria as tabelas:
                StringBuilder sql = new StringBuilder();
                sql.Append("CREATE TABLE IF NOT EXISTS PRODUTOS ([ID] INTEGER PRIMARY KEY AUTOINCREMENT,");
                sql.Append("[PRODUTO] VARCHAR (150),");
                sql.Append("[CATEGORIA] VARCHAR (200),");
                sql.Append("[QUANTIDADE] VARCHAR (50))");

                MessageBox.Show("Base de Dados criada com sucesso", "LM-Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), conn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao criar bando de dados: " + ex.Message, "LM-Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}