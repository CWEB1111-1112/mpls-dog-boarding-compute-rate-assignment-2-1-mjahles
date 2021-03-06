﻿using System;

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
            stayDuration = stayLength();
            servicesIncluded = extraService();
            
            //Main decision-making logic            
            if(servicesIncluded =="Y"){
                serviceCode = selectService();
                while(serviceCode != "A" && serviceCode != "C"){
                    Console.WriteLine("Please enter a valid service Add-on.");
                    serviceCode = selectService();
                }
                Console.WriteLine("");
                totalCost = computeRate(stayDuration, serviceCode);
                end(stayDuration, serviceCode, totalCost);
            }
            else{
                totalCost = computeRate(stayDuration);
                serviceCode = "N/A";
                end(stayDuration, serviceCode, totalCost);
            }
        }

        //welcome method
        static void welcome(){
            Console.WriteLine("Welcome to MPLS Dog Boarding!\n");
        }
        //stayLength method
        static int stayLength(){
            Console.WriteLine("Please input the number of days your dog will be staying with us:");
            return Convert.ToInt32(Console.ReadLine());
        }
        //extraService method
        static string extraService(){
            Console.WriteLine("\nServices:\nNo add-ons: $75.00 per day\nBathing and Grooming: $169.00 per day\nOnly Bathing: $112.00 per day\n\nWould you like any add-on services? (Y/N):");
            return Console.ReadLine();
        }
        //selectService method
        static string selectService(){
            Console.WriteLine("\nPlease select your Service Add-on:\nBathing and Grooming: $169.00 per day (A)\nOnly Bathing: $112.00 per day (C)");
            return Console.ReadLine();
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
            else{
                return stayDuration * BATH_FLAT_COST;
            }
        }
        //end method
        static void end(int stayDuration, string serviceCode, double totalCost){
            Console.WriteLine($"Days in Care: {stayDuration}\n Service Code: {serviceCode}\n Total cost of stay: {totalCost.ToString("c")}");
        }
    }
}
