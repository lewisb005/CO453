using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleAppProject.Helpers
{
    public static class DistanceUnits
    {
        public static double MilesToFeet(double miles)
        {
            return miles * 5280;
        }

        public static double FeetToMiles(double feet)
        {
            return feet / 5280;
        }

        public static double MilesToMeters(double miles)
        {
            return miles * 1609.34;
        }

        public static double MetersToMiles(double meters)
        {
            return meters / 1609.34;
        }

        public static double MetersToFeet(double meters)
        {
            return meters * 3.28084;
        }

        public static double FeetToMeters(double feet)
        {
            return feet / 3.28084;
        }

        internal static string FeetToMetres(double feetToMetres)
        {
            throw new NotImplementedException();
        }

        internal static string MetresToFeet(object metresToFeet)
        {
            throw new NotImplementedException();
        }

        internal static string MetresToMiles(double metresToMiles)
        {
            throw new NotImplementedException();
        }

        internal static string MilesToMetres(double milesToMetres)
        {
            throw new NotImplementedException();
        }
    }
}