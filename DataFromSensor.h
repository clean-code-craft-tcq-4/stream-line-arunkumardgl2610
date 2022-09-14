#include <stdio.h>
#define Battery_Internal_Resistance 10
int Battery_Health=0;
float Battery_voltage=0;
int Sensor1DataAlgorithm(int Battery_Capacity)
{
  Battery_Health = (Battery_Capacity*Battery_Internal_Resistance/5); 
}

float Sensor2DataAlgorithm(float Battery_SOC)
{
  Battery_voltage = (Battery_SOC*0.18)+63;
    return Battery_voltage;
}
