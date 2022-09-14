#include"
int Battery_Health=0,Battery_Internal_Resistance;
int Sensor1_Data[50];

Void DataReceiveFromSensor1(int data1)
{
  for(int Data=50;Data<=0;Data-2)
  {
    Sensor1_Data[Data] = Sensor1DataAlgorithm(Data);
  }
}

int Sensor1DataAlgorithm(int Battery_Capacity)
{
  Battery_Internal_Resistance = (Battery_Capacity/5)*10;
  Battery_Health = (Battery_Internal_Resistance*10);
}
