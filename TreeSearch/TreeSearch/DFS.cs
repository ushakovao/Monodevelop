using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeSearch
{
    public class DFS
    {


        static List<TreeNode> visitedA = new List<TreeNode>();

        public static void DFS_search(Tree tree, TreeNode toStart)
            {

            visitedA.Add(toStart);
            Console.WriteLine("Here goes the tree : " + toStart);
            foreach (TreeNode t in tree.nodes)
            {
                if (!(visitedA.Contains(t))) {           
                DFS_search(tree, t);
                }
            }


        }

        static List<int> counts = new List<int>();
        public static int MaxDepth(Tree tree, TreeNode toStart)
        {
      
            TreeNode temp = toStart;
            DFS.DFS_search(tree, temp);

            for (int i = 0; i < visitedA.Count; i++)
            {
                int count = 0;

                if (visitedA[i].parent == null)
                {
                    continue; 
                }

                while (!(visitedA[i].parent == null))
                {
                    count++;
                    counts.Add(count);
                    Console.WriteLine("count : " + count);
                    visitedA[i] = visitedA[i].parent;
                }

            }

            Console.WriteLine("Max " + counts.Max());
            return counts.Max();

        }







        static List<TreeNode> visitedB = new List<TreeNode>();
        public static void DWS(Tree tree, TreeNode toStart)
        {
            visitedB.Add(toStart);


            if (tree.nodes.Contains(toStart) && (!(toStart.kids.Count==0)))
            {
                Console.WriteLine("Here the node: " + toStart.data);

                for (int i = 0; i < toStart.kids.Count; i++)
                {

                    if ((!(visitedB.Contains(toStart.kids[i]))) && (tree.nodes.Contains(toStart.kids[i])))
                    {

                        Console.WriteLine("Here the " + toStart.data +" kids: " + toStart.kids[i].data);

                    }

                }
                for (int i = 0; i < toStart.kids.Count; i++)
                {
                    DWS(tree, toStart.kids[i]);
                } 

            }
        }





        public static void Fibo(int nb)
        {
            int first = 0;
            int second = 1;

            int[] fib = new int[nb];

            fib[0] = first;
            fib[1] = second;

            for (int i = 2; i < nb; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
                Console.WriteLine("I is " + i + "and Fib is" + fib[i]);
            }

            Console.WriteLine(fib.Length);
            Console.WriteLine("My {0}'th memeber is {1}", nb, fib[nb-1]);

        }


        public DFS()
        {
        }

}
}
