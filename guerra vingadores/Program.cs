using System;
using guerra_vingadores.controller;

namespace guerra_vingadores
{
    class Program
    {
        static void Main(string[] args)
        {
            CapitaoAmericaController cac = new CapitaoAmericaController();
            HomemDeFerroController hfc = new HomemDeFerroController();

            int opcao = 0;
            do
            {
                Console.WriteLine("Escolha uma opção");
                Console.WriteLine("1 - Capitão América");
                Console.WriteLine("2 - Homem de Ferro");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        cac.menuCp();
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 2:
                        hfc.menuHf();
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 0:
                        Console.WriteLine("Obrigado por usar nosso sistema");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcao != 0);

        }
    }
}
