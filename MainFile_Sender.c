#include <stdio.h>
#include <assert.h>
#include "DataFromSensor.h"
int Battery_Health_sensor1[50];
float Battery_Voltage_sensor2[50];
int main()
{ 
  for(int SOC=50; SOC>=0; SOC--)
  {
    Battery_Health_sensor1[SOC] = Sensor1DataCreateAlgorithm(SOC);
    Battery_Voltage_sensor2[SOC] = Sensor2DataCreateAlgorithm(SOC);
    printf("Battery_Health @SOC_%d% = %d\n", SOC, Battery_Health_sensor1[SOC]);
    printf("Battery_Voltage @SOC_%d% = %f\n", SOC, Battery_Voltage_sensor2[SOC]);
  }
}
