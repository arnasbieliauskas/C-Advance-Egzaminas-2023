namespace c__Egzaminas_Bar_uzsakymas
{
    internal partial class Program
    {
        public class Reciept : IReciept     // servisine klase paveldi is interface
        {
           
            private readonly Order order; //paduodama info is Order klases

            public Reciept(Order order)
            {
                this.order = order;
            }

            public void PirntAndPayOrder()
            {
               
                Console.WriteLine($"Jūsu sąskaitos galutinė suma: {order.PayOrder()} eur.");

                while (true)
                {
                    Console.WriteLine("Ar pageidausite saskaitos? T/N");
                    var checkPlease = Console.ReadLine().ToLower();
                    if (checkPlease == "t")
                    {
                         order.TotalRecieptWithoutTips();   
                    }
                    else if (checkPlease == "n")
                    {
                        Console.WriteLine("Praneškite kada norėsite saskaitos");     
                    }        
                    else
                    {
                        Console.WriteLine("Atleiskite, nesupratau Jūsų atsakymo");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                }
            }
      
        }


    }

}