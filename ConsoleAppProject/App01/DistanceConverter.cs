using ConsoleAppProject.App01;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;

using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Lewis version 0.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        private double miles;

        private double feet;

        private double metres; 

        /// <summary>
        /// This method will input the distance measured in miles
        /// calculate the same distance in feet, and output the 
        /// distance in feet.
        /// </summary>

        public void MilesToFeet()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();

 
        }
        private void FeetToMiles()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }
        private void MilesToMetres()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        /// <summary>
        /// Prompt the user to enter the distance in miles
        /// Input the miles as a double number
        /// </summary>

        private void InputMiles()
        {
            Console.Write{ "please enter the number of miles > "};
                string value = Console.ReadLine();
            miles = Convert.Todouble(value);

        }
        private void CalculateFeet()
        {
         public const int  FEET_IN_MILES = 5280;
        }
        
        private void OutputFeet()
        {
        Console.WriteLine(miles + "miles is" + feet +
            "feet!");
        }
   private void ConvertMilesToFeet()
    {
        OutputHeading();
        InputMiles();

        feet = miles * FEET_IN_MILES;

        OutputFeet();
    }
   


    }
}
