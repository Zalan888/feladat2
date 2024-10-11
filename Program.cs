using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udvozol
{
    internal class Program
    {
        public static string Greeting()
        {
            if (DateTime.Now.Hour >= 0 && DateTime.Now.Hour < 12)
            {
                return "Good morning!";
            }
            else if (DateTime.Now.Hour < 20 && DateTime.Now.Hour >= 12)
            {
                return "Good afternoon!";
            }
            else if (DateTime.Now.Hour <= 24 && DateTime.Now.Hour >= 20) { }
            return "a";
        }

        // feladat2
        public static int Money()
        {
            Console.WriteLine("Kérem adja meg a futamidőt");
            int years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem adja meg a kezdőtőkét!");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem adja meg a kamatot (százalék formájában)");
            double interest = Convert.ToDouble(Console.ReadLine()) / 100;
            double totalAmount = amount + (amount * interest * years);
            return (int)totalAmount;
        }

        //feladat3
        static void CalculateAndDisplaySpeeds()
        {
            double initialSpeed = GetInitialSpeed();

            for (int distance = 0; distance <= 50; distance += 10)
            {
                double speed = CalculateSpeedDuringAcceleration(initialSpeed, distance);
                DisplaySpeed(distance, speed);
            }

            for (int distance = 60; distance <= 100; distance += 10)
            {
                double speed = CalculateSpeedDuringDeceleration(initialSpeed, distance);
                DisplaySpeed(distance, speed);
            }
        }

        
        static double GetInitialSpeed()
        {
            double speed;
            do
            {
                Console.Write("Kérjük, adja meg a kezdő sebességet (3.00 - 5.00 m/s): ");
                speed = Convert.ToDouble(Console.ReadLine());
            } while (speed < 3.00 || speed > 5.00);
            return speed;
        }

        
        static double CalculateSpeedDuringAcceleration(double initialSpeed, int distance)
        {
            double acceleration = 1.0; // m/s^2
            return initialSpeed + acceleration * (distance / 10.0);
        }

        
        static double CalculateSpeedDuringDeceleration(double initialSpeed, int distance)
        {
            double acceleration = 1.0; // m/s^2
            double deceleration = 1.0; // m/s^2
            double speed = initialSpeed + acceleration * 5 - deceleration * ((distance - 60) / 10.0);
            return speed < 0 ? 0 : speed; 
        }

        
        static void DisplaySpeed(int distance, double speed)
        {
            double speedKmh = speed * 3.6; // Convert m/s to km/h
            Console.WriteLine($"Táv: {distance} m, Sebesség: {speedKmh:F2} km/h");
        }


        static void Main(string[] args)
        {
            Console.WriteLine(Greeting());
            Console.WriteLine(Money());
            CalculateAndDisplaySpeeds();
        }
    }
}
