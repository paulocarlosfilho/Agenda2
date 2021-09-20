using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda2
{
    public partial class fmMenu : Form
    {
        public fmMenu()
        {
            InitializeComponent();

            //Carrega os Contatos.
            clGeral.ConstroiListaCotatos();

            //Apresentação do projeto
            label_versao.Text = clGeral.versao;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdSair_Click_1(object sender, EventArgs e)
        {
            //Sair da Aplicação
            
            if (MessageBox.Show("Deseja sair da aplicação?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            Application.Exit();
        }

        private void cmd_inserir_Click(object sender, EventArgs e)
        {
            //Abre o quadro para a gestão de contatos

            fmInserirEditar formulario = new fmInserirEditar();
            formulario.ShowDialog();

        }

        private void cmd_pesquisar_Click(object sender, EventArgs e)
        {
            //Abrir quandro de pesquisa
            fmTexto f = new fmTexto();
            f.ShowDialog();

            //Quando fecha o quadro, verifica se foi cancelado
            if (f.cancelado) return;

            //Abrir quandro com resultados da pesquisa
            fmResultados ff = new fmResultados(f.texto);
            ff.ShowDialog();


        }
    }
}
