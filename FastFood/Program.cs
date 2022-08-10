using System;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            Controlador p1 = new Controlador();
            p1.nomeCliente = "Jonatas";
            p1.pedidoCliente = "X-tudo, Agua com limao, sobrimesa";
            p1.enderecoCliente = "R. Olegario Paiva, 490";
            p1.itensSelecionados = 3;
            p1.setCalculoDoPreco(18.15);

            p1.getDadosCliente();
        }
    }
}
