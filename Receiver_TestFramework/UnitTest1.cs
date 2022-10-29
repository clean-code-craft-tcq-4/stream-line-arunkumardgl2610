using System;
using System.Diagnostics;
using Xunit;

namespace Receiver_TestFramework
{
    public class UnitTest1
    {

        Receiver_TestFramework.Receiver_Data InstanceReceiver_Data = new Receiver_TestFramework.Receiver_Data();
        double[] TestArray_1 = new double[10] { 1, 2, 3, 4, 6, 5, 7, 8, 9, 10 };
        double[] TestArray_2 = new double[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        double[] TestArray_3 = new double[10] { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };
        double[] TestArray_4 = new double[10] { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 };
        double[] TestArray_5 = new double[10] { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 };
        double[] TestArray_6 = new double[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        double[] TestArray_7 = new double[5] { 1, 2, 3, 4, 5 };
        
        string[] Expected_Results_Average = new string[7] {"7.8","1", "2", "3", "4","0","3" };
        string[] Expected_Results_Max = new string[7] { "10","1", "2", "3", "4","0","5" };
        string[] Expected_Results_Min = new string[7] {"1","1", "2", "3", "4","0","1"};


        [Fact]
        public void TestMethod_Read_From_Console()

        {






        }



        [Fact]
        public void TestMethod_Find_Average()

        {       
           Assert.Equal(InstanceReceiver_Data.Find_Average(TestArray_1),Expected_Results_Average[0]);
           Assert.Equal(InstanceReceiver_Data.Find_Average(TestArray_2),Expected_Results_Average[1]);        
           Assert.Equal(InstanceReceiver_Data.Find_Average(TestArray_3),Expected_Results_Average[2);
           Assert.Equal(InstanceReceiver_Data.Find_Average(TestArray_4),Expected_Results_Average[3]);
           Assert.Equal(InstanceReceiver_Data.Find_Average(TestArray_5),Expected_Results_Average[4]);
           Assert.Equal(InstanceReceiver_Data.Find_Average(TestArray_6),Expected_Results_Average[5]);
           Assert.Equal(InstanceReceiver_Data.Find_Average(TestArray_7),Expected_Results_Average[6]);

        }

        [Fact]
        public void TestMethod_Find_Maximum()

        {                    
            Assert.Equal(InstanceReceiver_Data.Find_Maximum(TestArray_1),Expected_Results_Max[0]);
            Assert.Equal(InstanceReceiver_Data.Find_Maximum(TestArray_2),Expected_Results_Max[1]);
            Assert.Equal(InstanceReceiver_Data.Find_Maximum(TestArray_3),Expected_Results_Max[2]);
            Assert.Equal(InstanceReceiver_Data.Find_Maximum(TestArray_4),Expected_Results_Max[3]);
            Assert.Equal(InstanceReceiver_Data.Find_Maximum(TestArray_5),Expected_Results_Max[4]);
            Assert.Equal(InstanceReceiver_Data.Find_Maximum(TestArray_6),Expected_Results_Max[5]);
            Assert.Equal(InstanceReceiver_Data.Find_Maximum(TestArray_7),Expected_Results_Max[6]);

        }

        [Fact]
        public void TestMethod_Find_Minimum()

        {
            Assert.Equal(InstanceReceiver_Data.Find_Minimum(TestArray_1) , Expected_Results_Min[0]);
            Assert.Equal(InstanceReceiver_Data.Find_Minimum(TestArray_2),Expected_Results_Min[1]);
            Assert.Equal(InstanceReceiver_Data.Find_Minimum(TestArray_3) ,Expected_Results_Min[2]);
            Assert.Equal(InstanceReceiver_Data.Find_Minimum(TestArray_4) ,Expected_Results_Min[3]);
            Assert.Equal(InstanceReceiver_Data.Find_Minimum(TestArray_5) , Expected_Results_Min[4]);
            Assert.Equal(InstanceReceiver_Data.Find_Minimum(TestArray_6) , Expected_Results_Min[5]);
            Assert.Equal(InstanceReceiver_Data.Find_Minimum(TestArray_7) , Expected_Results_Min[6]);

        }






    }

    }
