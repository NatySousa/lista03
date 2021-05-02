using System;


namespace Lista03.Entities
{
    public class Endereco
    {
        public Guid IdEndereco { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }

    }
}
