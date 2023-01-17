namespace electricity_calculator.src
{
  public class ElectricalCalculator
  {
    public float CalculateVoltage(float current, float resistance)
    {
      Electricity electricity = new Electricity();
      electricity.Current = current;
      electricity.Resistance = resistance;

      return electricity.Current * electricity.Resistance;
    }

    public float CalculateCurrent(float current, float resistance)
    {
      Electricity electricity = new Electricity();
      electricity.Current = current;
      electricity.Resistance = resistance;

      return electricity.Current / electricity.Resistance;
    }

    public float CalculateWattage(float voltage, float current)
    {
      Electricity electricity = new Electricity();
      electricity.Voltage = voltage;
      electricity.Current = current;

      return electricity.Voltage * electricity.Current;
    }

    public float CalculateResistor(float powerVoltage, float ledVoltage, float desiredLEDCurrent)
    {
      Electricity electricity = new Electricity();
      electricity.Voltage = powerVoltage;
      electricity.LEDVoltage = ledVoltage;
      electricity.LEDCurrent = desiredLEDCurrent;

      return (electricity.Voltage - electricity.LEDVoltage) / electricity.LEDCurrent;
    }
  }
}
