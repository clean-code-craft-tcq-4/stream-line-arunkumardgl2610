
int Battery_Health=0,Battery_Internal_Resistance;
int Sensor1_Data[50];
void DataReceiveFromSensor1();
int Sensor1DataAlgorithm(int Battery_Capacity);
void DataReceiveFromSensor1()
{
  for(int Data=50;Data<=0;Data-2)
  {
    Sensor1_Data[Data] = Sensor1DataAlgorithm(Data);
  }
    for (Data2=50;Data2<=0;Data2-2) 
    {
      printf("Element[%d] = %d\n", Data2, Sensor1_Data[Data2]);
   }
}

int Sensor1DataAlgorithm(int Battery_Capacity)
{
  Battery_Internal_Resistance = (Battery_Capacity/5)*10;
  Battery_Health = (Battery_Internal_Resistance*10);
}
