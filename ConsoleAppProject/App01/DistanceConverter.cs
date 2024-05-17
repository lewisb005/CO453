using ConsoleAppProject.App01;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;

using System;

namespace ConsoleAppProject.App01
{
    using ConsoleAppProject.App01;
    using ConsoleAppProject.App03;
    using ConsoleAppProject.Helpers;

    using System;

    namespace DistanceConverter
    {
        class DistanceConverter
        {
            private static void Main(string[] args)
            { 
                Console.WriteLine("Distance Converter App");
                Console.WriteLine("1. Miles to Feet");
                Console.WriteLine("2. Feet to Miles");
                Console.WriteLine("3. Miles to Metres");
                Console.WriteLine("4. Metres to Miles");
                Console.WriteLine("5. Metres to Feet");
                Console.WriteLine("6. Feet to Metres");

                Console.Write("Enter your choice (1/2/3/4/5/6): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter distance in miles: ");
                        double milesToFeet = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Distance in feet: " + DistanceUnits.MilesToFeet(milesToFeet));
                        break;
                    case 2:
                        Console.Write("Enter distance in feet: ");
                        double feetToMiles = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Distance in miles: " + DistanceUnits.FeetToMiles(feetToMiles));
                        break;
                    case 3:
                        Console.Write("Enter distance in miles: ");
                        double milesToMetres = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Distance in metres: " + DistanceUnits.MilesToMetres(milesToMetres));
                        break;
                    case 4:
                        Console.Write("Enter distance in metres: ");
                        double metresToMiles = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Distance in miles: " + DistanceUnits.MetresToMiles(metresToMiles));
                        break;
                    case 5:
                        Console.Write("Enter distance in metres: ");
                        double metresToFeet = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Distance in feet: " + DistanceUnits.MetresToFeet(metresToFeet));
                        break;
                    case 6:
                        Console.Write("Enter distance in feet: ");
                        double feetToMetres = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Distance in metres: " + DistanceUnits.FeetToMetres(feetToMetres));
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }

            internal void FeetToMiles()
            {
                throw new NotImplementedException();
            }

            internal void MilesToFeet()
            {
                throw new NotImplementedException();
            }

            internal void MilesToMetres()
            {
                throw new NotImplementedException();
            }
        }
    }
}
    