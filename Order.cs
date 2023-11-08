using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Egzaminas_Bar_uzsakymas
{
    public class Order
    {
        private List<string> orders = new List<string>();
      
        public void Add(string choosenfood) //padavejas susiraso ka uzsisake
        {
            orders.Add(choosenfood);
        }

        Random random = new Random();

        public void CompleteOrder()
        {
            Console.WriteLine();
            Console.WriteLine(string.Join("\n", orders));
        }
        public double PayOrder()
        {
            var key = "-";
            double orderDouble = 0;
            var order = new List<double>();
            foreach (string s in orders)
            {
                int index = s.LastIndexOf(key);

                if (s.Contains(key))
                {
                    string orderSubstring = s.Substring(index + 1); //naudoju nes faile tik staliuku sarasas
                    if (double.TryParse(orderSubstring, out orderDouble))
                    {
                        order.Add(orderDouble);
                    }
                }
            }
            double totalSum = order.Sum(a => a);
            return totalSum;
        } //TryParce metodas nuskaitymas is txt failo ir bendros sumos suskaiciavimas

    
        public void TotalRecieptWithoutTips()
        {
            int randomNumber = random.Next(10000, 20000);
            var pvm = PayOrder() * 0.09;

            Console.WriteLine("Ačiū !");
            Console.WriteLine();
            Console.WriteLine($"Čekio Nr. {randomNumber}");
            Console.WriteLine(DateTime.Now);
            //Console.WriteLine($"Staliukas: {chossenTable}");
            CompleteOrder();
            Console.WriteLine();
            Console.WriteLine($"PVM 9% : {pvm}");
            Console.WriteLine();
            Console.WriteLine($"Bendra suma = {PayOrder()} eur.");
            Console.WriteLine();
        }
      
    }
}
