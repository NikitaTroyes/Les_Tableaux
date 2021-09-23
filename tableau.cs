using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_Tableaux
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] table1 = new int[] { 10, 5, 6 };
            int[] table2 = new int[] { 5, 3, 9 };
       

            Console.WriteLine("tableau 1 : ");
            for (int j = 0; j < table1.Length; j++)

            {
                Console.WriteLine("n° " + (j + 1) + ":" + table1[j]);
            }


            Console.WriteLine();
            Console.WriteLine("tableau 2 : ");

            for (int j = 0; j < table2.Length; j++)

            {
                Console.WriteLine("n° " + (j + 1) + ":" + table2[j]);

            }

            Console.WriteLine();
            Console.WriteLine("tableau 3 : ");
            int[] table3 = CreerTable3(table1,table2);

            for (int i = 0; i < (table1.Length + table2.Length); i++)
            {
                Console.WriteLine("n° " + (i+ 1) + ":" + table3[i]);

            }



            Console.ReadLine();
        }

        static int[] CreerTable3(int[] table1, int[] table2 )
        {

            int[] table3 = new int[table1.Length + table2.Length]; 
          for (int i = 0; i< table1.Length; i++)
            {
                table3[i] = table1[i];
            }

            int indice = table1.Length;
          foreach ( int i in table2)
            {
                table3[indice] = i;
                indice++; 
            }
            return table3;
        }
        }
}
    





