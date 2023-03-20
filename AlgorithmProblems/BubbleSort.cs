using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    public class BubbleSort
    {
        public static void Sort()
        {
            List<int> list = new List<int>() { 5, 9, 2, 3, 1, 0 };
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n*********************\n");
            for (int i = 0; i <= list.Count - 2; i++)
            {
                for (int j = 0; j <= list.Count - 2; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j + 1];
                        list[j + 1] = list[j];
                        list[j] = temp;
                    }
                }
            }
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
