using System;

namespace array
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            //int[] ar = {1, 2, 3, 4, 5, 6};
            //int sum = 0;
            //for (int i = 0; i < ar.Length; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);

            //int[] ar2 = { 1, 2, 3, 4, 5, 6 };
            //int print = 0;
            //for (int i = 0; i < ar2.Length; i++)
            //{
            //    print = i;
            //    Console.WriteLine(print);
            //}

            //int[] ar2 = { 1, 2, 3, 4, 5, 6 };
            //int print = 0;
            //for (int i = ar2.Length; i > 0; i--)
            //{
            //    print = i;
            //    Console.WriteLine(print);
            //}



            //int[] ar3 = { 5, 13, 20, 30, 15, 40 };
            //int n = ar3.Length;
            //int[] yeniArr = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    yeniArr[n - 1 - i] = ar3[i];
            //}
            //for (int j = 0; j < n; j++)
            //    Console.Write(yeniArr[j]);





            //int[] ar = { 1, 2, 3, 4, 5, 6 };
            //int a = ar.Length;
            //Console.WriteLine(a);



            //int[] arSort = { 45, 7, 10, 5, 50 };
            //int sort = 0;
            //int[] paste = { arSort.Length };

            //for (int j = 0; j < arSort.Length; j++)
            //{
            //    if (arSort[i]>sort)
            //    {
            //        sort = arSort[i];
            //        sort < arSort[i];
            //        paste[i] += sort;
            //    }
            //    Console.WriteLine(sort);
            //}






            //int[] ar = { -1, -2, -3, 4, 5, 6 };
            //int menfi = 0;
            //for (int i = 0; i < ar.Length; i++)
            //{
            //    if (ar[i] < 0)
            //    {
            //        menfi += ar[i];
            //    }
            //}
            //Console.WriteLine(menfi);

            //int[] ar = { -1, -2, -3, 4, 5, 6 };
            //int musbet = 0;
            //for (int i = 0; i < ar.Length; i++)
            //{
            //    if (ar[i] > 0)
            //    {
            //        musbet += ar[i];
            //    }
            //}
            //Console.WriteLine(musbet);

            int[] kvdr = { 2, 4, 6 };
            int sa = 0;

            for (int j = 0; j < kvdr.Length; j++)
            {
                sa = kvdr[i] * kvdr[i];
                if (kvdr[i]<kvdr.Length-1)
                {
                    kvdr[i+1] = sa;
                }
             
                
                Console.WriteLine(kvdr[i]);
            }
           




        }
    }
}
