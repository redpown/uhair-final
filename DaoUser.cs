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
    class DaoUser : DAO
    {
        
        public void usar(string email, string senha) {
            //Abre conecção
            using (MySqlCommand comando = new MySqlCommand(
                 "SELECT id " +
                 "FROM usuarios " +
                 "where " +
                 "usuario = @Email and " +
                 "senha = @Senha;", this.conexao))
            {
                try
                {
                    
                    if (this.conexao.State == ConnectionState.Open)
                    {
                        //Se estiver aberta insere os dados na BD
                        // comando.Parameters.AddWithValue("@Nome", nome.Text);// para sql usar .Parameters.Add
                        comando.Parameters.AddWithValue("@Email", email);
                        comando.Parameters.AddWithValue("@Senha", senha);
                        comando.BeginExecuteNonQuery();
                        reader = comando.ExecuteReader();
                    }
                    if (reader.HasRows)
                    {
                        this.status = 0;
                        Cad_menu tela_menu_log = new
                           Cad_menu();
                        tela_menu_log.Show();
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
                //Verifica se a conexão está aberta


                //sql server conect
            }
        }
          
           
    }
}
