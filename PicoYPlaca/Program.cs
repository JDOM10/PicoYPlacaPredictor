using System;
using PicoYPlaca.Rules;
using PicoYPlaca.Models;

namespace PicoYPlacaApp
{
   public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pico y Placa Predictor");
                Console.WriteLine("Enter the license plate number (e.g., PBX-1234):");
                string licensePlate = Console.ReadLine();

                Console.WriteLine("Enter the date (yyyy-mm-dd):");
                string date = Console.ReadLine();

                Console.WriteLine("Enter the time (hh:mm):");
                string time = Console.ReadLine();

                Vehicle vehicle = new Vehicle(licensePlate);
                PicoYPlaca.Services.Predictor predictor = new PicoYPlaca.Services.Predictor(vehicle, date, time);

                Console.WriteLine("\nLicense plate: " + licensePlate);
                Console.WriteLine("Date: " + date);
                Console.WriteLine("Time: " + time);
                Console.WriteLine("Result: " + predictor.GetResult());
                Console.ReadLine();

            }catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }
    }
}