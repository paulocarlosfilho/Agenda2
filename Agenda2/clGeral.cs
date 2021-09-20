using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Agenda2
{
    public static class clGeral
    {
        public static string versao = "v 1.0.0";

        //Lista de contatos

        public static List<clContato> LISTA_CONTATOS;

        //============================================================================
        public static void ConstroiListaCotatos()
        {
            //Método para o carregamento da lista de contatos

            //Verificar se o Ficheiro existe
            string pastaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nomeFicheiro = pastaDocumentos + @"\ficheiro_contatos.txt";

            //Criando a lista vazia.
            LISTA_CONTATOS = new List<clContato>();

            if (File.Exists(nomeFicheiro))
            {
                StreamReader ficheiro = new StreamReader(nomeFicheiro, Encoding.Default);

                while (!ficheiro.EndOfStream)
                {
                    //Carrega nome.
                    string nome = ficheiro.ReadLine();
                    //Carrega telefone.
                    string telefone = ficheiro.ReadLine();

                    //Adicionar à Lista de contatos o contato carregado.

                    clContato novoContato = new clContato();
                    
                    novoContato.nome = nome;
                    novoContato.telefone = telefone;

                    LISTA_CONTATOS.Add(novoContato);
                }
                ficheiro.Dispose();
            }
        }

        //============================================================================
        public static void GravarNovoRegistro(string _nome, string _telefone)
        {
            //Gravar um novo registro na lista
            LISTA_CONTATOS.Add(new clContato() { nome = _nome, telefone = _telefone });
        }

        //============================================================================
        public static void GravarFicheiro()
        {
            string pastaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nomeFicheiro = pastaDocumentos + @"\ficheiro_contatos.txt";
            //Gravar um novo registro no ficheiro
            StreamWriter ficheiro = new StreamWriter(nomeFicheiro, true, Encoding.Default);
            foreach (clContato contato in LISTA_CONTATOS)
            {
                ficheiro.WriteLine(contato.nome);
                ficheiro.WriteLine(contato.telefone);
            }
            
            ficheiro.Dispose();
        }

        //============================================================================
    }
}
