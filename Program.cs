using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //GLOBAL DECLARATIONS
            int stayDuration;
            string servicesIncluded;
            double totalCost;
            string serviceCode;

            welcome();
            //Stay duration
            Console.WriteLine("Please input the number of days your dog will be staying with us:");
            stayDuration = Convert.ToInt32(Console.ReadLine());
            //Service add-on yes/no
            Console.WriteLine("\nServices:\nNo add-ons: $75.00 per day\nBathing and Grooming: $169.00 per day\nOnly Bathing: $112.00 per day\n\nWould you like any add-on services? (Y/N):");
            servicesIncluded = Console.ReadLine();
            //Decision making logic
            if(servicesIncluded == "N"){
                totalCost = computeRate(stayDuration);
                end(stayDuration, totalCost);
            }
            else if(servicesIncluded =="Y"){
                Console.WriteLine("Please select your Service Add-on:\nBathing and Grooming: $169.00 per day (A)\nOnly Bathing: $112.00 per day (C)");
                serviceCode = Console.ReadLine();
                while(serviceCode !== "A" && serviceCode !== "C"){
                    Console.WriteLine("Please enter a valid service Add-on:\nBathing and Grooming: $169.00 per day (A)\nOnly Bathing: $112.00 per day (C)");
                    serviceCode = Console.ReadLine();
                }
                return totalCost = computeRate(stayDuration, serviceCode);
            }
        }

        //welcome method
        static void welcome(){
            Console.WriteLine("Welcome to MPLS Dog Boarding!\n");
        }
        //computeRate without addons method
        static double computeRate(int stayDuration){
            const double FLAT_COST = 75.00;
            
            return stayDuration * FLAT_COST;
        }
        //computeRate WITH addons method
        static double computeRate(int stayDuration, string addonCode){
            const double BATH_GROOMING_FLAT_COST = 169.00;
            const double BATH_FLAT_COST = 112.00;

            if(addonCode == "A"){
                return stayDuration * BATH_GROOMING_FLAT_COST;
            }
            else if(addonCode == "C"){
                return stayDuration * BATH_FLAT_COST;
            }
        }
        //end method
        static void end(int stayDuration, string addonCode, double totalCost){
            Console.WriteLine($"Days in Care: {stayDuration}\n Service Code: {serviceCode}\n Total cost of stay: {totalCost}");
        }
    }
}
