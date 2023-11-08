using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Egzaminas_Bar_uzsakymas
{
    internal class MainDish : Food
    {
        private readonly string _chossenTable; //surisame su staliuku

        public MainDish(string chossenTable) //konstruktorius
        {
            _chossenTable = chossenTable;
        }

        public override string Choose()
        {
            string choosenDrinks = null;

            int totalMainDishIndex = Print.MaineDishMeniu().Count(); //nustatau kokio ilgio yra Listas
            int drinkChoose = 0;
            var drinksMeniuWithoutNumbers = Print.MainDishMeniuWithoutNumber();   //gerimu sarasas be numeracijos tam kad parodytu pasirinkima
            var fromFileDrinks = Print.MaineDishMeniu();


            while (true)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Kas bus Jūsų pagrindinis patiekalas?");
                Console.WriteLine();
                List<string> drinksMenu = Print.MaineDishMeniu();
                foreach (string drink in drinksMenu)
                {
                    Console.WriteLine(drink);
                }
                Console.WriteLine();
                Console.WriteLine("Prašom pasirinkti");
                var drinkname = Console.ReadLine();

                if (int.TryParse(drinkname, out drinkChoose) && drinkChoose >= 0 && drinkChoose <= totalMainDishIndex) // tikrinam ar atitinka salygas
                {
                    choosenDrinks = fromFileDrinks[drinkChoose];
                    Console.WriteLine($"Pasirinktas -- {drinksMeniuWithoutNumbers[drinkChoose]} -- pagrindinis patiekalas");                   // pagal vartotojo ivesti isvedam satliuko pavadinima
                                                                                                                                //var tableName = new Table(drinkname);
                    break;
                }
                else
                {
                    Console.WriteLine("Šiuo metu tokio patiekalo neturime");
                    Console.WriteLine("Prašome pasirinkti iš esamo sąrašo");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
            return choosenDrinks;
        }
    }
}
