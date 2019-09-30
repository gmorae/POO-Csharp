using System;
using System.Collections.Generic;

namespace lista_POO.models
{
    public class FuncionarioModels : PessoalModels
    {
        public string Cargo { get; set; }

        public void Trabalhar()
        {
            Console.WriteLine("Agora vamos trabalhar");
        }

        public FuncionarioModels CadastrarFuncionario()
        {
            FuncionarioModels funcionario = new FuncionarioModels();
            Console.WriteLine("Digite o nome do funcionário: ");
            funcionario.Nome = Console.ReadLine();

            Console.WriteLine("Digite a idade: ");
            funcionario.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o cargo do funcionário: ");
            funcionario.Cargo = Console.ReadLine();

            return funcionario;
        }
    }
}