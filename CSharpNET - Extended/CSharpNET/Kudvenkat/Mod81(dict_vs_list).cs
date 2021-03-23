
/* mod 81 when to use Dictionary over List
// Also see webform3 and country.cs class webapplicatio1 for demo with UI

using System;
using System.Collections.Generic;

namespace CSharpNET
{
    class Program
    {
        static void Main(string[] args)
        {
            Country country1 = new Country() { Code = "AUS",Name = "AUSTRALIA",Capital = "Canberra"};

            Country country2 = new Country() { Code = "IND",Name = "INDIA ",Capital = "New Delhi"};

            Country country3 = new Country() { Code = "USA",Name = "UNITED STATES",Capital = "Washington D.C."};

            Country country4 = new Country() { Code = "GBR",Name = "UNITED KINGDOM",Capital = "London" };

            Country country5 = new Country() { Code = "CAN",Name = "CANADA", Capital = "Ottawa" };

            ////using list
            //List<Country> listCountries = new List<Country>() { country1, country2, country3, country4, country5 };

            //string choice = string.Empty;
            //do 
            //{
            //    Console.WriteLine("Please Enter the Country code");
            //    string countryCode = Console.ReadLine().ToUpper();

            //    Country result = listCountries.Find(x => x.Code == countryCode);

            //    if (result == null)
            //        Console.WriteLine("Country is not valid");
            //    else
            //        Console.WriteLine("Name = {0} Capital = {1}", result.Name, result.Capital);

            //    do
            //    {
            //        Console.WriteLine("Do you want to continue? - Yes or NO");
            //        choice = Console.ReadLine().ToUpper(); 
            //    } while (choice != "YES" && choice != "NO");

            //} while (choice == "YES");

            //using dictionary
            Dictionary<string, Country> dictCountries = new Dictionary<string, Country>();
            dictCountries.Add(country1.Code, country1);
            dictCountries.Add(country2.Code, country2);
            dictCountries.Add(country3.Code, country3);
            dictCountries.Add(country4.Code, country4);
            dictCountries.Add(country5.Code, country5);

            string userChoice = string.Empty;
            do
            {
                Console.WriteLine("Enter the Country code for lookup");
                string input = Console.ReadLine().ToUpper();

                if (dictCountries.TryGetValue(input, out Country result))
                    Console.WriteLine("Name = {0} Capital = {1}", result.Name, result.Capital);               
                else
                    Console.WriteLine("Country is not valid");

                do
                {
                    Console.WriteLine("Do you want to continue? - Yes or NO");
                    userChoice = Console.ReadLine().ToUpper();
                    
                } while (userChoice != "YES" && userChoice != "NO");

            } while (userChoice == "YES" );
                


        }
    }

    public class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Capital { get; set; }
    }
}

//*/

