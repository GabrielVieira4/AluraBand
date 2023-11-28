using System;
using System.Xml.Serialization;
using BandaAlura;




namespace BandaAlura
{
    class Program
    {
        public static void Main()
        {
            Console.Clear();
            ExibirLogo();
            MensagemDeBoasVindas();
            ExibirMenu();

        }

        static void MensagemDeBoasVindas()
        {
            string mensagemDeBoasVindas = "Seja Bem vindo ao nosso programa!";
            Console.WriteLine(" ");
            Console.WriteLine(mensagemDeBoasVindas);
            Console.WriteLine(" ");
        }
        public static void ExibirLogo()
        {
            Console.Clear();
            Console.WriteLine(@"
░█████╗░██╗░░░░░██╗░░░██╗██████╗░░█████╗░██████╗░░█████╗░███╗░░██╗██████╗░
██╔══██╗██║░░░░░██║░░░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗████╗░██║██╔══██╗
███████║██║░░░░░██║░░░██║██████╔╝███████║██████╦╝███████║██╔██╗██║██║░░██║
██╔══██║██║░░░░░██║░░░██║██╔══██╗██╔══██║██╔══██╗██╔══██║██║╚████║██║░░██║
██║░░██║███████╗╚██████╔╝██║░░██║██║░░██║██████╦╝██║░░██║██║░╚███║██████╔╝
╚═╝░░╚═╝╚══════╝░╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░");

        }
        public static void ExibirMenu()
        {
            Console.WriteLine("Digite 1 para registrar uma banda");
            Console.WriteLine("Digite 2 para mostrar todas as bandas");
            Console.WriteLine("Digite 3 para avaliar uma banda");
            Console.WriteLine("Digite 4 para exibir a média de uma banda");
            Console.WriteLine("Digite 0 Para Fechar a aplicação.");
            Console.Write("\n Qual opção você escolheu?");
            string opcaoEscolhida = Console.ReadLine()!;
            switch (int.Parse(opcaoEscolhida))
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Menu.RegistrarBanda(); break;
                case 2: Menu.ExibirBandas(); break;
                case 3: Console.WriteLine("Avaliar uma banda"); break;
                case 4: Console.WriteLine("Avaliar uma banda"); break;
                default:
                    {
                        ExibirLogo();
                        Console.WriteLine("Você não escolheu uma das opções informadas. Para voltar ao menu anterior aperte qualquer tecla");
                        Console.ReadLine();
                        Main();
                        break;
                    }
            }
        }
        public static void ExibirTitulo(string titulo)
        {
            //Pelo amor de Deus que coisa desnecessária
            int Letras = titulo.Length;
            string linhas = string.Empty.PadLeft(Letras, '=');
            Console.WriteLine(linhas);
            Console.WriteLine(titulo);
            Console.WriteLine(linhas + "\n");
        }
    }

}