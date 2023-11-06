using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1._3
{
    public class Program
    {
        
        public string syöttö;
        double num1 => Math.Sqrt(Convert.ToDouble(syöttö));
        public static void Main(string[] args)
        {
            Program rogrammi = new Program();
            Console.WriteLine("anna numero, jotta voin laitan sen neliöjuureen");

            rogrammi.syöttö = Console.ReadLine();
            if (double.TryParse(rogrammi.syöttö, out double num))
            {
                if (rogrammi.Syöttö_on_numerollinen(rogrammi.syöttö, 0) && rogrammi.Syöttö_Ei_Ole_miinus_luku(rogrammi.syöttö, 0))
                {
                    Console.WriteLine("Neliöjuuri: " + rogrammi.num1);
                }
                else if(!rogrammi.Syöttö_Ei_Ole_miinus_luku(rogrammi.syöttö,int.Parse(rogrammi.syöttö))) 
                {
                    Console.WriteLine("Teit kaiken väärin");
                }
            }
            else
            {
                Console.WriteLine("teit kaiken väärin, häpeä");
            }
            Console.ReadKey();

        }
        public bool Syöttö_on_numerollinen(string vastaus, int num)
        {
            if (int.TryParse(vastaus, out num))
            {
                return true;
            }
            return false;
        }
        public bool Syöttö_Ei_Ole_miinus_luku(string vastaus, int num) 
        {
            int.TryParse(vastaus, out num);
            if(num > 0) 
            {
                return true;
            }
            return false;
        }
    }
}
