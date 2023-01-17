using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace electricity_calculator.src.MenuNavigation
{
  public class ElectricalConvert
  {
    public float ConvertVoltage(ElectricalCalculator calculate)
    {
      Console.WriteLine("Input Current (A)");
      string userInput = Console.ReadLine();
      float userCurrent = float.Parse(userInput);

      Console.WriteLine("Input Resistance (Ohms)");
      userInput = Console.ReadLine();
      float userResistance = float.Parse(userInput);

      return calculate.CalculateVoltage(userCurrent, userResistance);
    }

    public float ConvertCurrent(ElectricalCalculator calculate)
    {
      Console.WriteLine("Input Voltage (V)");
      string userInput = Console.ReadLine();
      float userCurrent = float.Parse(userInput);

      Console.WriteLine("Input Resistance (Ohms)");
      userInput = Console.ReadLine();
      float userResistance = float.Parse(userInput);

      return calculate.CalculateCurrent(userCurrent, userResistance);
    }

    public float ConvertWattage(ElectricalCalculator calculate)
    {
      Console.WriteLine("Input Voltage (V)");
      string userInput = Console.ReadLine();
      float userCurrent = float.Parse(userInput);

      Console.WriteLine("Input Current (A)");
      userInput = Console.ReadLine();
      float userResistance = float.Parse(userInput);

      return calculate.CalculateWattage(userCurrent, userResistance);
    }
    public float ConvertResistor(ElectricalCalculator calculate)
    {
      Console.WriteLine("Input Battery Voltage (V)");
      string userInput = Console.ReadLine();
      float userBatteryVoltage = float.Parse(userInput);

      Console.WriteLine("Input Current LED Voltage(A)");
      userInput = Console.ReadLine();
      float userLEDVoltage = float.Parse(userInput);

      Console.WriteLine("Input Ideal LED Voltage(A)");
      userInput = Console.ReadLine();
      float userLedCurrent = float.Parse(userInput);

      return calculate.CalculateResistor(userBatteryVoltage, userLEDVoltage, userLedCurrent);
    }
  }
}
