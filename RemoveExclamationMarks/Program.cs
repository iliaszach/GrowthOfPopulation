using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveExclamationMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NbYear(1000,2,50,1200));
        }

        public static int NbYear(int p0, double percent, int aug, int p)
        {            
            int count = 0;
            while (p0 < p)
            {
                count++;               
                p0 = Convert.ToInt32(p0 + Math.Floor(p0 * percent / 100) + aug);
                
            }     
            return count;
           
        }

    }
}
