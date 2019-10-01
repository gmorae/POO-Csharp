using System;
using Sistema_hortifruti.Controller;

namespace Sistema_hortifruti
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpresaController empresa = new EmpresaController();
            int opcao = 0;
            do
            {
                Console.WriteLine("Escolha uma opção");
                Console.WriteLine("1 - Cadastrar Produto");
                Console.WriteLine("2 - Listar Produto");
                Console.WriteLine("3 - Calcular Produtos");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        empresa.CadastrarProduto();
                        break;
                    case 2:
                        empresa.ListarProdutos();
                        break;
                    case 3:
                       
                        Console.WriteLine($"Total de produtos => {empresa.SomarProdutos()}");
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
