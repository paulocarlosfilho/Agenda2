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
    public partial class fmTexto : Form
    {
        //Propriedade de Controle
        public bool cancelado { get; set; }
        public string texto { get; set; }

        public fmTexto()
        {
            InitializeComponent();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            //Cancela o quadro
            cancelado = true;
            this.Close();
        }

        private void cndPesquisar_Click(object sender, EventArgs e)
        {
            //Define texto e fecha quandro
            texto = text_texto.Text;
            cancelado = false;
            this.Close();
        }

        private void text_texto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
