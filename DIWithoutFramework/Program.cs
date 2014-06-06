using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIWithoutFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Salutation salutation = new Salutation(new TextFileMessageWriter());
            salutation.Exclaim();

            Console.ReadLine();
        }
    }
}
