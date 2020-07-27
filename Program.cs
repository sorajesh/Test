using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter the total number of points:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter 3Set of X,Y,Z co-ordinate comma seperated:");
            string co_ordinates = Console.ReadLine();
            string[] co_ordinate = co_ordinates.Split(',');
            double arc_of_circle = (3.14 / 3);
            arc_of_circle = Math.Round(arc_of_circle, 2, MidpointRounding.ToEven);

            double total_x_ordinate = Convert.ToInt32(co_ordinate[0]) + Convert.ToInt32(co_ordinate[3]) + Convert.ToInt32(co_ordinate[6]);
            double total_distance_travel = arc_of_circle + total_x_ordinate;
            Console.Write("Total distance travel: " + total_distance_travel);
            Console.ReadLine();    
        }
    }
}
