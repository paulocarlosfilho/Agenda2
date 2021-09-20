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
    public partial class fmInserirEditar : Form
    {
        int indice;

        public fmInserirEditar()
        {
            InitializeComponent();
            ConstroiLista();
        }

        //============================================================================

        private void fmInserirEditar_Load(object sender, EventArgs e)
        {

        }

        //============================================================================
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //============================================================================

        private void textNome_Click(object sender, EventArgs e)
        {

        }

        //============================================================================
        private void cmdFechar_Click(object sender, EventArgs e)
        {
            //Fechar Formulário
            this.Close();
        }

        //============================================================================
        private void ConstroiLista()
        {
            //Adiciona a lista de contatos os contatos registrados.
            listaContatos.Items.Clear();

            foreach (clContato contato in clGeral.LISTA_CONTATOS)
            {
                listaContatos.Items.Add(contato.nome + " (" + contato.telefone + ")");
            }

            //Atualizar o número de Registros
            numeroRegistros.Text = "Registros: " + listaContatos.Items.Count;

            //Impedir a edição ou eliminação do registro

            cmdApagar.Enabled = false;
            cmdEditar.Enabled = false;
            
        }

        //============================================================================

        private void cmdGravar_Click(object sender, EventArgs e)
        {
            //Isere um novo registro na Lista

            //Verifica se os campos estão preenchidos
            if (textNome1.Text == "" || textTel.Text == "")
            {
                MessageBox.Show("Os campos não estão preenchidos.");
            }

            //Verifica Se existe algume registro igual na lista.

            foreach (clContato contato in clGeral.LISTA_CONTATOS)
            {
                if (contato.nome == textNome1.Text &&
                    contato.telefone == textTel.Text)
                {
                    MessageBox.Show("ERRO! Esse contato já existe"); return;
                }
            }

            //Gravar Novo Registro
            clGeral.GravarNovoRegistro(textNome1.Text, textTel.Text);

            //Atualizar Lista de contatos
            ConstroiLista();

            //Prepara o quadro para um novo registro

            textNome1.Text = "";
            textTel.Text = "";
            textNome1.Focus();
        }

        //============================================================================
        private void listaContatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selecionar um contato

            //verificar se o indece é igual a -1

            if (listaContatos.SelectedIndex == -1) return;

            //Selecionando um indice na lista

            indice = listaContatos.SelectedIndex;

            cmdApagar.Enabled = true;
            cmdEditar.Enabled = true;
        }

        //============================================================================

        private void cmdApagar_Click(object sender, EventArgs e)
        {
            //Apaga o regiistro selecionado

            //1ª Eliminar registro da lista

            clGeral.LISTA_CONTATOS.RemoveAt(indice);

            //2ª Renovar Ficheiro

            clGeral.GravarFicheiro();

            //3ª Reconstruir a lista de contatos

            ConstroiLista();
        }
    }
}
