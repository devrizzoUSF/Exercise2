using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 29;
            int numFeet = 61;
            //max number of TV shows you can watch is equal to 500 minus your age 

            int tvShows = 500 - age;

            Console.WriteLine("I am " + age + " years old, the max number of TV shows I can watch is " + tvShows + " and I am " + numFeet + " feet tall");
        }
    }
}
