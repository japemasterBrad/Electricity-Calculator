namespace electricity_calculator.src
{
  public class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("What do you want to convert?");
      string userInput = Console.ReadLine();

      if (userInput == "1")
      {
        ConvertVoltage();
      }
      else if (userInput == "2")
      {
        ConvertCurrent();
      }
      else if (userInput == "3")
      {
        ConvertWattage();
      }
    }
    
    private static void ConvertVoltage()
    {
      Console.WriteLine("Input Current (A)");
      string userInput = Console.ReadLine();
      float userCurrent = Int64.Parse(userInput);

      Console.WriteLine("Input Resistance (Ohms)");
      userInput = Console.ReadLine();
      float userResistance = Int64.Parse(userInput);

      Console.WriteLine(CalculateVolts(userCurrent, userResistance));
    }

    private static void ConvertCurrent()
    {
      Console.WriteLine("Input Voltage (V)");
      string userInput = Console.ReadLine();
      float userCurrent = Int64.Parse(userInput);

      Console.WriteLine("Input Resistance (Ohms)");
      userInput = Console.ReadLine();
      float userResistance = Int64.Parse(userInput);

      Console.WriteLine(CalculateCurrent(userCurrent, userResistance));
    }

    private static void ConvertWattage()
    {
      Console.WriteLine("Input Voltage (V)");
      string userInput = Console.ReadLine();
      float userCurrent = Int64.Parse(userInput);

      Console.WriteLine("Input Current (A)");
      userInput = Console.ReadLine();
      float userResistance = Int64.Parse(userInput);

      Console.WriteLine(CalculateWattage(userCurrent, userResistance));
    }

    private static float CalculateWattage(float voltage, float current)
    {
      Electricity electricity = new Electricity();
      electricity.Current = current;
      electricity.Voltage = voltage;

      return electricity.Current * electricity.Resistance;
    }

    private static float CalculateCurrent(float current, float resistance)
    {
      Electricity electricity = new Electricity();
      electricity.Current = current;
      electricity.Resistance = resistance;

      return electricity.Current / electricity.Resistance;
      
    }

    public static float CalculateVolts(float current, float resistance)
    {
      Electricity electricity = new Electricity();
      electricity.Current = current;
      electricity.Resistance = resistance;
      
      return electricity.Current * electricity.Resistance;
    }
  }
}