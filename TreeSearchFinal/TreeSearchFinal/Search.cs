using System;
using System.Collections.Generic;

namespace TreeSearchFinal
{
    public class Search
    {
        //Depth DFS
        //Width
        //Max or Min depth
        static List<Node> visitedA = new List<Node>();
        public void DS(Tree tree, Node toStart)
        {
            visitedA.Add(toStart);
            foreach (Node t in tree.nodes)
            {
                if (!(visitedA.Contains(t))){
                    DS(tree, t);
                }

            }
        }



        public Search()
        {
        }
    }
}
