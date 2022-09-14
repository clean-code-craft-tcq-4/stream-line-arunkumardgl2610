#include <stdio.h>
int Battery_Health=0,Battery_Internal_Resistance;
int Sensor1DataAlgorithm(int Battery_Capacity)
{
  Battery_Internal_Resistance = (Battery_Capacity/5);
  Battery_Health = (Battery_Internal_Resistance*10);
  return Battery_Health;
}
