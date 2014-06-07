using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityDIDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Example 1

            //IMessageWriter writer;

            //var container = new UnityContainer();

            //writer = container.Resolve<ConsoleMessageWriter>();

            //writer.Write("Hi this is Unity Framework Demo!!!");

            #endregion

            #region Example 2

            //IMessageWriter writer;

            //var container = new UnityContainer();
            //container.RegisterType<IMessageWriter, ConsoleMessageWriter>();

            //writer = container.Resolve<IMessageWriter>();

            //writer.Write("Hi this is Unity Framework Demo!!!");

            #endregion

            #region Example 3

            //IMessageWriter writer;
            //var container = new UnityContainer();

            //container.RegisterType<IMessageWriter, ConsoleMessageWriter>("Console");
            //container.RegisterType<IMessageWriter, TextFileMessageWriter>("Text");

            //writer = container.Resolve<IMessageWriter>("Console");

            //writer.Write("Hi this is Unity Framework Demo!!!");

            #endregion

            #region Example 4

            IMessageWriter writer;
            var container = new UnityContainer();

            container.LoadConfiguration();

            writer = container.Resolve<IMessageWriter>();

            writer.Write("Hi this is Unity Framework Demo!!!");

            #endregion

            Console.WriteLine("---  Execution Completed!!!  ---");
            Console.ReadLine();
        }
    }
}
