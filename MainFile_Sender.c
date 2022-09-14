#include <stdio.h>
#include <assert.h>
#include "DataFromSensor.h"
int Sensor1_Data[50];
int main()
{ 
  for(int Data=50;Data>=0;Data--)
  {
    Sensor1_Data[Data] = Sensor1DataAlgorithm(Data);
  }
  for (int Data2=50;Data2>=0;Data2--) 
  {
    printf("Element[%d] = %d\n", Data2, Sensor1_Data[Data2]);
  }
}
