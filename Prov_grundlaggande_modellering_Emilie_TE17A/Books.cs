using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_grundlaggande_modellering_Emilie_TE17A
{
    class Books
    {


        static Random generator = new Random();
        public int price = generator.Next(10, 100);
        private string name = "";
        public string GetName()
        {
            return name;
        }
        public int rarity = generator.Next(1, 10);
        public int actualvalue = generator.Next(10, 100);
        public string category = Console.ReadLine();
        
        public bool cursed = true;

   

    }
}
