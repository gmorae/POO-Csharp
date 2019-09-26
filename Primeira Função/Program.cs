using System;

namespace Primeira_Função
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primeira função\n");
            Console.WriteLine("Digite um valor: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro valor: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Soma = {Soma(n1, n2)}");
            Console.WriteLine($"Subtração = {Subtracao(n1, n2)}");
            Console.WriteLine($"Multiplicação = {Multi(n1, n2)}");
            Console.WriteLine($"Divisão = {Div(n1, n2)}");

        }
        public static int Soma(int a, int b){
            int soma = a + b;
            return soma;
        }

        public static int Subtracao(int a, int b){
            int subtracao;
            return subtracao = a - b;
        }

        public static int Multi(int a, int b){
            int multi;
            return multi = a * b;
        }

        public static float Div(int a, int b){
            int div;
            return div = a / b;
        }
    }
}
