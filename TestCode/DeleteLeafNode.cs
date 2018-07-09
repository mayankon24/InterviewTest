using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    public class DeleteLeafNode
    {
        public void run()
        {
            node root = new node();
            root.value = 4;

            root.left = new node(5);
            root.right = new node(5);

            root.left.left = new node(3);
            root.left.right = new node(1);

            root.right.left = new node(5);

            DeleteNode(root, 5);
        }

        public void DeleteNode(node Root, int K)
        {
            if (Root == null)
            {
                return ;
            }

            DeleteNode(Root.left, K);
            DeleteNode(Root.right, K);
            
            if (Root.left == null && Root.right == null && Root.value == K)
            {
                Root = null;
            }
        }
    }

    public class node
    {
        public int value;
        public node left;
        public node right;

        public node()
        {
            left = null;
            right = null;
        }

        public node(int N)
        {
            value = N;
            left = null;
            right = null;
        }
    }
}
