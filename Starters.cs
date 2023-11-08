using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Egzaminas_Bar_uzsakymas
{
    internal class Starters : Food
    {
        private readonly string _chossenTable; // pririsam prie staliuko pavadinimo

        public Starters(string chossenTable)
        {
            _chossenTable = chossenTable;
        }

        public override string Choose()
        {
       
            string choosenStarters = null;

            int totalDrinkIndex = Print.StarterMeniu().Count(); //nustatau kokio ilgio yra Listas
            int drinkChoose = 0;
            var starterMeniuWithoutNumbers = Print.StarterMeniuWithoutNumber();   //gerimu sarasas be numeracijos tam kad parodytu pasirinkima
            var fromFileDrinks = Print.StarterMeniu();


            while (true)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Ar norėsite užkandžių?");
                Console.WriteLine();
                List<string> drinksMenu = Print.StarterMeniu();
                foreach (string drink in drinksMenu)
                {
                    Console.WriteLine(drink);
                }
                Console.WriteLine();
                Console.WriteLine("Psirinkite užkandį");
                var drinkname = Console.ReadLine();

                if (int.TryParse(drinkname, out drinkChoose) && drinkChoose >= 0 && drinkChoose <= totalDrinkIndex) // tikrinam ar atitinka salygas
                {
                    choosenStarters = fromFileDrinks[drinkChoose];
                    Console.WriteLine($"Pasirinktas -- {starterMeniuWithoutNumbers[drinkChoose]} -- užkandis");                   // pagal vartotojo ivesti isvedam satliuko pavadinima
                                                                                                                                //var tableName = new Table(drinkname);
                    break;
                }
                else
                {
                    Console.WriteLine("Šiuo metu tokio užkandžio neturime");
                    Console.WriteLine("Prašome pasirinkti iš esamo sąrašo");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
            return choosenStarters;
        }
    }
    
}
