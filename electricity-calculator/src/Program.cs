using electricity_calculator.src.MenuNavigation;

namespace electricity_calculator.src
{
  public class Program
  {
    static void Main(string[] args)
    {
      ElectricalConvert convert = new ElectricalConvert();
      ElectricalCalculator calculate = new ElectricalCalculator();
      bool running = true;

      while (running = true)
      {
        Console.Clear();
        Console.WriteLine("1) Calculate Voltage");
        Console.WriteLine("2) Calculate Current");
        Console.WriteLine("3) Calculate Wattage");
        Console.WriteLine("4) Calculate Resistor");
        Console.WriteLine("\nE to Exit");
        Console.WriteLine("\nWhat do you want to convert?");
        string userInput = Console.ReadLine();

        if (userInput == "1")
        {
          Console.WriteLine($"Calculated Voltage: {convert.ConvertVoltage(calculate)} v");
        }
        else if (userInput == "2")
        {
          Console.WriteLine($"Calculated Current: {convert.ConvertCurrent(calculate)} A");
        }
        else if (userInput == "3")
        {
          Console.WriteLine($"Calculated Wattage: {convert.ConvertWattage(calculate)} w");
        }
        else if (userInput == "4")
        {
          Console.WriteLine($"Calculated Wattage: {convert.ConvertResistor(calculate)} Ohms");
        }
        else if ((userInput == "e") || (userInput == "E"))
        {
          running = false;
          Environment.Exit(0);
        }

        Console.WriteLine("Hit ENTER to restart");
        Console.ReadLine();
      }
    }
  }
}