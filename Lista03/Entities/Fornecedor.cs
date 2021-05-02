using System;
using System.Collections.Generic;

namespace Lista03.Entities
{
    public class Fornecedor
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }

        public Endereco Endereco { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}

