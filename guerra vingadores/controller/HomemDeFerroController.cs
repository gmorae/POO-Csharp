using System;
using guerra_vingadores.models;

namespace guerra_vingadores.controller
{
    public class HomemDeFerroController
    {
        HomemDeFerroModel hf = new HomemDeFerroModel();
        public void Voar(){
            Console.WriteLine("\nVoar");
        }
        public void Atirar(){
            Console.WriteLine(@"
____)==/______,_
/__.-^-|_|''
            ");
        }
        public void CorHf(){
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public void menuHf()
        {
            CorHf();
            int opcaoHf = 0;
            do
            {
                Console.WriteLine("Escolha uma opção");
                Console.WriteLine("1 - Atirar");
                Console.WriteLine("2 - Voar");
                Console.WriteLine("0 - Mudar de jogador");
                opcaoHf = int.Parse(Console.ReadLine());
                switch (opcaoHf)
                {
                    case 1:
                        Atirar();
                        break;
                    case 2:
                        Voar();
                        break;
                    case 0:
                        Console.WriteLine("Até mais");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcaoHf != 0);
        }
    }
}