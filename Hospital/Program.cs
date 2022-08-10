using Hospital;
using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem viando ao painel de exibição dos Pacientes");
            ModeloPaciente Modelo = new ModeloPaciente();

            Modelo.nome = "vazio";
            Modelo.idade = 0;
            Modelo.peso = 00.0;
            Modelo.altura = 0.00;

            Console.WriteLine($"{Modelo.nome}");
            Console.WriteLine($"{Modelo.idade}");
            Console.WriteLine($"{Modelo.peso}");
            Console.WriteLine($"{Modelo.altura}");

            ModeloPaciente Pessoa = Modelo;
            Pessoa.nome = "Jonatas Silva dos Santos";
            Pessoa.altura = 1.90;
            Pessoa.peso = 88.4;

            Console.WriteLine(Pessoa.nome);
            Console.WriteLine(Pessoa.idade);
            Console.WriteLine(Pessoa.peso);
            Console.WriteLine(Pessoa.altura);

            ModeloPaciente Pessoa2 = Modelo;

            Pessoa2.idade = 21;

            Console.WriteLine(Pessoa.nome);
            Console.WriteLine(Pessoa.peso);
            Console.WriteLine(Pessoa.idade);
            Console.WriteLine(Pessoa.altura);
        }
    }
}
