using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int stayDuration;
            string servicesIncluded;

            welcome();
            //Stay duration
            Console.WriteLine("Please input the number of days your dog will be staying with us:");
            stayDuration = Console.ReadLine();
            //Service add-on yes/no
            Console.WriteLine("Would you like any add-on services? (Y/N):");
            servicesIncluded = Console.ReadLine();
        }

        //welcome method
        static void welcome(){
            Console.WriteLine("Welcome to MPLS Dog Boarding!\n");
        }
    }
}
