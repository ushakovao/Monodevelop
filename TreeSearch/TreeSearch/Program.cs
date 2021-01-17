using System;
using System.Collections.Generic;

namespace TreeSearch
{
    class MainClass
    {


        public static void Main(string[] args)
        {

            TreeNode A = new TreeNode("nodeA");
            TreeNode B = new TreeNode("nodeB");
            TreeNode C = new TreeNode("nodeC");
            TreeNode D = new TreeNode("nodeD");
            TreeNode F = new TreeNode("nodeF");
            TreeNode X = new TreeNode("nodeX");
            Console.WriteLine(A.kids.Count);

            A.AddNode(B);
            A.AddNode(F);
            B.AddNode(C);
            B.AddNode(D);
            D.AddNode(X);


            List<TreeNode> tree = new List<TreeNode>();

            tree.Add(A);
            tree.Add(B);
            tree.Add(C);
            tree.Add(D);
            tree.Add(F);
            tree.Add(X);


            Tree newTree =new Tree(tree);

            Console.WriteLine("*******NewTree is *******");

            foreach (TreeNode t in newTree.nodes)
            {
                Console.WriteLine("NewTree is " + t.data);
            }
            Console.WriteLine("*******!!!!*******");

                
                
           // Console.WriteLine(" Deleting ************** ");


           // newTree.DeleteNode(B);
           // A.DeleteNode(B);
           // Console.WriteLine("After Deleting ************** ");




            Console.WriteLine("*******NewTree is *******");
            foreach (TreeNode t in newTree.nodes)
            {
                Console.WriteLine("NewTree is " + t.data);
            }
            Console.WriteLine("*******!!!!*******");


            DFS search = new DFS();
            DFS.DFS_search(newTree, A);
            DFS.MaxDepth(newTree, A);

           // DFS.DWS(newTree, A);

            
         

        }

    }

}




