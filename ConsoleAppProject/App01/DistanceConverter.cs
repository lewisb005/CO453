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
        private double miles;

        private double feet;

        /// <summary>
        /// 
        /// </summary>

        public void Run()
        {
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
        
        }
        
        private void OutputFeet()
        {

        }


    }
}
