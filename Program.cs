using System;
using Csharp;
using Interface;
using Enum;

namespace Csharp
{
    class Program 
    {
        static void Main(string[]args)
        
        {
            var pessoa1 = (Pessoas)0;
            Pessoa person = new Pessoa();
            Pessoas pessoa2 = Pessoas.Heloisa;
            Pessoas pessoa3 = (Pessoas)3;
            person.Nome = "Elen";
            person.Idade ="36";
            person.Estado = "PR";
             
             var person2 = new Pessoa();
             person2.Nome = "Aalan";
             person2.Idade ="09";
             person2.Estado = "PR";


            Animal animal = new Animal();
            animal.Nome ="Kayla";
            animal.Dono = "Elen";
            animal.Especie= "Cachorro";

            var animal2 = new Animal();
            animal.Nome ="Guga";
            animal.Dono = "Aalan";
            animal.Especie= "Tartaruga";
            Console.WriteLine (pessoa1);

        }
    }
}