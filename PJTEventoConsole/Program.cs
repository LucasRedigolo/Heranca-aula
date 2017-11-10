using System;
using ProjetoEvento.ClassePai.ClassesFilhas;

namespace PJTEventoConsole {
    class Program {
        static void Main (string[] args) {

            string opcao = "";

            //Menu principal 
            do {
                Console.WriteLine ("Selecione o Tipo de Evento");
                Console.WriteLine ("1 - Show");
                Console.WriteLine ("2 - Pecas de Teatro");
                Console.WriteLine ("3 - Cinema");
                Console.WriteLine ("9 - Sair");

                opcao = Console.ReadLine ();

                switch (opcao) {
                    case "1":
                        consultaShow ();
                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                    default:
                        if (opcao == "9") {
                            break;
                        }
                        System.Console.WriteLine ("OPÇÃO INVÁLIDA!");
                        break;
                }
            } while (opcao != "9");
        }
        static void consultaShow () {

            string opcaoShow = "";
            do {
                Console.WriteLine ("Selecione a opcao desejada");
                Console.WriteLine ("1 - Cadastrar um novo Show");
                Console.WriteLine ("2 - Pesquisar shows pelo Titulo");
                Console.WriteLine ("3 - Pesquisar shows pela Data");
                Console.WriteLine ("9 - Voltar");

                opcaoShow = Console.ReadLine ();

                switch (opcaoShow) {
                    case "1":
                        {

                            System.Console.WriteLine ("Digite o Titulo do show:");
                            string Titulo = Console.ReadLine ().ToUpper();
                            System.Console.WriteLine ("Digite o Local do show:");
                            string Local = Console.ReadLine ();
                            System.Console.WriteLine ("Digite a Duracao do show:");
                            string Duracao = Console.ReadLine ();
                            System.Console.WriteLine ("Digite a data do show:");
                            DateTime Data = Convert.ToDateTime (Console.ReadLine ());
                            System.Console.WriteLine ("Digite o Artista/Banda do show:");
                            string Atracao = Console.ReadLine ();
                            System.Console.WriteLine ("Digite a classificação indicativa do show:");
                            int Classificacao = Convert.ToInt32 (Console.ReadLine ());
                            System.Console.WriteLine ("Digite a lotação do Evento:");
                            int Lotacao = Convert.ToInt32 (Console.ReadLine ());
                            System.Console.WriteLine ("Digite o Genero Musical do show:");
                            string Genero = Console.ReadLine ();

                            Show cadastro = new Show (Titulo, Local, Lotacao, Duracao, Classificacao, Data, Atracao, Genero);
                            bool cadastroSucesso = cadastro.Cadastrar ();

                            if (cadastroSucesso) {
                                System.Console.WriteLine ("\nShow cadastrado com sucesso!!");
                            } else {
                                System.Console.WriteLine ("Ocorreu um erro ao cadastrar novo show!");
                            }
                        }
                        break;

                    case "2":
                        System.Console.WriteLine("Digite o titulo do show:");
                        string titulo = Console.ReadLine().ToUpper();

                        Show pesquisaTitulo = new Show();
                        string resultado = pesquisaTitulo.Pesquisar(titulo);// sempre que o metodo tiver retorno armazena ele numa variavel para usar depois 

                        System.Console.WriteLine(resultado);

                        break;

                    case "3":
                        break;

                    default:
                        if (opcaoShow == "9") {
                            break;
                        }
                        System.Console.WriteLine ("OPÇÃO INVÁLIDA!");
                        break;

                }

            } while (opcaoShow != "9");
        }
    }
}