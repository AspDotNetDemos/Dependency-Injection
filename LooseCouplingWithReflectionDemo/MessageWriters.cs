using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooseCouplingWithReflectionDemo
{
    public class ConsoleMessageWriter : IMessageWriter
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class EventMessageWriter : IMessageWriter
    {
        public void Write(string message)
        {
            EventLog.WriteEntry("Application", message);
        }
    }

    public class TextFileMessageWriter : IMessageWriter
    {
        public void Write(string message)
        {
            using (StreamWriter streamWriter = new StreamWriter("e:\\DemoLog.txt"))
            {
                streamWriter.WriteLine(message);
                streamWriter.Close();
            }
        }
    }
}
