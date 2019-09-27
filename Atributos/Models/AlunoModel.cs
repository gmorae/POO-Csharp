using System;

namespace Atributos.Models
{
    public class AlunoModel
    {
        // get e set configura se pode alterar e consultar pelo nosso Program
        // public int MyProperty { get; set; } => atributo  => Objeto   
        public string Nome { get; set; }
        public string Curso { get; set; }
        public int Idade { get; set; }
        public double Rg { get; set; }

        public void cadastrarAluno()
        {
            Console.Clear();
            Console.WriteLine("Digite o nome do aluno: ");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite o Nome do curso: ");
            Curso = Console.ReadLine();
            Console.WriteLine("Digite a idade: ");
            Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o rg do aluno: ");
            Rg = double.Parse(Console.ReadLine());
        }

        public void listarAluno()
        {
            Console.WriteLine($@"

            Nome => {Nome}
            Curso => {Curso}
            Idade => {Idade}
            RG => {Rg}

            ");
        }

    }
}