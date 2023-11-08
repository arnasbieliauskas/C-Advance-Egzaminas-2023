using System.Collections.Generic;

namespace c__Egzaminas_Bar_uzsakymas
{
    internal partial class Program
    {
        static void Main(string[] args)
        {

            /*
            Kodo veikimas:
            Nustatomas info nuskaitymas is txt failo. Nuskaitymui panaudota const
            Isvedamas bendras staliuku sarasas (nuskaitomas is failo) ir suteikiamas staliuko pasirinkimas
            Sukuriu abstrakcia klase Food ir pasirasau abstraktu metoda Choose(); kuri keisiu kiekviename meniu punkte
            Pagrindinis meniu isvedamas su numeracija, o kai vartotojas issirenka, tai pasirinkimas rodomas be numeracijos
            Isvedamas čekis: čekio nr Random, tada pasirinktu patiekalu sarasas, PVM ir bendra suma.
            

            */

            // objektas kaireje  desine klase(abstrakcija) new pakeicia is abstraksijos i jau esama
            var table = new Table();//objektas            
            string chossenTable = table.ChoosTable(); // Pasirenkame staliuka

            Console.WriteLine();              //reikia statusa staliuku tvarkyti
            table.TableStatus(chossenTable);

            Thread.Sleep(1000);
            Console.Clear();
            Print.WholeMeniu(); // meniu nuskaito is failo
            Console.WriteLine();


            while (true)
            {
                Console.WriteLine("Ar pageidaujate užsisakyti? (T/N)"); //tikrinama ar norima uzsisakyti is meniu
                var orderYes = Console.ReadLine().ToLower();
                if (orderYes == "t")
                {
                    break;
                }
                else if (orderYes == "n")
                {
                    Console.WriteLine("Lauksime sugrįžtant");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Atleiskite, nesupratau Jūsų atsakymo");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
            Thread.Sleep(2000);
            Console.Clear();

            List<Food> list = new List<Food>(); // sukuriamas abstract klaseje naujas list
            list.Add(new Starters(chossenTable));
            list.Add(new Soup(chossenTable));
            list.Add(new MainDish(chossenTable));
            list.Add(new Drinks(chossenTable/*surisame su satliuko pavadinimu*/));
            list.Add(new Deserts(chossenTable));

            var order = new Order();// sukurtas naujas jau uzsaskytu produktu sarasas

            foreach (Food food in list)
            {
                var choosenfood = food.Choose(); // ta metoda kuris buvo abstract spausdins paveldetose klasese
                order.Add(choosenfood);
                Thread.Sleep(2000);
                Console.Clear();
            }
            Console.WriteLine();
            Console.WriteLine("Šiam vakarui Jūs pasirinkote: ");
            order.CompleteOrder();
            Console.WriteLine();
            IReciept reciept = new Reciept(order); //kuriamas tos klases objektas 
            reciept.PirntAndPayOrder();


        }


    }

}