using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraznanja4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("unesite dvije rijeci: ");
            string tekst = Console.ReadLine();
            string[] rijeci = tekst.Split(' ');
            Console.WriteLine("vaš redosljed: " + rijeci[0] +" "+ rijeci[1]);
            Console.WriteLine(rijeci[0].ToCharArray());
            Array.Sort(rijeci);
            Console.WriteLine(rijeci);
            Console.ReadKey();
        }
    }
}
