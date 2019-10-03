using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_grundlaggande_modellering_Emilie_TE17A
{
    class Program
    {
        static void Main(string[] args)
        {
            Books firstbook = new Books();
            Kunder firstkund = new Kunder();

            Console.WriteLine("What books would you like add?");

           string inputbook = Console.ReadLine();

            List<String> Book = new List<String>();
            Book.Add(inputbook);

            string input = Console.ReadLine();
            Book.Add(input);

            foreach (var user in Book)
            {
                Console.WriteLine(user);

            }
            Console.WriteLine("Sounds good, these are books you have chosen to include " + input);
            Console.WriteLine("Here is one of the book and the info about it, bur first whats the name of the book?");
            string thename = "";
            thename = firstbook.GetName();

            
            
            Console.WriteLine("Name: " + firstbook.GetName() +" Price:" +  firstbook.price + "Rarity:" + firstbook.rarity + "Actual value:" + firstbook.actualvalue + "Cursed:" + firstbook.cursed);
            Console.WriteLine("would you like to purchase this book?");
            string purchase = "";
            if(purchase == "yes")
            {
                Console.WriteLine("Lovely, it's a terrific book, my friend! ");
            }
            else if (purchase == "no")
            {
                Console.WriteLine("oh okay, bye");
            }

            Console.ReadLine();
        }
    }
}
