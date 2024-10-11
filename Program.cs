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


        static void Main(string[] args)
        {
            Console.WriteLine(Greeting());
            Console.WriteLine(Money());
        }
    }
}
