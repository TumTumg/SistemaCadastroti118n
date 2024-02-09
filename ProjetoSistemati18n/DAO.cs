using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProjetoSistemati18n
{
    class DAO
    {
        MySqlConnection conexao;
        public string dados;
        public string sql;
        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;DataBase=ti18n;Uid=root;Password=");    
            try
            {

                conexao.Open();
                MessageBox.Show("Conectado com sucesso!");//Temporariamente

            }catch(Exception erro)
            {
                MessageBox.Show(erro + "\n\nAlgo deu errado!");
            }//Fim do catch 

        }//FIM do construtor

        public void Inserir(int codigo,string nome, string telefone, string cidade, string estado)
        {
            dados = "('" + codigo + "','" + nome + "','" + telefone + "','" + cidade + "','" + estado + "')";
            sql = "insert into pessoa(codigo, nome, telefone, cidade, estado)values" + dados;

            try
            {


                MySqlCommand conn = new MySqlCommand(sql, conexao);//Prepara o comando no banco 
                MessageBox.Show(conn.ExecuteNonQuery() + "Um dado inserido");//Ctrl + Enter no comando
            }catch(Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }

       }//Fim do método 


    }//Fim da classe
}//FIM DO PROJETO
