using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Receiver_TestFramework
{
    internal class Receiver_Data
    {
        public void Print_On_Console(string output)
        {
            Console.WriteLine(output);
        }

        public string Find_Average(double[] Battery_Parameters)
        {
            double[] InstBattery_Parameters = new double[5];
            int i = 0;
            for (int index = Battery_Parameters.Count() - 5; index <= Battery_Parameters.Count() - 1; index++)
            {
                InstBattery_Parameters[i] = Battery_Parameters[index];
                i = i + 1;
            }
            return InstBattery_Parameters.Average().ToString();
        }
        public string Find_Maximum(double[] Battery_Parameters)
        {

            return Battery_Parameters.Max().ToString();
        }
        public string Find_Minimum(double[] Battery_Parameters)
        {

            return Battery_Parameters.Min().ToString();
        }

        public Tuple<double[], double[]> Read_From_Console()
        {
            int i = 0;
            const int Max_Index = 200;
            string[] Battery_Parameters = new string[Max_Index];
            double[] Battery_SOC_Double = new double[Max_Index];
            double[] Battery_Temperature_Double = new double[Max_Index];
            while (!String.IsNullOrWhiteSpace(Battery_Parameters[i] = Console.ReadLine()))
            {
                string[] Battery_SOC_String = new string[Max_Index];
                string[] Battery_Temperature_String = new string[Max_Index];
                Battery_SOC_String[i] = Battery_Parameters[i].Substring((Battery_Parameters[i].IndexOf("=")) + 1);
                Battery_SOC_Double[i] = Double.Parse(Battery_SOC_String[i]);
                i = i + 1;
                Battery_Parameters[i] = Console.ReadLine();
                Battery_Temperature_String[i] = Battery_Parameters[i].Substring((Battery_Parameters[i].IndexOf("=")) + 1);
                Battery_Temperature_Double[i - 1] = Double.Parse(Battery_Temperature_String[i]);

            }
            return Tuple.Create(Battery_SOC_Double, Battery_Temperature_Double);
        }



        public Tuple<double[], double[]> Battery_Data_Format_Converter(Tuple<double[], double[]> Stream_Line_Sender_Data)
        {
            double[] Battery_SOC_Double_Formatted = new double[50];
            double[] Battery_Temperature_Double_Formatted = new double[50];
            for (int i = 0; i <= 49; i++)
            {
                Battery_SOC_Double_Formatted[i] = Stream_Line_Sender_Data.Item1[i];
                Battery_Temperature_Double_Formatted[i] = Stream_Line_Sender_Data.Item2[i];
            }
            return Tuple.Create(Battery_SOC_Double_Formatted, Battery_Temperature_Double_Formatted);
        }

        public string[] Commad_Line_Interface()
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.StandardInput.WriteLine("Sender_Production_Code|Receiver_Read_From_Console_Mock");        
            process.StandardInput.Flush();
            process.StandardInput.Close();            
            int i = 0;
            const int Max_Index = 200;
            string[] Battery_Parameters = new string[Max_Index];          
            
            while (!process.StandardOutput.EndOfStream)
            {
                Battery_Parameters[i] = process.StandardOutput.ReadLine();
                
              
                           
                i = i + 1;
                

            }
            
            process.WaitForExit();
           
            return Battery_Parameters;
        }


    }
}
