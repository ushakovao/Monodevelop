using NUnit.Framework;
using System;
using System.Collections.Generic;
using TreeSearch;

namespace TestTrees
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase()
        {
        }

        [Test()]
        public void MaxDepth()
        {
            TreeNode A = new TreeNode("nodeA");
            TreeNode B = new TreeNode("nodeB");
            TreeNode C = new TreeNode("nodeC");
            TreeNode D = new TreeNode("nodeD");
            TreeNode F = new TreeNode("nodeF");
            TreeNode X = new TreeNode("nodeX");
            TreeNode XX = new TreeNode("nodeXX");
            Console.WriteLine(A.kids.Count);

            A.AddNode(B);
            A.AddNode(F);
            B.AddNode(C);
            B.AddNode(D);
            D.AddNode(X);
            X.AddNode(XX);


            List<TreeNode> tree = new List<TreeNode>();

            tree.Add(A);
            tree.Add(B);
            tree.Add(C);
            tree.Add(D);
            tree.Add(F);
            tree.Add(X);
            tree.Add(XX);


            Tree newTree = new Tree(tree);



            Assert.AreEqual(4,DFS.MaxDepth(newTree, A));
           
        }

    }
}
