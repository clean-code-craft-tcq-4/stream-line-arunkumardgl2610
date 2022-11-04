using System;
using System.Collections.Generic;
using System.Text;

namespace Receiver_TestFramework
{
    internal class Reciever_Data_Analysis
    {
        void Main_Method()
        {
            const int Max_Index = 200;
            Receiver_TestFramework.Receiver_Data InstanceReceiver_Data = new Receiver_TestFramework.Receiver_Data();

            string[] Battery_Parameters = new string[Max_Index];
            double[] Battery_SOC_Double = new double[Max_Index];
            double[] Battery_Temperature_Double = new double[Max_Index];
            double[] Battery_SOC_Double_Formatted = new double[50];
            double[] Battery_Temperature_Double_Formatted = new double[50];


            Tuple<double[], double[]> Stream_Line_Sender_Data = InstanceReceiver_Data.Read_From_Console();
            Battery_SOC_Double = Stream_Line_Sender_Data.Item1;
            Battery_Temperature_Double = Stream_Line_Sender_Data.Item2;

            Tuple<double[], double[]> Stream_Line_Formatted_Data = InstanceReceiver_Data.Battery_Data_Format_Converter(Stream_Line_Sender_Data);

            Battery_SOC_Double_Formatted = Stream_Line_Formatted_Data.Item1;
            Battery_Temperature_Double_Formatted = Stream_Line_Formatted_Data.Item2;

            string Average = InstanceReceiver_Data.Find_Average(Battery_SOC_Double_Formatted);
            string Maximum = InstanceReceiver_Data.Find_Maximum(Battery_SOC_Double_Formatted);
            string Minimum = InstanceReceiver_Data.Find_Minimum(Battery_SOC_Double_Formatted);

            InstanceReceiver_Data.Print_On_Console("The Minimum value of the Battery SOC is " + Minimum);
            InstanceReceiver_Data.Print_On_Console("The Maximum value of the Battery SOC is " + Maximum);
            InstanceReceiver_Data.Print_On_Console("The Simple moving average of last 5 values of Battery SOC is " + Average);

            Average = InstanceReceiver_Data.Find_Average(Battery_Temperature_Double_Formatted);
            Maximum = InstanceReceiver_Data.Find_Maximum(Battery_Temperature_Double_Formatted);
            Minimum = InstanceReceiver_Data.Find_Minimum(Battery_Temperature_Double_Formatted);

            InstanceReceiver_Data.Print_On_Console("The Minimum value of the Battery Temperature is " + Minimum);
            InstanceReceiver_Data.Print_On_Console("The Maximum value of the Battery Temperature is " + Maximum);
            InstanceReceiver_Data.Print_On_Console("The Simple moving average of last 5 values of Battery Temperature is " + Average);

        }
    }
}
