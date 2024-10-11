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
        static void Main(string[] args)
        {
            Console.WriteLine(Greeting());
        }
    }
}
