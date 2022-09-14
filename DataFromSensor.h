#include <stdio.h>
#define Battery_Internal_Resistance 10
#define Low_Battery_Voltage 63
#define B_Health_MultiplicationFactor 5
#define B_Voltage_MultiplicationFactor 0.18

int Battery_Health=0;
float Battery_voltage=0;

int Sensor1DataCreateAlgorithm(int Battery_Capacity)
{
  Battery_Health = (Battery_Capacity*Battery_Internal_Resistance/B_Health_MultiplicationFactor); 
}

float Sensor2DataCreateAlgorithm(float Battery_SOC)
{
  Battery_voltage = (Battery_SOC*B_Voltage_MultiplicationFactor)+Low_Battery_Voltage;
  return Battery_voltage;
}
