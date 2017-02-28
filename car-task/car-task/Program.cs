using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_task
{

    public class Program
    {
       public static void Main(string[] args)
       {
           
            var myCar = new Car();
            var myCar2 = new Car("VW", 90);
            myCar2.Speed = 100;

            Console.WriteLine(myCar.RetrieveData());
            Console.WriteLine(myCar2.RetrieveData());
            myCar2.Accelerate(0.20);
            myCar2.Accelerate(0.10);
            Console.WriteLine("New speed:" + myCar2.Speed );
            myCar2.Decelarate(0.10);
            Console.WriteLine("Speed after slowing down a bit: " + myCar2.Speed);
            Console.WriteLine(myCar2);
            Console.ReadKey();
            
        }
    }
}
