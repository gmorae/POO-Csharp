using System;

namespace ExemploDeHeranca.models
{
    public class FuncionarioModel : PessoaModel
    {
        public string Cargo { get; set; }

        public void Trabalhar()
        {
            Console.WriteLine("Agora vamos trabalhar");
        }

        public void CadastrarFuncionario()
        {
            Console.WriteLine("Digite o nome do funcionário: ");
            Nome = Console.ReadLine();

            Console.WriteLine("Digite a idade: ");
            Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o cargo do funcionário: ");
            Cargo = Console.ReadLine();
        }
    }
}