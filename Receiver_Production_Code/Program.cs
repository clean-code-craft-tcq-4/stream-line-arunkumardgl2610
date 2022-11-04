using System;
using System.Linq;

namespace Receiver_Production_Code
{
    class Program
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
            string[] Battery_Parameters = new string[200];
            double[] Battery_SOC_Double = new double[200];
            double[] Battery_Temperature_Double = new double[200];
            while (!String.IsNullOrWhiteSpace(Battery_Parameters[i] = Console.ReadLine()))
            {
                string[] Battery_SOC_String = new string[200];
                string[] Battery_Temperature_String = new string[200];
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

            Receiver_Production_Code.Program InstanceProgram = new Receiver_Production_Code.Program();

            string[] Battery_Parameters = new string[200];
            double[] Battery_SOC_Double = new double[200];
            double[] Battery_Temperature_Double = new double[200];
            double[] Battery_SOC_Double_Formatted = new double[50];
            double[] Battery_Temperature_Double_Formatted = new double[50];
            int i = 0;

            Tuple<double[], double[]> Stream_Line_Sender_Data = InstanceProgram.Read_From_Console();
            Battery_SOC_Double = Stream_Line_Sender_Data.Item1;
            Battery_Temperature_Double = Stream_Line_Sender_Data.Item2;

            Tuple<double[], double[]> Stream_Line_Formatted_Data = InstanceProgram.Battery_Data_Format_Converter(Stream_Line_Sender_Data);

            Battery_SOC_Double_Formatted = Stream_Line_Formatted_Data.Item1;
            Battery_Temperature_Double_Formatted = Stream_Line_Formatted_Data.Item2;

            string Average = InstanceProgram.Find_Average(Battery_SOC_Double_Formatted);
            string Maximum = InstanceProgram.Find_Maximum(Battery_SOC_Double_Formatted);
            string Minimum = InstanceProgram.Find_Minimum(Battery_SOC_Double_Formatted);

            InstanceProgram.Print_On_Console("The Minimum value of the Battery SOC is " + Minimum);
            InstanceProgram.Print_On_Console("The Maximum value of the Battery SOC is " + Maximum);
            InstanceProgram.Print_On_Console("The Simple moving average of last 5 values of Battery SOC is " + Average);

            Average = InstanceProgram.Find_Average(Battery_Temperature_Double_Formatted);
            Maximum = InstanceProgram.Find_Maximum(Battery_Temperature_Double_Formatted);
            Minimum = InstanceProgram.Find_Minimum(Battery_Temperature_Double_Formatted);

            InstanceProgram.Print_On_Console("The Minimum value of the Battery Temperature is " + Minimum);
            InstanceProgram.Print_On_Console("The Maximum value of the Battery Temperature is " + Maximum);
            InstanceProgram.Print_On_Console("The Simple moving average of last 5 values of Battery Temperature is " + Average);

        }
    }
}
