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
                    parent = currentnode;
                    if (string.Compare(element, parent.info) < 0)
                        currentnode = currentnode.rchild;
                    else
                        currentnode = currentnode.lchild;
                }
            }

            public void inorder(node ptr)
            {
                if(ROOT == null)
                {
                    Console.WriteLine(" tree is empty");
                    return;
                }
                if (ptr != null)
                {
                    inorder(ptr.lchild);
                    Console.WriteLine(ptr.info + "");
                    inorder(ptr.rchild);
                }
            }

            public void preorder(node ptr)
            {
                if(ROOT == null)
                {
                    Console.WriteLine(ptr.info + "");
                    preorder(ptr.lchild);
                    preorder(ptr.rchild);
                }
            }
            public void postorder(node ptr)
            {
                if (ROOT != null)
                {
                    postorder(ptr.lchild);
                    postorder(ptr.rchild);
                    Console.WriteLine(ptr.info + "");
                }
            }

            static void Main(string[] args)
            {
                BinaryThree x = new BinaryThree();
                while(true)
                {
                    Console.WriteLine("\n Menu");
                    Console.WriteLine("1. implement insert operation ");
                    Console.WriteLine("2. perfom inorder traversal");
                    Console.WriteLine("3. perfom preorder traversal");
                    Console.WriteLine("4. perfom postorder traversal");
                    Console.WriteLine("5. exit");
                    Console.Write("\nEnter your choice (1-5 ");
                    char ch = Convert.ToChar(Console.ReadLine());
                    switch (ch)
                    {

                    }
                }
            }
        }
    }

}







