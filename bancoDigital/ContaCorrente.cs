using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancoDigital
{
    public class ContaCorrente
    {
        public Cliente titular;
        public string conta;
        public string Agencia;
        public int numberAgecia;
        public double Saldo { get; private set; }

        public bool setSaldoInicial(double valor)
        {
            if (valor < 0) return false;
            if (Saldo < valor) return false;
            else Saldo += valor; return true;
        }

        public double getBackup()
        {
            double Saldo_Antigo = Saldo;
            return Saldo_Antigo;
        }

        public bool setSaque(double valor)
        {
            if (valor < 0) return false;
            if (Saldo < 0) return false;
            else
            {
                Saldo -= valor;
                return true;
            }
        }

        public bool setDeposito(double valor)
        {
            if (valor < 0) return false;
            else Saldo += valor; return true;
        }

        public bool setTrasferir(double valor, ContaCorrente destino)
        {
            if (valor < 0) return false;
            if (Saldo < valor) return false;
            else
            {
                Saldo -= valor;
                destino.Saldo += valor;
                return true;
            }
        }

        public void getCliente()
        {
            Console.WriteLine($"Nome do titular: {this.titular}");
            Console.WriteLine($"conta: {this.conta}");
            Console.WriteLine($"Agencia: {this.Agencia}");
            Console.WriteLine($"Numero da Agencia: {this.numberAgecia}");
            Console.WriteLine($"Saldo: {this.Saldo}");
        }
    }
}
