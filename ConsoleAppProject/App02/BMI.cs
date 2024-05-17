using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>


    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("BMI Calculator");
            Console.WriteLine("==============");
            Console.WriteLine("This application calculates your Body Mass Index (BMI) and provides an interpretation based on WHO weight status guidelines.");
            Console.WriteLine();

            Console.WriteLine("Choose input units:");
            Console.WriteLine("1. Metric (weight in kilograms, height in meters)");
            Console.WriteLine("2. Imperial (weight in stones and pounds, height in feet and inches)");
            Console.Write("Enter your choice (1/2): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            double weight, height;
            switch (choice)
            {
                case 1:
                    weight = GetInput("Enter your weight in kilograms: ");
                    height = GetInput("Enter your height in meters: ");
                    break;
                case 2:
                    weight = ConvertToKg(GetInput("Enter your weight in stones: "), GetInput("Enter your weight in pounds: "));
                    height = ConvertToMeters(GetInput("Enter your height in feet: "), GetInput("Enter your height in inches: "));
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            double bmi = CalculateBMI(weight, height);
            string interpretation = InterpretBMI(bmi);

            Console.WriteLine($"Your BMI is: {bmi:F2}");
            Console.WriteLine($"WHO Weight Status: {interpretation}");

            if (interpretation.StartsWith("Obese"))
            {
                Console.WriteLine("Note: There may be extra health risks for BAME groups.");
            }
        }

        public static double GetInput(string prompt)
        {
            double input;
            Console.Write(prompt);
            while (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.Write(prompt);
            }
            return input;
        }

        public static double ConvertToKg(double stones, double pounds)
        {
            return (stones * 6.35029) + (pounds * 0.453592);
        }

        public static double ConvertToMeters(double feet, double inches)
        {
            return (feet * 0.3048) + (inches * 0.0254);
        }

        public static double CalculateBMI(double weight, double height)
        {
            return weight / (height * height);
        }

        public static string InterpretBMI(double bmi)
        {
            if (bmi < 18.5)
            {
                return "Underweight";
            }
            else if (bmi < 25)
            {
                return "Normal";
            }
            else if (bmi < 30)
            {
                return "Overweight";
            }
            else if (bmi < 35)
            {
                return "Obese Class I";
            }
            else if (bmi < 40)
            {
                return "Obese Class II";
            }
            else
            {
                return "Obese Class III";
            }
        }
    }
}



