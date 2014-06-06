using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooseCouplingWithReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeName = ConfigurationManager.AppSettings["messageWriter"];
            var type = Type.GetType(typeName, true);

            IMessageWriter writer = (IMessageWriter)Activator.CreateInstance(type);

            Salutation salutation = new Salutation(writer);
            salutation.Exclaim();

            Console.WriteLine("Execution Completed!!!");
            Console.ReadLine();
        }
    }
}
