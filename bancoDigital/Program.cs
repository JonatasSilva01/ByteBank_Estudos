using System;
using bancoDigital;

namespace bancoDigital
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao banco Digital");

            ContaCorrente p1 = new ContaCorrente();
            p1.titular = new Cliente();

            p1.titular.nome = "Jonatas";
            p1.titular.profissao = "Programador C#";
            p1.titular.cpf = "1234567-2";

            p1.conta = "1234-x";
            p1.Agencia = "Agencia central do brasil";
            p1.numberAgecia = 501;

            p1.setSaldoInicial(1100.00);


            p1.getCliente();
            p1.getBackup();

            Console.ReadLine();
            Console.WriteLine("Volte Sempre...");
        }
    }
}
