using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloUser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Who are you? ");
            String name = Console.ReadLine();
            SayHi(name);

            Console.ReadLine();
        }

        static void SayHi(String name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}
