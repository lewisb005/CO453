
/// <summary>
/// The main method in this class is called first
/// when the application is started.  It will be used
/// to start App01 to App05 for CO453 CW1
/// 
/// This Project has been modified by:
/// Lewis Burke 26/1/2024
/// </summary>


using ConsoleAppProject.App01.DistanceConverter;
using System;


namespace ConsoleAppProject.App01


{
    public static class Program
    {
        public static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("    BNU CO453 Applications Programming 2022-2023! ");
            Console.WriteLine();
            Console.Beep();

        }



        class DistanceConverter

        {
            DistanceConverter converter = new DistanceConverter();
        }
    }
}










