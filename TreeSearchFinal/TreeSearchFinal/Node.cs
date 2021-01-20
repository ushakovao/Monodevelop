using System;
using System.Collections.Generic;

namespace TreeSearchFinal
{
    public class Node
    {
        public string data;
        public Node parent;
        public List<Node> kids;


        public Node(string m_data)
        {
            data = m_data;
            parent = null;
            kids = new List<Node>();
        }


        public void AddNode(Node toAdd)
        {
            kids.Add(toAdd);
            toAdd.parent = this;
        }


        public void DeleteNode(Node toDelete)
        {
            if (!(toDelete.kids.Equals(null)))
            {

                for (int i = 0; i < toDelete.kids.Count; i++)
                {
                    toDelete.kids.RemoveAt(i);
                    kids.Remove(toDelete.kids[i]);
                }

            }
            kids.Remove(toDelete);


        }
    }
}