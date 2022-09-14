#include <stdio.h>
int Battery_Internal_Resistance;
int Battery_Health=0,
int Sensor1DataAlgorithm(int Battery_Capacity)
{
  Battery_Internal_Resistance = (Battery_Capacity*10/5);
  Battery_Health = Battery_Internal_Resistance;
  return Battery_Health;
}
