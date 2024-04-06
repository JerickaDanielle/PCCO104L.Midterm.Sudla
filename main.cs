using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Fan Speed: (1, 2, or 3): ");
        int fanSpeed = GetFanSpeed();

        Console.WriteLine("Oscilliate Fan? (Y/N): ");
        char oscillateOption = GetOscillateOption();

        int baseFanPower = 10;
        int fanPowerOutput = baseFanPower * fanSpeed;

        if (oscillateOption == 'Y')
        {
            DisplayOscillatingFanOutput(fanSpeed, fanPowerOutput);
        }
        else
        {
            DisplayNonOscillatingFanOutput(fanPowerOutput);
        }
    }

    static int GetFanSpeed()
    {
        int speed;
        while (true)
        {
            if (!int.TryParse(Console.ReadLine(), out speed) || speed < 1 || speed > 3)
            {
                Console.WriteLine("Invalid input! Please enter a valid fan speed (1, 2, or 3): ");
            }
            else
            {
                return speed;
            }
        }
    }

    static char GetOscillateOption()
    {
        char option;
        while (true)
        {
            if (!char.TryParse(Console.ReadLine(), out option) || (option != 'Y' && option != 'N'))
            {
                Console.WriteLine("Invalid input! Please enter 'Y' or 'N': ");
            }
            else
            {
                return char.ToUpper(option);
            }
        }
    }

    static void DisplayOscillatingFanOutput(int fanSpeed, int fanPowerOutput)
    {
        for (int i = fanSpeed; i <= fanPowerOutput; i += fanSpeed)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("~");
            }
            Console.WriteLine();
        }

        for (int i = fanPowerOutput - fanSpeed; i > 0; i -= fanSpeed)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("~");
            }
            Console.WriteLine();
        }
    }

    static void DisplayNonOscillatingFanOutput(int fanPowerOutput)
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < fanPowerOutput; j++)
            {
                Console.Write("~");
            }
            Console.WriteLine();
        }
    }
}
