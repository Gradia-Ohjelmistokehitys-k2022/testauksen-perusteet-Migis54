using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1._2
{
    public class Program
    {
        public string vastaus;
        public static void Main(string[] args)
        {
            Program rogrammi = new Program();
            double num1 = 0;
            Console.WriteLine("anna numero jonka potenssi toiseen ei ylitä 100");
            string syöttö;
            syöttö = Console.ReadLine();
            try
            {
                double num2 = double.Parse(syöttö);
                num1 = Math.Pow(num2, 2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            rogrammi.vastaus= num1.ToString();
            Console.WriteLine("tulos on " + (rogrammi.Maksimi_Numero(100) ? rogrammi.vastaus.ToString() : "lukua ei jakseta käsitellä"));
            Console.ReadKey();
        }
        public bool Maksimi_Numero(double maksimi_määrä) 
        {
            int vastaus = 0;
            if(int.TryParse(this.vastaus, out vastaus)) 
            {
                vastaus = int.Parse(this.vastaus);
            }
            else 
            {
                throw new ArgumentException("väärä syöttö");
            }
            if(vastaus > maksimi_määrä) 
            {
                throw new ArgumentOutOfRangeException("limittejen ylite");
            }
            return true;
            
        }
        public bool Vastaus_on_numerollinen(string vastaus, int num)
        {
            if (int.TryParse(vastaus, out num))
            {
                return true;
            }
            return false;
        }
    }
}
