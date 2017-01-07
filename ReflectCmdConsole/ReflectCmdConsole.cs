using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectCmdConsole
{
    class Console
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                System.Console.WriteLine("Usage: ReflectCmdConsole.exe <dllpath> <cmd>");
                return;
            }

            string dllPath = args[0];
            string cmd = args[1];

            System.Console.WriteLine("[console]: loading assembly.");
            Assembly ReflectCmdDll = Assembly.LoadFile(dllPath);
            System.Console.WriteLine("[console]: loading type.");
            Type commandProcessor = ReflectCmdDll.GetType("ReflectCmdDll.CommandProcessor");
            System.Console.WriteLine("[console]: creating instance.");
            var c = Activator.CreateInstance(commandProcessor);
            System.Console.WriteLine("[console]: running command.");
            string output = commandProcessor.InvokeMember("Execute", BindingFlags.InvokeMethod, null, c, new object[] { cmd }).ToString();
            System.Console.WriteLine("[console]: printing output.\n\n");
            System.Console.WriteLine(output);
        }
    }
}
