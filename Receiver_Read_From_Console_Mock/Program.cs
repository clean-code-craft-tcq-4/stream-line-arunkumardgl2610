using System;
using System.Diagnostics;

namespace Receiver_Read_From_Console_Mock
{
    internal class Program
    {
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
        static void Main(string[] args)
        {
            Receiver_Read_From_Console_Mock.Program InstanceProgram = new Receiver_Read_From_Console_Mock.Program();
            Tuple<double[], double[]> Stream_Line_Mock_Unformated_Data_Mock=InstanceProgram.Read_From_Console();
            Tuple<double[], double[]> Stream_Line_Mock_formated_Data_Mock=InstanceProgram.Battery_Data_Format_Converter(Stream_Line_Mock_Unformated_Data_Mock);

            for (int i=0;i<= Stream_Line_Mock_formated_Data_Mock.Item1.Length-1;i++)
            {
                Console.WriteLine(Stream_Line_Mock_formated_Data_Mock.Item1[i].ToString());

            }

            for (int j = 0; j <= Stream_Line_Mock_formated_Data_Mock.Item2.Length - 1; j++)
            {
               Console.WriteLine(Stream_Line_Mock_formated_Data_Mock.Item2[j].ToString());

            }



        }
    }
}
