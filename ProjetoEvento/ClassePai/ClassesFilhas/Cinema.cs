using System;
using System.IO;
using System.Text;

namespace ProjetoEvento.ClassePai.ClassesFilhas {
    public class Cinema : Evento {
        public string Genero { get; set; }
        public DateTime[] Sessao { get; set; }
        public Cinema () {

        }
        public Cinema (string Titulo, string Local, int Lotacao, string Duracao, int Classificacao, DateTime Data, string Genero, DateTime[] Sessao) {
            base.Titulo = Titulo; // base é usado quando o objeto/atributo pertence a CLASSE PAI
            base.Local = Local;
            base.Lotacao = Lotacao;
            base.Duracao = Duracao;
            base.Classificacao = Classificacao;
            base.Data = Data;
            this.Genero = Genero;
            this.Sessao = Sessao; // this serve apenas para a mesma classe que esta sendo usado
        }
        public override bool Cadastrar () {
            bool Efetuado = false;
            StreamWriter arquivo = null;
            string Horarios = "";

            try // tenta o metodo abaixo até dar certo
            {
                arquivo = new StreamWriter ("cinema.csv", true);

                for (int i = 0; i < Sessao.Length; i++) {
                    Horarios += Sessao[i] + "/";
                }
                arquivo.WriteLine (Titulo + "-" + Local + "-" + Data + "-" + Lotacao + "-" + Duracao + "-" + Classificacao + "-" + Genero + "-" + Horarios);
                Efetuado = true;
            } catch (Exception ex) // o que será exibido caso der algum erro com o TRY 
            {
                throw new Exception ("Erro ao tentar gravar o arquivo" + ex.Message);
            } finally // o que acontece após conseguir passar pelo TRY com sucesso
            {
                arquivo.Close ();
            }
            return Efetuado;

        }
        public override string Pesquisar (string TituloEvento) {
            string Resultado = "Evento não encontrado";
            StreamReader ler = null;

            try {
                ler = new StreamReader ("cinema.csv", Encoding.Default); // ENCODING serve para dizer os tipos de caracteres que vão ser pesquisados
                string Linha = "";

                while ((Linha = ler.ReadLine ()) != null) // enquanto tiver dado escrito ele continua no while
                {
                    string[] dados = Linha.Split ('-'); // indica que cada dado pesquisado é separado por ";" e a cada ';' ele inclui o dado em um ARRAY
                    if (dados[0] == Titulo) // se ele encontrar o que foi epsquisado na coluna do titulo, ele lê toda a linha
                    {
                        Resultado = Linha;
                        break;
                    }
                }
            } catch (System.Exception ex) {
                Resultado = "Erro ao tentar ler o arquivo " + ex.Message;
            } finally {
                ler.Close ();
            }

            return Resultado;

        }
        public override string Pesquisar (DateTime Data) {
            string Resultado = "Não temos eventos nessa data";
            StreamReader ler = null;

            try {
                ler = new StreamReader ("cinema.csv", Encoding.Default); // ENCODING serve para dizer os tipos de caracteres que vão ser pesquisados
                string Linha = "";

                while ((Linha = ler.ReadLine ()) != null) // enquanto tiver dado escrito ele continua no while
                {
                    string[] dados = Linha.Split ('-'); // indica que cada dado pesquisado é separado por ";" e a cada ';' ele inclui o dado em um ARRAY
                    if (dados[2] == Data.ToString ()) // se ele encontrar o que foi epsquisado na coluna do titulo, ele lê toda a linha
                    {
                        Resultado = Linha;
                        break;
                    }
                }
            } catch (System.Exception ex) {
                Resultado = "Erro ao tentar ler o arquivo " + ex.Message;
            } finally {
                ler.Close ();
            }
            return Resultado;
        }
    }
}