using System;

namespace lista_POO.models
{
    public class PessoalModels
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