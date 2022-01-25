using System;
using heroi_dio_desafio.src.Entities;

namespace heroi_dio_desafio.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Knight arus = new Knight("Arus", 23, "Knight");
            Topapa topapa = new Topapa("Jennica", 23, "White Wizard");
            
            
            Console.WriteLine(topapa.Attack(0));
            Console.WriteLine(topapa.Attack(7));
        }
    }
}
