using System;

class Program
{
    static void Main(string[] args)
    {
        int fanspeed;
        char oscillateoption;
        int basefanpower = 10;

        do
        {
            Console.WriteLine("Enter fan speed (1, 2, or 3):");
        } while (!int.TryParse(Console.ReadLine(), out fanspeed) || fanspeed < 1 || fanspeed > 3);

        do
        {
            Console.WriteLine("Do you want to oscillate? (Y/N):");
        } while (!char.TryParse(Console.ReadLine(), out oscillateoption) || (oscillateoption != 'Y' && oscillateoption != 'N'));

        int fanpoweroutput = basefanpower * fanspeed;

        if (oscillateoption == 'Y')
        {
            OscillateOutput(basefanpower, fanspeed);
        }
        else
        {
            SteadyOutput(fanpoweroutput);
        }
    }

    static void OscillateOutput(int basefanpower, int fanspeed)
    {
        for (int i = 1; i <= basefanpower; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                for (int x = 1; x <= fanspeed; x++)
                {
                    Console.Write("~");
                }
            }
            Console.WriteLine();
        }

        for (int i = basefanpower; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                for (int x = 1; x <= fanspeed; x++)
                {
                    Console.Write("~");
                }
            }
            Console.WriteLine();
        }
    }

    static void SteadyOutput(int fanpoweroutput)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(new string('~', fanpoweroutput));
        }
    }
}
