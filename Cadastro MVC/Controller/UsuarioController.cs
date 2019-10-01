using System;
using System.Collections.Generic;
using Cadastro_MVC.models;

namespace Cadastro_MVC.Controller
{
    public class UsuarioController
    {
        List<UsuarioModel> listaDeUsuario = new List<UsuarioModel>();
        public void CadastroUsuario()
        {

            Console.WriteLine("Vamos cadastrar");
            Console.WriteLine("Informe o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Digite a senha: ");
            string senha = Console.ReadLine();

            // Instanciando um novo objeto
            UsuarioModel usuario = new UsuarioModel();

            // Pegando o que foi escrito e armazenando no objeto 
            usuario.Id = listaDeUsuario.Count + 1;
            usuario.Nome = nome;
            usuario.Email = email;
            usuario.Senha = senha;
            usuario.DataCriacao = DateTime.Now;
            listaDeUsuario.Add(usuario);
            Console.WriteLine("Obrigado por cadastrar usuario");
        }

        public void ListarUsuario()
        {
            Console.Clear();
            foreach (var item in listaDeUsuario)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine($"Usuário => {item.Nome}\nId => {item.Id}\nEmail => {item.Email}\nData de criação => {item.DataCriacao}");
                Console.WriteLine("-----------------------");
            }
        }

        public bool Logar()
        {
            Console.WriteLine("Digite o e-mail: ");
            string email = Console.ReadLine();
            Console.WriteLine("Digite a senha");
            string senha = Console.ReadLine();

            foreach (var item in listaDeUsuario)
            {
                if (item.Email == email && item.Senha == senha)
                {
                    return true;
                }
            }
            return false;
        }
    }
}