using System;
using System.Collections.Generic;
using Sistema_hortifruti.models;

namespace Sistema_hortifruti.Controller
{
    public class EmpresaController
    {
        List<EmpresaModel> listaDeProdutos = new List<EmpresaModel>();
        public void CadastrarProduto()
        {
            Console.WriteLine("Digite o nome do produto: ");
            string nomeProduto = Console.ReadLine();
            Console.WriteLine("Escreva a categoria do produto: ");
            string categoriaPrduto = Console.ReadLine();
            Console.WriteLine("Digite o valor do produto: ");
            float valorProduto = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade em estoque");
            int quantidadeEstoque = int.Parse(Console.ReadLine());

            EmpresaModel empresa = new EmpresaModel();
            empresa.id = listaDeProdutos.Count + 1;
            empresa.Nome = nomeProduto;
            empresa.Categoria = categoriaPrduto;
            empresa.Preco = valorProduto;
            empresa.QuantidadeEstoque = quantidadeEstoque;
            empresa.DataCricao = DateTime.Now;
            listaDeProdutos.Add(empresa);
        }

        public void ListarProdutos()
        {
            foreach (var item in listaDeProdutos)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine($"Número do produto=> {item.id}\nProduto => {item.Nome}\nCategoria => {item.Categoria}\nPreço => {item.Preco}\nQuantidade em estoque => {item.QuantidadeEstoque}\nData de cadastro => {item.DataCricao} ");
                Console.WriteLine("----------------------");
            }
        }

        public float SomarProdutos()
        {   float soma = 0;
            foreach (var item in listaDeProdutos)
            {
                soma += item.Preco * item.QuantidadeEstoque;
            }
            return soma;
            
        }
    }
}