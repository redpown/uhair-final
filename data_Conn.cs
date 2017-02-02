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
    public class DAO
    {
       public int status;
       public popup_ERRO pg_erro;
       public  MySqlConnection conexao; //MySQL
       // MySqlDataAdapter bdAdapter;
       public MySqlDataReader reader;
       public DataSet bdDataSet; //MySQL
        public DAO() {
           
            pg_erro = new popup_ERRO();
            //Definição do dataset
            bdDataSet = new DataSet();
            //Define string de conexão
            conexao = new MySqlConnection("server=localhost;database=uhair;uid=root;pwd=");


            //Abre conecção
           
                try
                {
                    conexao.Open();
                    
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


