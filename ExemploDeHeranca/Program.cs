using System;
using ExemploDeHeranca.models;

namespace ExemploDeHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncionarioModel func = new FuncionarioModel();
            int opcao;
            do
            {
                Console.WriteLine("Digite uma opçção");
                Console.WriteLine("1 - Cadastrar Funcionario");
                Console.WriteLine("2 - Execultar Ações");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());

                
            } while (opcao != 0);
        }
    }
}
