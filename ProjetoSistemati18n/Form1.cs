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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }//Fim do construtor 

        private void Menu_Load(object sender, EventArgs e)
        {

        }//Faz o carregamento da do conteudo da minha tela

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar();
            cad.ShowDialog();//Mostra na tela, a tela do cadastrar
        }

        private void consultar_Click(object sender, EventArgs e)
        {

        }

        private void atualizar_Click(object sender, EventArgs e)
        {

        }

        private void excluir_Click(object sender, EventArgs e)
        {

        }
    }//Fim da classe
}//Fim do projeto 
