using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Egzaminas_Bar_uzsakymas
{
    internal class Deserts : Food
    {
        private readonly string _chossenTable;

        public Deserts(string chossenTable)
        {
            _chossenTable = chossenTable;
        }

        public override string Choose()
        {
         
            string choosenDesert = null;

            int totaDesertIndex = Print.DesertDishMeniu().Count(); //nustatau kokio ilgio yra Listas
            int desertChoose = 0;
            var desertMeniuWithoutNumbers = Print.DesertMeniuWithoutNumber();   //gerimu sarasas be numeracijos tam kad parodytu pasirinkima
            var fromFileDesert = Print.DesertDishMeniu();


            while (true)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Gal sudominsiu desrtu?");
                Console.WriteLine();
                List<string> desertMenu = Print.DesertDishMeniu();
                foreach (string desert in desertMenu)
                {
                    Console.WriteLine(desert);
                }
                Console.WriteLine();
                Console.WriteLine("Prašom pasirinkti");
                var desertName = Console.ReadLine();

                if (int.TryParse(desertName, out desertChoose) && desertChoose >= 0 && desertChoose <= totaDesertIndex) // tikrinam ar atitinka salygas
                {
                    choosenDesert = fromFileDesert[desertChoose];
                    Console.WriteLine($"Pasirinktas -- {desertMeniuWithoutNumbers[desertChoose]} -- desertas");                   // pagal vartotojo ivesti isvedam satliuko pavadinima
                                                                                                                                               //var tableName = new Table(desertName);
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
            return choosenDesert;
        }
    
    }
}
