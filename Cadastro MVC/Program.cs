using System;
using Cadastro_MVC.Controller;

namespace Cadastro_MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            UsuarioController usuarioController = new UsuarioController();
            int opcao = 0;
            do
            {
                Console.WriteLine("Escolha uma opção");
                Console.WriteLine("1 - Cadastrar Usuário");
                Console.WriteLine("2 - Listar Usuários");
                Console.WriteLine("3 - Autenticação");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        usuarioController.CadastroUsuario();
                        break;
                    case 2:
                        usuarioController.ListarUsuario();
                        break;
                    case 3:
                        bool usuarioRetornado = usuarioController.Logar();
                        if (usuarioRetornado)
                        {
                            Console.WriteLine("Usuário localizado");
                        }
                        else
                        {
                            Console.WriteLine("Usuário não encontrado");
                        }
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
