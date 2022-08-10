using System;
using FastFood2;

namespace FastFood2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao fast-food");

            Cliente cliente = new Cliente();

            cliente.nome = "Jonatas";
            cliente.cpf = "12345678911";
            cliente.endereco.cidade = "São Paulo";
            cliente.endereco.bairro = "Jardim luso";
            cliente.endereco.Rua = "R. Olegario paiva";
            cliente.endereco.cep = "04421-130";
            cliente.endereco.numero = 490;

            ItemPedido itemP1 = new ItemPedido();
            itemP1.numeroPedidos = 1;
            itemP1.produto1.codigoProduto = 1;
            itemP1.produto1.quantidade = 5;
            itemP1.produto1.valorUnitario = 4.50;
            itemP1.produto1.Descricao = "X-tudo";
            itemP1.produto2.codigoProduto = 1;
            itemP1.produto2.quantidade = 2;
            itemP1.produto2.valorUnitario = 6.50;
            itemP1.produto2.Descricao = "Coca-Cola";
            itemP1.produto3.codigoProduto = 1;
            itemP1.produto3.quantidade = 1;
            itemP1.produto3.valorUnitario = 2.50;
            itemP1.produto3.Descricao = "Docinho de Côco";
            

            Console.ReadKey();
            Console.WriteLine("Volte sempre...");
        }
    }
}
