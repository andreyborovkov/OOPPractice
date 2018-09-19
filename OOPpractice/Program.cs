using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPpractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dog woofy = new Dog();
            //Dog spot = new Dog();
            //Dog woofy = new Dog(7, 8.5, 33.2, 190.1, "Woofy");
            //Dog spot = new Dog(15, 10.5, 100.9, 250.3, "Spot");

            //Console.WriteLine("Woofie's hair length is: {0} ", woofy.HairLength);
            //Console.WriteLine("Spot's hair length is: {0} ", spot.HairLength);

            //woofy.HairLength = 4;
            //spot.HairLength = 6;
            //woofy.GetSpeed(7);
            //spot.GetSpeed(11);
            //Console.WriteLine("Woofy's hair length is: {0} ", woofy.HairLength);
            //Console.WriteLine("Spot's hair length is: {0} ", spot.HairLength);
            //Console.WriteLine("Woofiy is running: {0}", woofy.GetSpeed(7));

            Superhero hulk = new Superhero("Bruce", 20, 3.5, false);
            hulk.GetDetails();
            hulk.GetHulk();
            hulk.GetDetails();
            hulk.GetBruce();
            hulk.GetDetails();
            hulk.GetHulk();
            hulk.GetHulk();
            hulk.GetDetails();
        }
    }
}
