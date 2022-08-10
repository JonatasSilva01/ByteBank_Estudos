using ByteBank.titular;

namespace ByteBank
{
    public class ContaCorrente
    {
        // Aqui é as referencias onde que Cliente aponta para titular e titular aponta para Cliente pegandos os dados cpf, nome, trabalho
        public Clientes titular; 
        public string conta;
        public int numeroAgencia;
        public string nomeAgencia;
        public double Saldo { get { return getSaldo(); } set { if (value < 0) return; else Saldo += value; } }

        public double getSaldo()
        {
            return Saldo;
        }

        public bool setSacar(double valor) // aqui a pessoa poderá fazer saques na sua conta e não pode fazer saques negativos
        {
            if (Saldo < valor) return false;
            if (valor < 0) return false;
            else
            {
                this.Saldo = Saldo - valor;
                System.Console.Write("valor retirado: R$" + valor + " ");

                return true;
            }
        }

        public void setDepositar(double valor)// Aqui a pessoa podera depositar tal valor na sua sendo que ela não pode depositar valores negativos
        {
            this.Saldo = Saldo + valor;
        }

        public bool setTransferencia(double valor, ContaCorrente destino)// Aqui a pessoa poderá fazer transferencia de uma conta para a outra;
        {
            if (Saldo < valor) return false;
            if (valor < 0) return false;
            else
            {
                Saldo -= valor;
                destino.Saldo += valor;
                return true;
            }
        }

        public void getDados() // Esse metodo retorna na tela todos os dados da pessoa que foi cadastrada
        {
            System.Console.WriteLine();
            System.Console.WriteLine($"Nome do titular: {this.titular.nome}");
            System.Console.WriteLine($"CPF do titular: {this.titular.cpf}");
            System.Console.WriteLine($"Profissao do Titular: {this.titular.profissao}");
            System.Console.WriteLine();
            System.Console.WriteLine($"Conta: {this.conta}");
            System.Console.WriteLine($"Nome da Agencia: {this.nomeAgencia}");
            System.Console.WriteLine($"Numero da Agência: {this.numeroAgencia}");
            System.Console.WriteLine($"Saldo: {this.Saldo}");
            System.Console.WriteLine();
        }
    }
}