using System.Reflection.PortableExecutable;

namespace BandaAlura
{


    class Menu
    {

        public static Dictionary<string, List<int>> listaDeBandas = new Dictionary<string, List<int>>();
        //  Menu.listaDeBandas.Add("Banda do Largatixo", new List<int> { 10, 5, 9, });
        //     Menu.listaDeBandas.Add("Calypso da quebrada", new List<int>());

        public static void RegistrarBanda()
        {
            Console.Clear();
            Program.ExibirTitulo("Registro de Bandas");
            Console.WriteLine("Digite o nome da banda em que deseja Registrar: ");
            string nomeBanda = Console.ReadLine()!;
            Menu.listaDeBandas.Add(nomeBanda, new List<int>());
            Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso");
            Thread.Sleep(2000);
            Console.Clear();
            Program.ExibirLogo();
            Console.WriteLine(" ");
            Program.ExibirMenu();

        }
        public static void ExibirBandas()
        {
            Console.Clear();
            Program.ExibirTitulo("Lista das Bandas");
            foreach (string Banda in listaDeBandas.Keys)
            { Console.WriteLine($"Banda:{Banda}"); }
            Console.WriteLine(" ");
            Console.WriteLine("Digite qualquer tecla para voltar ao menu principal: ");
            Console.ReadKey();
            Program.Main();
        }
        public static void AvaliarBanda()
        {
            Program.ExibirTitulo("Avalie uma banda");
        }
        public static void ExibirMediaBanda()
        {

        }
    }
}