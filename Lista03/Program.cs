using Lista03.Entities;
using Lista03.Repositories;
using System;
using System.Collections.Generic;

namespace Lista03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n*** CONTROLE DE FORNECEDORES E PRODUTOS ***\n");

            var fornecedor = new Fornecedor();
            fornecedor.Produtos = new List<Produto>();
            fornecedor.Endereco = new Endereco();

            
            fornecedor.Id = Guid.NewGuid();

            Console.Write("\nInforme o Nome do Fornecedor: ");
            fornecedor.Nome = Console.ReadLine();

            Console.Write("\nInforme o Cnpj do Fornecedor: ");
            fornecedor.Cnpj = Console.ReadLine();

            fornecedor.Endereco.IdEndereco = Guid.NewGuid();

            Console.Write("\nInforme o Logradouro do Fornecedor: ");
            fornecedor.Endereco.Logradouro = Console.ReadLine();

            Console.Write("\nInforme o Bairro do Fornecedor: ");
            fornecedor.Endereco.Bairro = Console.ReadLine();

            Console.Write("\nInforme a Cidade do Fornecedor: ");
            fornecedor.Endereco.Cidade = Console.ReadLine();

            Console.Write("\nInforme o Estado do Fornecedor: ");
            fornecedor.Endereco.Estado = Console.ReadLine();

            Console.Write("\nInforme o Cep do Fornecedor: ");
            fornecedor.Endereco.Cep = Console.ReadLine();

            Console.Write("\nInforme a quantidade de produtos: ");
            var qtd = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("\nAdicione o produto do fornecedor:\n");

                var produto = new Produto();
                produto.Id = Guid.NewGuid();

                Console.Write("\nInforme o nome do produto: ");
                produto.Nome = Console.ReadLine();

                Console.Write("\nInforme a quantidade do produto: ");
                produto.Quantidade = int.Parse(Console.ReadLine());

                Console.Write("\nInforme o preço do produto: ");
                produto.Preco = decimal.Parse(Console.ReadLine());

                

                fornecedor.Produtos.Add(produto);

                Console.WriteLine("\nProduto adicionado no fornecedor com sucesso.");

            }

            try
            {
                var fornecedorRepository = new FornecedorRepository();

                fornecedorRepository.ExportarXml(fornecedor);
                fornecedorRepository.ExportarJson(fornecedor);


                Console.WriteLine("\nDados gravados com sucesso! ");

            }
            catch (Exception e)
            {
                Console.WriteLine("\nOcorreu um erro: " + e.Message);
            }


            Console.ReadKey();

        }
    }
}
