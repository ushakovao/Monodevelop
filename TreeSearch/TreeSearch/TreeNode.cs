using System.Collections.Generic;

namespace TreeSearch
{
    public class TreeNode
    {

        public string data; //node data
        public List<TreeNode> kids;
        public TreeNode parent;//parent link
        public Tree tree;

        public TreeNode(string m_data)
        {
            data = m_data;
            kids = null;
            parent = null;
            kids = new List<TreeNode>();
            tree = new Tree(kids);
        }


        public void AddNode(TreeNode toAdd)
        {
            kids.Add(toAdd);
            toAdd.parent = this;

        }

        public void DeleteNode(TreeNode toDelete)
        {
           
            if   (!toDelete.kids.Equals(null) )
            {

              for (int i=0; i<toDelete.kids.Count; i++)
                {

                    toDelete.kids.RemoveAt(i);
                    kids.Remove(toDelete.kids[i]);

                }

            }
            kids.Remove(toDelete);
        }

    }

}