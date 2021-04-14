using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFEEZBUZZ
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i <= 100; i++)
            {
                var output = "";

                if (i % 5 == 0)
                {
                    output = "Mike";
                }

                if (i % 3 == 0)
                {
                    output = "YaoMengCen";
                }

  

                if (output == "")
                {
                    string ii = Convert.ToString(i);
                    output = ii;


                }


                Console.WriteLine(output);

            }

            Console.ReadLine();

        }
    }
}
