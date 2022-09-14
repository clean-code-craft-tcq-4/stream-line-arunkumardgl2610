#include <stdio.h>
#include <assert.h>
#include "DataFromSensor.h"
int Sensor1_Data[50];
int main()
{ 
  DataReceiveFromSensor1();
  for (int Data2=50;Data2<=0;Data2--) 
    {
      printf("Element[%d] = %d\n", Data2, Sensor1_Data[Data2]);
      Data2 = Data2-1;
   }
}
