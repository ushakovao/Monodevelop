using System;

namespace Sort
{
    class MainClass
    {
        public static int[] BubbleSort(int[] toSort)
        {
            for (int p = 0; p < toSort.Length-1; p++)
            {
                for (int i = 0; i < toSort.Length-1; i++)
                {
                    if (toSort[i] > toSort[i + 1])
                    {
                        int temp = toSort[i];
                        toSort[i] = toSort[i + 1];
                        toSort[i + 1] = temp;
                    }
                }
             }
            return toSort;
        }


        public static void Main(string[] args)
        {
            int[] mine = new int[] { 55,4,44,33,66,22};
            BubbleSort(mine);
            foreach (int aa in mine)
                Console.Write(aa + " ");
        }
    }
}
