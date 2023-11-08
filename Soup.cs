using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Egzaminas_Bar_uzsakymas
{
    internal class Soup : Food
    {
        private readonly string _chossenTable; //pririsamas prie stalo vardo 

        public Soup(string chossenTable)
        {
            _chossenTable = chossenTable;
        }

        public override string Choose()
        {
            string choosenSoup = null;

            int totalSoupIndex = Print.SoupMeniu().Count(); //nustatau kokio ilgio yra Listas
            int soupChoose = 0;
            var soupsMeniuWithoutNumbers = Print.SoupMeniuWithoutNumber();   //gerimu sarasas be numeracijos tam kad parodytu pasirinkima
            var fromFileDrinks = Print.SoupMeniu();


            while (true)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Gal sriubos?");
                Console.WriteLine();
                List<string> drinksMenu = Print.SoupMeniu();
                foreach (string drink in drinksMenu)
                {
                    Console.WriteLine(drink);
                }
                Console.WriteLine();
                Console.WriteLine("Kokią sriubą pageidaujate?");
                var soupName = Console.ReadLine();

                if (int.TryParse(soupName, out soupChoose) && soupChoose >= 0 && soupChoose <= totalSoupIndex) // tikrinam ar atitinka salygas
                {
                    choosenSoup = fromFileDrinks[soupChoose];
                    Console.WriteLine($"Pasirinkta -- {soupsMeniuWithoutNumbers[soupChoose]} -- sriuba");                   // pagal vartotojo ivesti isvedam satliuko pavadinima
                                                                                                                                //var tableName = new Table(soupName);
                    break;
                }
                else
                {
                    Console.WriteLine("Šiuo metu tokios sriubos neturime");
                    Console.WriteLine("Prašome pasirinkti iš esamo sąrašo");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
            return choosenSoup;
        }
    }
}
