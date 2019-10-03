using System;
using guerra_vingadores.models;

namespace guerra_vingadores.controller
{
    public class CapitaoAmericaController
    {
        CapitaoAmericaModel cp = new CapitaoAmericaModel();

        public void LancarEscudo()
        {
            Console.WriteLine("Lançar escudo");
        }

        public void Denfender()
        {
            Console.WriteLine("Defender-se");
        }

        public void CorCp()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        public void menuCp()
        {
            CorCp();
            int opcaoCp = 0;
            do
            {
                Console.WriteLine("Escolha uma opção");
                Console.WriteLine("1 - Lançar escudo");
                Console.WriteLine("2 - Defender");
                Console.WriteLine("0 - Mudar de jogador");
                opcaoCp = int.Parse(Console.ReadLine());
                switch (opcaoCp)
                {
                    case 1:
                        LancarEscudo();
                        break;
                    case 2:
                        Denfender();
                        break;
                    case 0:
                        Console.WriteLine("Até mais");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcaoCp != 0);
        }
    }
}