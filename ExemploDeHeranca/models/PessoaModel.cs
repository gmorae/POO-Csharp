using System;

namespace ExemploDeHeranca.models
{
    public class PessoaModel
    {
        public string Nome{get; set;}
        public int Idade{get; set;}

        public void Comer(){
            Console.WriteLine("Vamos Comer");
        }

        public void Andar(){
            Console.WriteLine("Vamos andar");
        }
    }
}