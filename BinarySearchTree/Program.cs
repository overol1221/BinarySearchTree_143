using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class node
    {
        public string info;
        public node lchild;
        public node rchild;

        //Constructor for the node class

        public node(string i, node l, node r)
        {
            info = i;
            lchild = l;
            rchild = r;
        }

        class BinaryThree
        {
            public node ROOT;

            public BinaryThree()
            {
                ROOT = null; // intializing root to null
            }
        }






        static void Main(string[] args)
        {
        }
    }
}
