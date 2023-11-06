using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    public class Program
    {
        public string vastaus;
        static void Main(string[] args)
        {
            Program rogrammi= new Program();
            Console.WriteLine("anna numero");
            int num1 = 0;
            int num2 = 0;
            string syöttö;
            syöttö = Console.ReadLine();
            try 
            {
                num1 = int.Parse(syöttö);
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }

            syöttö = Console.ReadLine();
            try
            {
                num2 = int.Parse(syöttö);
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
            rogrammi.vastaus = rogrammi.Miinustus(num1, num2).ToString();
            Console.WriteLine("tulos on " + (rogrammi.Vastaus_on_numerollinen(rogrammi.vastaus, 0) ? rogrammi.vastaus: "ei voi laskea")) ;
            Console.ReadKey();


        }
        public int Miinustus(int num1, int num2) 
        {
            if (num1 > int.MaxValue || num2 > int.MaxValue) 
            {
                throw new ArgumentException(int.MaxValue.ToString());
            }
            if (num1 < int.MinValue|| num2 < int.MinValue) 
            {
                throw new ArgumentException(int.MinValue.ToString());
            }
            int minustus = num1 - num2;
            return minustus;
        }
        public bool Vastaus_on_numerollinen(string vastaus, int num) 
        {
            if(int.TryParse(vastaus, out num)) 
            {
                return true;
            }
            return false;
        }
    }
}
