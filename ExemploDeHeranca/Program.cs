using System;
using ExemploDeHeranca.models;

namespace ExemploDeHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            FuncionarioModel func = new FuncionarioModel();
            do
            {
                Console.Clear();
                Console.WriteLine("Digite uma opçção");
                Console.WriteLine("1 - Cadastrar Funcionario");
                Console.WriteLine("2 - Execultar Ações");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Cadstro de usuário");
                        func.CadastrarFuncionario();
                        break;
                    case 2:
                        Console.Clear();
                        int acao = 0;
                        do
                        {
                            Console.WriteLine($"Selecione uma opção para {func.Nome}");
                            Console.WriteLine("1 - Andar");
                            Console.WriteLine("2 - Comer");
                            Console.WriteLine("3 - Trabalhar");
                            Console.WriteLine("0 - Sair");
                            acao = int.Parse(Console.ReadLine());
                            switch (opcao)
                            {
                                case 1:
                                    func.Andar();
                                    break;
                                case 2:
                                    func.Comer();
                                    break;
                                case 3:
                                    func.Trabalhar();
                                    break;
                                case 0:
                                    Console.WriteLine("Até mais");
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida");
                                    break;
                            }
                        } while (acao != 0);
                        break;

                    case 0:
                        Console.Clear();
                        Console.WriteLine("Obrigado por utilizar nosso sistema");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida !");
                        break;
                }
            } while (opcao != 0);
        }
    }
}
