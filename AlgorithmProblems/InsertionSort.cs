using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    public class InsertionSort
    {
        public static void Sort()
        {
            List<string> list = new List<string>() { "Sumit", "John", "Smith", "Jack", "Snow" };
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n****************************\n");
            for (int i = 0; i <= list.Count - 1; i++)
            {
                string temp = list[i];
                int hole = i;
                while ((hole > 0) && (list[hole - 1].CompareTo(temp) > 0))
                {
                    list[hole] = list[hole - 1];
                    hole = hole - 1;
                }
                list[hole] = temp;
            }
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}