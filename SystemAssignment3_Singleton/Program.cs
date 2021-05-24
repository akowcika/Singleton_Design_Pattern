using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SystemAssignment3_Singleton
{
    class Program
    {
        private static void Main(string[] args)
        {
            Singleton Board1 = Singleton.GetInstance;
            Board1.PrintDetails("2 Players");

            Singleton Board2 = Singleton.GetInstance;
            Board2.PrintDetails("4 Players");
            Console.ReadLine();

            
        }
    }
}
