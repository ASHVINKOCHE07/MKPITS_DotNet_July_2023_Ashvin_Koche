/*13 wap to accept origin, destination, date, trainno, class, passengername 
then calculate totalfare (if lessthan 100 km then 100, between 100 and 500 km fare is 500 otherwise 800) and then print ticket details*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string origin, passengername, class1, date;
            int  trainno, totalfare, km, destination;
            Console.Write("Enter origin: ");
            origin = Console.ReadLine();
            Console.Write("Enter destination: ");
            destination = Console.ReadLine();
            Console.Write("Date: ");
            date = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter pasanger name: ");
            passengername = Console.ReadLine();
            Console.Write("Destinations = ");
            Console.WriteLine("Press 1 for Mumbai ");
            Console.WriteLine("Press 2 for Delhi ");
            Console.WriteLine("Press 3 for Patna ");

            km = Convert.ToInt32(Console.ReadLine());
            if (destination == 1)
            {
                if (km < 100)
                {
                    totalfare = 100;
                    Console.Write("Enter train no: ");
                    trainno = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter class: ");
                    class1 = Console.ReadLine();
                }
                if (km > 100)
                {
                    Console.WriteLine("Enter destination = ");
                    if (totalfare>=250)
                    {
                        Console.WriteLine("Ur fair is not enough");
                    }
                    else
                    {
                        Console.WriteLine("U have entered wrong destination");
                        km--;
                    }
                }
                if (km > 100 && km <500)
                {
                    Console.WriteLine("Enter destination = ");
                    if (totalfare >= 250)
                    {
                        Console.WriteLine("Ur fair is not enough");
                    }
                    else
                    {
                        Console.WriteLine("U have entered wrong destination");
                        km--;
                    }
                }
               }
            else if (km > 100 && km < 500)
            {
                totalfare = 500;
                Console.Write("Enter train no: ");
                trainno = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter class: ");
                class1 = Console.ReadLine();
            }
            else if (km > 100 && km < 500)
            {
                totalfare = 500;
                Console.Write("Enter train no: ");
                trainno = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter class: ");
                class1 = Console.ReadLine();
            }
                totalfare = 800 + 0.5 * 215f;
            else
            {
                totalfare = 800;
            }
        }

            Console.WriteLine("Origin: {0} destination: {1} Date: {2} trainno: {3} class: {3} passengername: {4}", origin, destination, date, trainno, class1, passengername);
            Console.WriteLine("kilometer: {0} Total fare: {1}", km, totalfare);

            Console.ReadKey();

        }
    }
}