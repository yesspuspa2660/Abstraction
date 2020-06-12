using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abstraction.Abstraction_Class;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Hewan hewan;  // objek polymorphise

            hewan = new Kura_kura();
            hewan.Bergerak();

            Console.WriteLine();
            hewan = new Ular();
            hewan.Bergerak();

            Console.ReadKey();
        }
    }
}
