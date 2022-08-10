using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood
{
    public class Controlador : Model
    {
        public bool setCalculoDoPreco(double valor)
        {
            if (valor < 0) return false;
            else
            {
                valorProduto = valor * itensSelecionados;
                return true;
            }
        }

        public void getDadosCliente()
        {
            WriteLine($"Nome do Cliente: {this.nomeCliente}");
            WriteLine($"Pedido do Cliente: {this.pedidoCliente}");
            WriteLine($"Itens selecionados: {this.itensSelecionados}");
            WriteLine($"Valor do Pedido: R${this.valorProduto}");
            WriteLine();
            WriteLine($"ENDEREÇO: {this.enderecoCliente}");
        }
    }
}
