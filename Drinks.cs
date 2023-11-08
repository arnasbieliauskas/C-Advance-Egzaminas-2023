using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace c__Egzaminas_Bar_uzsakymas
{



    internal class Drinks : Food 
    {
        //pasieme tik satliuko pavadinima 
        private readonly string _chossenTable; //surisame su staliuku

        public Drinks(string chossenTable) //konstruktorius
        {
            _chossenTable = chossenTable;
        }

        public override string Choose()
        {
            string choosenDrinks = null;

            int totalDrinkIndex = Print.DrinksMeniu().Count(); //nustatau kokio ilgio yra Listas
            int drinkChoose = 0;
            var drinksMeniuWithoutNumbers = Print.DrinksMeniuWithoutNumber();   //gerimu sarasas be numeracijos tam kad parodytu pasirinkima
            var fromFileDrinks = Print.DrinksMeniu();
          

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Ką iš gėrimų pageidausite?");
                Console.WriteLine();
                List<string> drinksMenu = Print.DrinksMeniu();
                foreach (string drink in drinksMenu)
                {
                    Console.WriteLine(drink);
                }
                Console.WriteLine();
                Console.WriteLine("Psirinkite gėrimą");
                var drinkname = Console.ReadLine();

                if (int.TryParse(drinkname, out drinkChoose) && drinkChoose >= 0 && drinkChoose <= totalDrinkIndex) // tikrinam ar atitinka salygas
                {
                    choosenDrinks = fromFileDrinks[drinkChoose];
                    Console.WriteLine($"Pasirinktas -- {drinksMeniuWithoutNumbers[drinkChoose]} -- gėrimas");                   // pagal vartotojo ivesti isvedam satliuko pavadinima
                                                                                                                                      //var tableName = new Table(drinkname);
                    break;
                }
                else
                {
                    Console.WriteLine("Šiuo metu tokio gėrimo neturime");
                    Console.WriteLine("Prašome pasirinkti iš esamo sąrašo");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
            return choosenDrinks;
        }
    }
}