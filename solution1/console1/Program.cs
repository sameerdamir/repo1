using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console1
{
    class Program
    {
        public static void ToPrint()
        {
	// here you go 
        }

        static void Main(string[] args)
        {
           Program.ToPrint();
            Program p1 = new Program();
            System.Diagnostics.Debug.WriteLine(p1);
            Console.ReadLine();
        }
    }
}
