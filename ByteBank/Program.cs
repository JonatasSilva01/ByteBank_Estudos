using ByteBank;
using static System.Console; // namespace estatico

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente P1 = new ContaCorrente();
            P1.titular = new titular.Clientes();// aqui eu vou ter que referenciar um caminho para cliente senão o caminho fica nulo

            P1.titular.nome = "Jonatas";
            P1.titular.cpf = "12345678911";
            P1.titular.profissao = "Programador C#";
            P1.conta = "1234-x";
            P1.nomeAgencia = "Agencia Central dos Estados Unidos";
            P1.numeroAgencia = 102;
            P1.Saldo = 5000;
            

            ContaCorrente P2 = new ContaCorrente();
            P2.titular = new titular.Clientes();// aqui eu vou ter que referenciar um caminho para cliente senão o caminho fica nulo

            P2.titular.nome = "Maria Lurdes";
            P2.titular.cpf = "1234578911";
            P2.titular.profissao = "Mae";
            P2.conta = "1425-x";
            P2.nomeAgencia = "Agencia Cetral de Paris";
            P2.numeroAgencia = 932;
            P2.Saldo = 1000;


            WriteLine("Saldo da Conta 1: "+ P1.Saldo);
           
            WriteLine("Aperte alguma tecla para continuar...");

            ReadKey();
        }

    }
}
