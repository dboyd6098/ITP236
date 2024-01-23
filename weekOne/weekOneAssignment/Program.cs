namespace weekOneAssignment
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using static System.Console;
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome to Fun with Temperatures!");
            WriteLine();
            WriteLine("Enter five temperatures, one at a time.  Then choose to calculate the average temperature, or convert them all from Fahrenheit to Celsius.");
            WriteLine();

            int[] temps = new int[5];

            for (int t = 0; t < temps.Length;)
            {
                WriteLine("Enter temperature number " + (t + 1));
                if (int.TryParse(ReadLine(), out int temperature))
                {
                    temps[t] = temperature;
                    t++;
                }
                else
                {
                    WriteLine("You didn't enter a numeric temperature.  Pease enter a temperature in the form of a number.");    
                }
                
            }

            string inputChoice;
            bool choiceCheck = true;

            do
            {

                WriteLine();
                WriteLine("1. Find the average temperature.");
                WriteLine("2. Convert the temperatures to Celsius.");
                WriteLine();
                Write("Select an option: ");
                inputChoice = ReadLine();

                switch (inputChoice)
                {
                    case "1":
                        double tempOut;
                        averageTemp(temps, out tempOut);
                        WriteLine();
                        WriteLine("The average temperature is " + tempOut + " degrees Fahrenheit.");
                        choiceCheck = true;
                        break;

                    case "2":
                        celciusConversion(temps);
                        choiceCheck = true;
                        break;

                    default:
                        WriteLine("You must enter 1 or 2.");
                        choiceCheck = false;
                        break;
                }
            } while (!choiceCheck);
                ReadKey();

        }//end main

        static void celciusConversion(int[] array)
        {
            for (int t = 0; t < array.Length; t++)
            {
                array[t] = (array[t] - 32) * 5 / 9; 
                WriteLine("Temperature " + (t + 1) + " is " + array[t] + " in Celsius");
            }
        }
        static double averageTemp(int[] array, out double average)
        {
            int sum = 0;

            foreach (int element in array)
            {
                sum += element;
            }

            if (array.Length != 0)
            {
                average = (double)sum / array.Length;
            }
            else
            {
                average = 0.0;
            }

            return average;
        }

    }

}
