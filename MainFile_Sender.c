#include <stdio.h>
#include <assert.h>
#include "DataFromSensor.h"
int Sensor1_Data[50];
float Sensor2_Data[50];
int main()
{ 
  for(int Data=50;Data>=0;Data--)
  {
    Sensor1_Data[Data] = Sensor1DataAlgorithm(Data);
  }
  for(int Data4=100;Data4>=50;Data4--)
  {
    Sensor2_Data[Data4] = Sensor2DataAlgorithm(Data4);
  }
  for (int Data2=50;Data2>=0;Data2--) 
  {
    printf("Element[%d] = %d\n", Data2, Sensor1_Data[Data2]);
  }
    for (int Data5=50;Data5>=0;Data5--) 
  {
    printf("Element[%d] = %f\n", Data5, Sensor2_Data[Data5]);
  }
}
