using DesafioAluraOOP_parte1;
using System;

namespace DesafioAluraOOP_parte1
{
    class Program
    {
        static void Main(string[] args)
        {
            Model Produto1 = new Model();
            Model Produto2 = new Model();

            Produto1.Nome = "Carrinho de Controle Remoto";
            Produto1.Fabricante = "China";
            Produto1.CodigoDeBarras = "123456789124";
            Produto1.QuantidadeEmEstoqueDeProdutos = 55;
            Produto1.valorUnitario = 100.50;
            Produto1.valorDeCompra = 105.50;

            Produto2.Nome = "Playstation";
            Produto2.Fabricante = "Estados Unidos";
            Produto2.CodigoDeBarras = "234567893456";
            Produto2.QuantidadeEmEstoqueDeProdutos = 20;
            Produto2.valorUnitario = 1800.50;
            Produto2.valorDeCompra = 1850.50;

            Console.WriteLine($" | Nome: {Produto1.Nome}  |  Fabricante: {Produto1.Fabricante}");
            Console.WriteLine($" | Codigo de Barras: {Produto1.CodigoDeBarras} ");
            Console.WriteLine($" | Quantidade de Produtos em Estoque: {Produto1.QuantidadeEmEstoqueDeProdutos} ");
            Console.WriteLine($" | Valor unitario: {Produto1.valorUnitario}  | Valor De Compra: {Produto1.valorDeCompra}");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($" | Nome: {Produto2.Nome}  |  Fabricante: {Produto2.Fabricante}");
            Console.WriteLine($" | Codigo de Barras: {Produto2.CodigoDeBarras} ");
            Console.WriteLine($" | Quantidade de Produtos em Estoque: {Produto2.QuantidadeEmEstoqueDeProdutos} ");
            Console.WriteLine($" | Valor unitario: {Produto2.valorUnitario}  | Valor De Compra: {Produto2.valorDeCompra}");
        }
    }
}
