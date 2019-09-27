using System;
using Atributos.Models;
namespace Atributos
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunoModel aluno1 = new AlunoModel();
            aluno1.cadastrarAluno();
            aluno1.listarAluno();
           
        }
    }
}
