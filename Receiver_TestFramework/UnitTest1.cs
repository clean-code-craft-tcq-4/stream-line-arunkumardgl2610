using System;
using System.Diagnostics;
using System.Threading;
using Xunit;

namespace Receiver_TestFramework
{
    public class UnitTest1
    {
        Receiver_TestFramework.Receiver_Data InstanceReceiver_Data = new Receiver_TestFramework.Receiver_Data();
        Receiver_TestFramework.Utilities InstanceUtilities = new Receiver_TestFramework.Utilities();
        double[] TestArray_1 = new double[10] { 1, 2, 3, 4, 6, 5, 7, 8, 9, 10 };
        double[] TestArray_2 = new double[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        double[] TestArray_3 = new double[10] { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };
        double[] TestArray_4 = new double[10] { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 };
        double[] TestArray_5 = new double[10] { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 };
        double[] TestArray_6 = new double[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        double[] TestArray_7 = new double[5] { 1, 2, 3, 4, 5 };

        string[] Expected_Results_Average = new string[7] { "7.8", "1", "2", "3", "4", "0", "3" };
        string[] Expected_Results_Max = new string[7] { "10", "1", "2", "3", "4", "0", "5" };
        string[] Expected_Results_Min = new string[7] { "1", "1", "2", "3", "4", "0", "1" };

        [Fact]
        public void TestMethod_Read_From_Console()

        {

            double[] Battery_SOC_Double = new double[200];
            double[] Battery_Temperature_Double = new double[200];
            string[] output = InstanceReceiver_Data.Commad_Line_Interface();
     
            int Temp_Index=0, SOC_Index=0, i = 0, j = 0;


            for (Temp_Index = 4; Temp_Index <= 52; Temp_Index++)
            {

                double Battery_Temperature_Actual = Double.Parse(output[Temp_Index]);
                double Battery_Temperature_Expected = Double.Parse(InstanceUtilities.Stream_Line_Expected_Battery_Temperature_Data[i]);

                Assert.Equal(Battery_Temperature_Actual, Battery_Temperature_Expected);
                i = i + 1;
            }

            for (SOC_Index = 54; SOC_Index <= 102; SOC_Index++)
            { 
                double Battery_SOC_Actual = Double.Parse(output[SOC_Index]);

                double Battery_SOC_Expected = Double.Parse(InstanceUtilities.Stream_Line_Expected_Battery_SOC_Data[j]);
            
                Assert.Equal(Battery_SOC_Actual, Battery_SOC_Expected);
                j = j + 1;

            }
        }
        [Fact]
        public void TestMethod_Find_Average()

        {
            Assert.Equal(InstanceReceiver_Data.Find_Average(TestArray_1), Expected_Results_Average[0]);
            Assert.Equal(InstanceReceiver_Data.Find_Average(TestArray_2), Expected_Results_Average[1]);
            Assert.Equal(InstanceReceiver_Data.Find_Average(TestArray_3), Expected_Results_Average[2]);
            Assert.Equal(InstanceReceiver_Data.Find_Average(TestArray_4), Expected_Results_Average[3]);
            Assert.Equal(InstanceReceiver_Data.Find_Average(TestArray_5), Expected_Results_Average[4]);
            Assert.Equal(InstanceReceiver_Data.Find_Average(TestArray_6), Expected_Results_Average[5]);
            Assert.Equal(InstanceReceiver_Data.Find_Average(TestArray_7), Expected_Results_Average[6]);

        }

        [Fact]
        public void TestMethod_Find_Maximum()

        {
            Assert.Equal(InstanceReceiver_Data.Find_Maximum(TestArray_1), Expected_Results_Max[0]);
            Assert.Equal(InstanceReceiver_Data.Find_Maximum(TestArray_2), Expected_Results_Max[1]);
            Assert.Equal(InstanceReceiver_Data.Find_Maximum(TestArray_3), Expected_Results_Max[2]);
            Assert.Equal(InstanceReceiver_Data.Find_Maximum(TestArray_4), Expected_Results_Max[3]);
            Assert.Equal(InstanceReceiver_Data.Find_Maximum(TestArray_5), Expected_Results_Max[4]);
            Assert.Equal(InstanceReceiver_Data.Find_Maximum(TestArray_6), Expected_Results_Max[5]);
            Assert.Equal(InstanceReceiver_Data.Find_Maximum(TestArray_7), Expected_Results_Max[6]);

        }

        [Fact]
        public void TestMethod_Find_Minimum()

        {
            Assert.Equal(InstanceReceiver_Data.Find_Minimum(TestArray_1), Expected_Results_Min[0]);
            Assert.Equal(InstanceReceiver_Data.Find_Minimum(TestArray_2), Expected_Results_Min[1]);
            Assert.Equal(InstanceReceiver_Data.Find_Minimum(TestArray_3), Expected_Results_Min[2]);
            Assert.Equal(InstanceReceiver_Data.Find_Minimum(TestArray_4), Expected_Results_Min[3]);
            Assert.Equal(InstanceReceiver_Data.Find_Minimum(TestArray_5), Expected_Results_Min[4]);
            Assert.Equal(InstanceReceiver_Data.Find_Minimum(TestArray_6), Expected_Results_Min[5]);
            Assert.Equal(InstanceReceiver_Data.Find_Minimum(TestArray_7), Expected_Results_Min[6]);

        }

    }

}