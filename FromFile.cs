using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace c__Egzaminas_Bar_uzsakymas
{
    public class FromFile
    {
        const string tablePath = "tableList.txt";  // constanta kelias nesikeis
        const string meniuPath = "meniu.txt";

        public List<string>  ReadTableListFromFile()
        {
            var listOfTables  = new List<string>();
          
            try
            {
                List<string> readFromFile = File.ReadAllLines(tablePath).ToList();    
                foreach (string line in readFromFile)
                {
                    listOfTables.Add(line);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("failas nenuskaitytas");
            }
           return listOfTables;
        } // nuskaitome faila

        public List<string> ReadMeniuListFromFile()
        {
            var listOfTables = new List<string>();
            try
            {
                List<string> readFromFile = File.ReadAllLines(meniuPath).ToList();
                foreach (string line in readFromFile)
                {
                    listOfTables.Add(line);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("failas nenuskaitytas");
            }
            return listOfTables;
        } // nuskaitome faila




    }
}
