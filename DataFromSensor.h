#include <stdio.h>
#define Battery_Internal_Resistance 10
int Battery_Health=0;
int Sensor1DataAlgorithm(int Battery_Capacity)
{
  Battery_Health = (Battery_Capacity*Battery_Internal_Resistance/5); 
}
