using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Final
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the total number of points:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter 3Set of X,Y,Z co-ordinate comma seperated:");
            string co_ordinates = Console.ReadLine();
            int[] co_ordinate = co_ordinates.Split(',').Select(n => Convert.ToInt32(n)).ToArray(); ;
            int[] z_array = new int[3];

            Array.Copy(co_ordinate, 6, z_array, 0, 3);
            Array.Sort(z_array);
            int min_distance = z_array.Min() == 0 ? z_array[1] : z_array.Min();
            double arc_of_circle = (3.14 / 3);
            arc_of_circle = Math.Round(arc_of_circle, 2, MidpointRounding.ToEven);

            double total_x_ordinate = Convert.ToInt32(co_ordinate[0]) + Convert.ToInt32(co_ordinate[3]) + Convert.ToInt32(co_ordinate[6]);
            double total_distance_travel = arc_of_circle + total_x_ordinate;
            Console.WriteLine("Same face Distance: " + total_distance_travel);
            Console.WriteLine("Diffrent face Distance: " + (arc_of_circle + min_distance));

            Console.ReadLine();
        }
    }

}
