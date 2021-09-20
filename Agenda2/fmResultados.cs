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
    public partial class fmResultados : Form
    {
        string texto;

        //=======================================================================
        public fmResultados(string texto)
        {
            InitializeComponent();

            //Definir o texto de pesquisa
            this.texto = texto.ToUpper();
        }

        //=======================================================================
        private void button1_Click(object sender, EventArgs e)
        {
            //Fecha o quadro
            this.Close();
        }

        //=======================================================================
        private void cmd_pesquisar_Click(object sender, EventArgs e)
        {
            //Pedir texto
            fmTexto f = new fmTexto();
            f.ShowDialog();

            //Quando o quadro é fechado
            if (f.cancelado) return;

            f.texto.ToUpper();
            ExecutaPesquisa();
        }

        //=======================================================================
        private void numeroRegistros_Click(object sender, EventArgs e)
        {

        }

        //=======================================================================
        private void fmResultados_Load(object sender, EventArgs e)
        {
            //Executa a pesquisa e constroi lista
            ExecutaPesquisa();

        }

        //=======================================================================
        private void ExecutaPesquisa()
        {
            //Realiza a pesquisa e aprensenta os dados
            List<clContato> lista_resultados = new List<clContato>();
            
            foreach(clContato contato in clGeral.LISTA_CONTATOS)
            {
                if (contato.nome.ToUpper().Contains(texto) ||
                    contato.nome.ToUpper().Contains(texto))
                {
                    lista_resultados.Add(contato);
                }
            }

            //Aprensentar os resultados na lista
            lista_final.Items.Clear();
            foreach (clContato contato in lista_resultados)
            {
                lista_final.Items.Add(contato.nome + " (" + contato.telefone + ")");
            }

            numeroRegistros.Text = "Registros: " + lista_final.Items.Count;
        }
    }
}
