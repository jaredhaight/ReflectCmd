using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectCmdDll
{
    public class CommandProcessor
    {
        public string Execute(string cmd)
        {
            System.Console.WriteLine("[dll]: got command: "+cmd);
            System.Console.WriteLine("[dll]: new proc");
            Process proc = new Process();
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.Arguments = "/C "+cmd;
            System.Console.WriteLine("[dll]: starting proc");
            proc.Start();
            string output = proc.StandardOutput.ReadToEnd();
            string error = proc.StandardError.ReadToEnd();
            System.Console.WriteLine("[dll]: getting output");
            if (error.Length > 0)
            {
                System.Console.WriteLine("[dll]: returning error");
                return error;
            }
            else
            {
                System.Console.WriteLine("[dll]: returning output");
                return output;
            }
        }
    }
}
