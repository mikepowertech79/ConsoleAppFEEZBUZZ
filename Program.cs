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




            int[] a = {2, 5, 112, 2342, 8, 1, 4, 6};

            foreach (var i in a)
            {
                string stringVar = i.ToString();
                 
                Console.Write(stringVar + " ");
            }

            int t;

            for (int i = 0; i <= a.Length -2 ; i++)
            {
                for (int j = 0; j <= a.Length - 2; j++)
                { 
                    if (a[j] > a[j+1])
                    {
                        t = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = t;
                    }
                }
            }

            Console.Write("\n");

            foreach (var i in a)
            {
                string stringVar = i.ToString();

                Console.Write(stringVar + " ");
            }



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
