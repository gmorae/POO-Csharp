using System;

namespace Sistema_hortifruti.models
{
    public class EmpresaModel
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public float Preco { get; set; }
        public int QuantidadeEstoque { get; set; }
        public DateTime DataCricao { get; set; }
    }
}