using System;

namespace Cadastro_MVC.models
{
    public class UsuarioModel : BaseModel
    {
        public string Email { get; set; }

        public string Senha { get; set; }

        public DateTime DataNascimento {get; set;}
    }
}