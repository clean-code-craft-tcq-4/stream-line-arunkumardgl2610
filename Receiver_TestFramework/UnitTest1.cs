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

        [Fact]
        public void TestMethod_Read_From_Console()

        {






        }



        [Fact]
        public void TestMethod_Find_Average()

        {       
            Debug.Assert(InstanceReceiver_Data.Find_Average(TestArray_1) == "7.8");
            Debug.Assert(InstanceReceiver_Data.Find_Average(TestArray_2) == "1");        
            Debug.Assert(InstanceReceiver_Data.Find_Average(TestArray_3) == "2");
            Debug.Assert(InstanceReceiver_Data.Find_Average(TestArray_4) == "3");
            Debug.Assert(InstanceReceiver_Data.Find_Average(TestArray_5) == "4");
            Debug.Assert(InstanceReceiver_Data.Find_Average(TestArray_6) == "0");
            Debug.Assert(InstanceReceiver_Data.Find_Average(TestArray_7) == "3");

        }

        [Fact]
        public void TestMethod_Find_Maximum()

        {                    
            Debug.Assert(InstanceReceiver_Data.Find_Maximum(TestArray_1) == "10");
            Debug.Assert(InstanceReceiver_Data.Find_Maximum(TestArray_2) == "1");
            Debug.Assert(InstanceReceiver_Data.Find_Maximum(TestArray_3) == "2");
            Debug.Assert(InstanceReceiver_Data.Find_Maximum(TestArray_4) == "3");
            Debug.Assert(InstanceReceiver_Data.Find_Maximum(TestArray_5) == "4");
            Debug.Assert(InstanceReceiver_Data.Find_Maximum(TestArray_6) == "0");
            Debug.Assert(InstanceReceiver_Data.Find_Maximum(TestArray_7) == "5");

        }

        [Fact]
        public void TestMethod_Find_Minimum()

        {
            Debug.Assert(InstanceReceiver_Data.Find_Minimum(TestArray_1) == "1");
            Debug.Assert(InstanceReceiver_Data.Find_Minimum(TestArray_2) == "1");
            Debug.Assert(InstanceReceiver_Data.Find_Minimum(TestArray_3) == "2");
            Debug.Assert(InstanceReceiver_Data.Find_Minimum(TestArray_4) == "3");
            Debug.Assert(InstanceReceiver_Data.Find_Minimum(TestArray_5) == "4");
            Debug.Assert(InstanceReceiver_Data.Find_Minimum(TestArray_6) == "0");
            Debug.Assert(InstanceReceiver_Data.Find_Minimum(TestArray_7) == "1");

        }






    }

    }
