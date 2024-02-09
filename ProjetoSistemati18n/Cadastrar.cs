using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSistemati18n
{
    public partial class Cadastrar : Form
    {
        DAO bd;

        public Cadastrar()
        {
            InitializeComponent();//Abre a tela
            bd = new DAO(); //Conectar a tela com a classe DAO
        }//Fim do construtor

        

     

        private void textoCodigo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do código

        private void textoNome_TextChanged(object sender, EventArgs e)
        {

        }//Fim do nome 

        private void textoTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do telefone

        private void textoCidade_TextChanged(object sender, EventArgs e)
        {

        }//Fim da cidade 

        private void textoEstado_TextChanged(object sender, EventArgs e)
        {

        }//Fim do estado 

        private void cadastrarBotao_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(textoCodigo.Text);
            string name = textoNome.Text;
            string tel  = textoTelefone.Text;
            string cid  = textoCidade.Text;
            string est  = textoEstado.Text;

            bd.Inserir(cod, name, tel , cid, est); //Inserindo no BD

            textoCodigo.Text = "";
            textoNome.Text = "";
            textoTelefone.Text = "";
            textoCidade.Text = "";
            textoEstado.Text = "";

        }//Botão do cadastrar PESSOA

        private void voltarBotao1_Click(object sender, EventArgs e)
        {

        }//Botão do voltar CADASTRAR
    }//Fim da classe
}//Fim do projeto
