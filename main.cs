using System;

class Program
{
    public static void DisplayOscillateOutput(int fanPowerOutput)
    {
        for (int i = 1; i <= fanPowerOutput; i++)
        {
            Console.WriteLine(new string('~', Math.Min(fanPowerOutput, i)));
        }
        for (int i = fanPowerOutput - 1; i >= 1; i--)
        {
            Console.WriteLine(new string('~', Math.Min(fanPowerOutput, i)));
        }
    }
    static void DisplaySteadyOutput(int fanPowerOutput)
    {
        for (int i = 1; i <= fanPowerOutput; i++)
        {
            Console.WriteLine(new string('~', fanPowerOutput));
        }
        for (int i = fanPowerOutput - 1; i >= 1; i--)
        {
            Console.WriteLine(new string('~', fanPowerOutput));
        }
    }
    static void Main()
    {
        int baseFanPower = 10;

        int fanSpeed;
        do
        {
            Console.Write("Enter fan speed (1, 2, or 3): ");
        } while (!int.TryParse(Console.ReadLine(), out fanSpeed) || fanSpeed < 1 || fanSpeed > 3);

        string oscillateOption;
        do
        {
            Console.Write("Enter oscillate option (Y or N): ");
            oscillateOption = Console.ReadLine().ToUpper();
        } while (oscillateOption != "Y" && oscillateOption != "N");

        int fanPowerOutput = baseFanPower * fanSpeed;

        if (oscillateOption == "Y")
        {
            DisplayOscillateOutput(fanPowerOutput);
        }
        else
        {
            DisplaySteadyOutput(fanPowerOutput);
        }
    }
}