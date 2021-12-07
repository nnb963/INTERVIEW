using System;
using System.Collections.Generic;
using System.Linq;

namespace INTERVIEW
{
    class Program
    {
        static void Main(string[] args)
        {
            int tmp;
            List<int> lstNumber = new List<int>() { 10, 9, 3, 1, 100, 4, 101, 121, 5, 130, 140, 100, 105, 0, 11, 2, 3, 4, 78, 98, 46, 50, 67, 66, 68 };

            Console.WriteLine("Original list:");
            PrintList(lstNumber);

            List<int> lstNumberTmp = new List<int>(lstNumber); //clone list
            lstNumberTmp.Sort();
            lstNumberTmp.Reverse();

            for (int i = 20; i >= 0; i--)
            {
                tmp = lstNumberTmp[i];
                var indices = lstNumber
                                .Select((f, i) => new { f, i })
                                .Where(x => x.f == tmp)
                                .Select(x => x.i).ToList();
                foreach (var item in indices)
                {
                    lstNumber.RemoveAt(item);
                    lstNumber.Insert(0, tmp);
                }
            }

            Console.WriteLine("List sorted:");
            PrintList(lstNumber);
        }

        public static void PrintList(List<int> lst)
        {
            foreach (var item in lst)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
