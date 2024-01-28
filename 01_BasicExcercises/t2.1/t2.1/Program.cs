using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2._1
{
    public class Program
    {
        public double input;
        public static void Main(string[] args)
        {
        }
        public static double Smallest_Number(List<double> list)
        {
            list.Sort();
            return list[0];
        }
        public bool IsListNull(double input,List<double> list)
        {
            list.Add(input);
            if(list == null) 
            {
                return true;
            }
            return false;
        }  
    }
}
