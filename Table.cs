using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Egzaminas_Bar_uzsakymas
{
    public class Table
    {
        public string ChoosTable()
        {
            string choosenTableName = null;
            Console.Clear();

            int totalDrinksIndex = Print.PrintTableListFromFile().Count(); //nustatau kokio ilgio yra Listas
            Console.Clear();
            int tableChoose = 0;

            var fromFileTable = Print.ChooseTabeWithoutNumberOnMeniu();

            while (true)
            {
                Console.WriteLine("Kuri staliuka norite uzsakyti");
                Console.WriteLine();
                Print.PrintTableListFromFile();
                Console.WriteLine();
                Console.WriteLine("Pasirinkite staliuka");
                var tablename = Console.ReadLine();
                Console.WriteLine();

                if (int.TryParse(tablename, out tableChoose) && (tableChoose - 1) >= 0 && (tableChoose - 1) <= totalDrinksIndex) // tikrinam ar atitinka salygas
                {
                    choosenTableName = fromFileTable[tableChoose - 1];
                    Console.WriteLine($"Pasirinktas -- {fromFileTable[tableChoose - 1]} -- satliukas");                   // pagal vartotojo ivesti isvedam satliuko pavadinima
                    Console.WriteLine();
                    break;
                }
                else
                {

                    Console.WriteLine("Siuo metu tokio staliuko neturime");
                    Console.WriteLine("Prasome pasirinkti esama staliuka");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
            return choosenTableName;
        } //yra idetas while ciklas tam kad pasirinktu tinkama is saraso

        public void TableStatus(string choosenTableName)
        {

            var newOpentable = Print.ChooseTabeWithoutNumberOnMeniu();
            //var openTable = new List<string>();
            //openTable.ForEach(a => Console.WriteLine($"{a} laisvas"));

            foreach (var table in newOpentable)
            {
                if (table.Contains(choosenTableName))
                {
                    Console.WriteLine($"{choosenTableName} užimtas");
                }
                else
                {
                    Console.WriteLine($"{table} laisvas");
                }
            }



        }

    }
}




