﻿using System;
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
            public void insert(string element)// insert a node in the binary
            {
                node tmp, parent = null, currentnode = null;
                find(element, ref parent, ref currentnode);
                if (currentnode != null)
                {
                    Console.WriteLine("Duplicate words not allowed");
                    return;
                }
                else // if the specified node is not present
                {
                    tmp = new node(element, null, null);
                    if(parent == null)
                    {
                        ROOT = tmp;
                    }
                    else if (string.Compare(element,parent.info) <0)
                    {
                        if (string.Compare(element,parent.info) <0)
                            parent.lchild = tmp;
                    }
                    else
                    {
                       parent.rchild = tmp;
                    }

                }
            }  
            private void find(string element, ref node parent, ref node currentnode)
            {
                currentnode = ROOT;
                parent = null;
                while ((currentnode != null) && (currentnode.info != null))
                {

                }
            }
        }






        static void Main(string[] args)
        {
        }
    }
}
