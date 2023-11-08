using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Egzaminas_Bar_uzsakymas
{
    internal class Print
    {
        public static void WholeMeniu()
        {
            Console.WriteLine("Laba vakarą, štai mūsų Meniu");
            Console.WriteLine();

            List<string> drinksMenu = DrinksMeniu();

            foreach (string drink in drinksMenu)
            {
                Console.WriteLine(drink);
            }
            Console.WriteLine();

            List<string> starterMenu = StarterMeniu();

            foreach (string starter in starterMenu)
            {
                Console.WriteLine(starter);
            }
            Console.WriteLine();

            List<string> soupMenu = SoupMeniu();

            foreach (var item in soupMenu)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            List<string> mainDishMenu = MaineDishMeniu();

            foreach (var item in mainDishMenu)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            List<string> desertMeniu = DesertDishMeniu();

            foreach (var item in desertMeniu)
            {
                Console.WriteLine(item);
            }

        }
        public static List<string> PrintTableListFromFile()
        {
            FromFile fromFile = new FromFile();
            List<string> listOfTables = fromFile.ReadTableListFromFile();

            foreach (string table in listOfTables)
            {
                Console.WriteLine(table);
            }
            return listOfTables;

        } //atspausdinimas staliuku saraso is failo
        public static List<string> ChooseTabeWithoutNumberOnMeniu()
        {
            FromFile fromFileIndex = new FromFile();
            List<string> fromFileTable = new List<string>();                //sukuriam nauja Lista kad tik atvaizduotu kas yra po ","
            var listOfTables = fromFileIndex.ReadTableListFromFile();

            foreach (var table in listOfTables)
            {
                string tablesubstring = table.Substring(4); //naudoju nes faile tik staliuku sarasas
                fromFileTable.Add(tablesubstring);
            }
            return fromFileTable;
        }
        public static List<string> DrinksMeniu()
        {
            FromFile fromFileIndex = new FromFile();
            List<string> fromFileDrinks = new List<string>();                //sukuriam nauja Lista kad tik atvaizduotu kas yra po ","
            var listOfDrinks = fromFileIndex.ReadMeniuListFromFile();
            string key = "Gėrimai:";
            foreach (var drink in listOfDrinks)
            {
                if (drink.Contains(key))
                {
                    string drinkSubstring = drink.Substring(key.Length); //naudoju nes faile tik staliuku sarasas
                    fromFileDrinks.Add(drinkSubstring);

                }
            }
            return fromFileDrinks;
        }
        public static List<string> DrinksMeniuWithoutNumber()
        {
            List<string> fromFileDrinks = new List<string>();                //sukuriam nauja Lista kad tik atvaizduotu kas yra po ","
            var listOfDrinks = Print.DrinksMeniu();

            foreach (var drink in listOfDrinks)
            {
                string drinkSubstring = drink.Substring(3); //naudoju nes faile tik staliuku sarasas
                fromFileDrinks.Add(drinkSubstring);

            }

            return fromFileDrinks;
        }
        public static List<string> StarterMeniu()
        {
            FromFile fromFileIndex = new FromFile();
            List<string> fromFileStarter = new List<string>();                //sukuriam nauja Lista kad tik atvaizduotu kas yra po ","
            var listOfStarters = fromFileIndex.ReadMeniuListFromFile();
            string key = "Užkandžiai:";
            foreach (var starter in listOfStarters)
            {
                if (starter.Contains(key))
                {
                    string starterSubstring = starter.Substring(key.Length); //naudoju nes faile tik staliuku sarasas
                    fromFileStarter.Add(starterSubstring);

                }
            }
            return fromFileStarter;
        }
        public static List<string> StarterMeniuWithoutNumber()
        {
            List<string> fromFileDrinks = new List<string>();                //sukuriam nauja Lista kad tik atvaizduotu kas yra po ","
            var listOfStarters = StarterMeniu();

            foreach (var starter in listOfStarters)
            {
                string drinkSubstring = starter.Substring(3); //naudoju nes faile tik staliuku sarasas
                fromFileDrinks.Add(drinkSubstring);

            }

            return fromFileDrinks;
        }
        public static List<string> SoupMeniu()
        {
            FromFile fromFileIndex = new FromFile();
            List<string> fromFileDrinks = new List<string>();                //sukuriam nauja Lista kad tik atvaizduotu kas yra po ","
            var listOfStarters = fromFileIndex.ReadMeniuListFromFile();
            string key = "Sriubos:";
            foreach (var starter in listOfStarters)
            {
                if (starter.Contains(key))
                {
                    string starterSubstring = starter.Substring(key.Length); //naudoju nes faile tik staliuku sarasas
                    fromFileDrinks.Add(starterSubstring);

                }
            }
            return fromFileDrinks;
        }
        public static List<string> SoupMeniuWithoutNumber()
        {
            List<string> fromFileDrinks = new List<string>();                //sukuriam nauja Lista kad tik atvaizduotu kas yra po ","
            var listOfStarters = SoupMeniu();

            foreach (var starter in listOfStarters)
            {
                string drinkSubstring = starter.Substring(3); //naudoju nes faile tik staliuku sarasas
                fromFileDrinks.Add(drinkSubstring);

            }

            return fromFileDrinks;
        }
        public static List<string> MaineDishMeniu()
        {
            FromFile fromFileIndex = new FromFile();
            List<string> fromFileMainDish = new List<string>();                //sukuriam nauja Lista kad tik atvaizduotu kas yra po ","
            var listOfMainDish = fromFileIndex.ReadMeniuListFromFile();
            string key = "patiekalai:";
            foreach (var mainDish in listOfMainDish)
            {
                if (mainDish.Contains(key))
                {
                    string starterSubstring = mainDish.Substring(key.Length); //naudoju nes faile tik staliuku sarasas
                    fromFileMainDish.Add(starterSubstring);

                }
            }
            return fromFileMainDish;
        }
        public static List<string> MainDishMeniuWithoutNumber()
        {
            List<string> fromFileDrinks = new List<string>();                //sukuriam nauja Lista kad tik atvaizduotu kas yra po ","
            var listOfStarters = MaineDishMeniu();

            foreach (var starter in listOfStarters)
            {
                string drinkSubstring = starter.Substring(3); //naudoju nes faile tik staliuku sarasas
                fromFileDrinks.Add(drinkSubstring);

            }

            return fromFileDrinks;
        }
        public static List<string> DesertDishMeniu()
        {
            FromFile fromFileIndex = new FromFile();
            List<string> fromFileDesert = new List<string>();                //sukuriam nauja Lista kad tik atvaizduotu kas yra po ","
            var listOfDesert = fromFileIndex.ReadMeniuListFromFile();
            string key = "Desertai:";
            foreach (var desert in listOfDesert)
            {
                if (desert.Contains(key))
                {
                    string starterSubstring = desert.Substring(key.Length); //naudoju nes faile tik staliuku sarasas
                    fromFileDesert.Add(starterSubstring);

                }
            }
            return fromFileDesert;
        }
        public static List<string> DesertMeniuWithoutNumber()
        {
            List<string> fromFileDesert = new List<string>();                //sukuriam nauja Lista kad tik atvaizduotu kas yra po ","
            var listOfDesert = DesertDishMeniu();

            foreach (var desert in listOfDesert)
            {
                string desertSubstring = desert.Substring(3); //naudoju nes faile tik staliuku sarasas
                fromFileDesert.Add(desertSubstring);

            }

            return fromFileDesert;
        }

       

    }
}
