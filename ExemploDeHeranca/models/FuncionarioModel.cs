using System;

namespace ExemploDeHeranca.models
{
    public class FuncionarioModel : PessoaModel
    {
        public string Cargo{get; set;}
        
        public void Trabalhar(){
            Console.WriteLine("Agora vamos trabalhar");
        }
    }
}