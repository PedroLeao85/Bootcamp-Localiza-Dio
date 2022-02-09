using Primeiro;
using System;
using CSharp;
using Interface;
using Enum;


namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa person = new Pessoa();

            person.Nome = "Pedro";
            person.Idade = 18;
            person.Estado = "MG";

            Pessoa person2 = new Pessoa();

            person2.Nome = "Julia";
            person2.Idade = 25;
            person2.Estado = "MG";

            var classe = new Classe();
            var classe2 = new Segundo.Classe();

            Animal animal = new Animal();

            animal.Nome = "Rex";
            animal.NomeDono = "Pedro";
            animal.Especie = "cachorro";

            var pessoa1 = (Pessoas)0;
            Pessoas pessoa2 = Pessoas.João;
            Pessoas pessoa3 = (Pessoas)4;

            Console.WriteLine("Hello World!");
            Console.WriteLine(pessoa3);
        }
    }
}