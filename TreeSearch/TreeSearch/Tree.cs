using System;
using System.Collections.Generic;

namespace TreeSearch
{
    public class Tree
    {
        public List<TreeNode> nodes;

        public Tree(List<TreeNode> Nodes)
        {
            nodes = new List<TreeNode>();
            nodes = Nodes;
        }






        public void DeleteNode(TreeNode toDelete)
        {

            if (!toDelete.kids.Equals(null))
            {
                for (int i = 0; i < toDelete.kids.Count; i++)
                {
                    nodes.Remove(toDelete.kids[i]);

                }

            }
            nodes.Remove(toDelete);

            toDelete.DeleteNode(toDelete);
        }

    }
}

