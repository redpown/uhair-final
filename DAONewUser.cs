using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WpfApplication9
{
   public class DAONewUser: DAO
    {
        public void Inserir(string usuario, string senha , string chave)
        {
            //Abre conecção
            using (MySqlCommand comando = new MySqlCommand(
                 "INSERT " +
                 "INTO usuarios " +
                 "(usuario, senha, chave) " +
                 "VALUES " +
                 "( @usuario , @senha , @chave);", this.conexao))
            {
                try
                {

                    if (this.conexao.State == ConnectionState.Open)
                    {
                        //Se estiver aberta insere os dados na BD
                        // comando.Parameters.AddWithValue("@Nome", nome.Text);// para sql usar .Parameters.Add
                        comando.Parameters.AddWithValue("@usuario", usuario);
                        comando.Parameters.AddWithValue("@senha", senha);
                        comando.Parameters.AddWithValue("@chave", chave);
                        comando.BeginExecuteNonQuery();
                        reader = comando.ExecuteReader();
                        pg_erro.Show();
                    }
                    else
                    {
                        this.status = 1;
                        pg_erro.Show();
                    }
                    reader.Close();
                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Impossível estabelecer conexão:" + Erro);
                }
            }
        }
    }
}
