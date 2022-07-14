using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradingsystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int x=int.Parse(Console.ReadLine());
            
           
            if (x >= 90)
            {
                Console.WriteLine("Result is A");
            }
            else if ( x >= 70){
                Console.WriteLine("Result is B");
            }
            else if(x >= 60){
                Console.WriteLine("Result is C");
            }
            else if(x >= 50){
                Console.WriteLine("Result is D");
            }
            else if (x >100)
            {
                Console.WriteLine("Error :Grade should be less than hundred");
            }
            else if (x <0)
            {
                Console.WriteLine("Error :Grade should be greater than zero");
            }

            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
