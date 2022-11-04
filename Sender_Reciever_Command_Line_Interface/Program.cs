using System;
using System.Diagnostics;

namespace Sender_Reciever_Command_Line_Interface
{
    internal class Program
    {
        public void Print_On_Console(ref string output)
        {
            Console.WriteLine(output);
        }
        public string Commad_Line_Interface()
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();

            process.StandardInput.WriteLine("Sender_Production_Code|Receiver_Production_Code");
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
           
            return process.StandardOutput.ReadToEnd();
        }
        static void Main(string[] args)
        {
            Program InstanceProgram = new Program();
            var output = InstanceProgram.Commad_Line_Interface();
            InstanceProgram.Print_On_Console( ref output);          
        }
    }
}
