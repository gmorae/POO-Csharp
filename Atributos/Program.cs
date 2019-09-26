using System;
using Atributos.Models;
namespace Atributos
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunoModel aluno1 = new AlunoModel();
            Console.Clear();
            Console.WriteLine("Digite o nome do aluno: ");
            aluno1.Nome = Console.ReadLine();
            Console.WriteLine("Digite o Nome do curso: ");
            aluno1.Curso = Console.ReadLine();
            Console.WriteLine("Digite a idade: ");
            aluno1.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o rg do aluno: ");
            aluno1.Rg = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($@"

            Nome => {aluno1.Nome}
            Curso => {aluno1.Curso}
            Idade => {aluno1.Idade}
            RG => {aluno1.Rg}

            ");
        }
    }
}
