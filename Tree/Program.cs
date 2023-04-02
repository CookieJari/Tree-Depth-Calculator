using System;

namespace Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating all 10 nodes
            Branch root = new Branch();
            Branch branch1 = new Branch();
            Branch branch2 = new Branch();
            Branch branch3 = new Branch();
            Branch branch4 = new Branch();
            Branch branch5 = new Branch();
            Branch branch6 = new Branch();
            Branch branch7 = new Branch();
            Branch branch8 = new Branch();
            Branch branch9 = new Branch();
            Branch branch10 = new Branch();

            // Connecting the nodes to each other
            root.AddBranch(branch1);
            root.AddBranch(branch2);

            branch1.AddBranch(branch3);
            branch2.AddBranch(branch4);
            branch2.AddBranch(branch5);
            branch2.AddBranch(branch6);

            branch4.AddBranch(branch7);
            branch5.AddBranch(branch8);
            branch5.AddBranch(branch9);

            branch8.AddBranch(branch10);

            // Get the depth of the tree from this node (root node)
            int ans = root.GetDepth(root);

            Console.WriteLine("FINAL DEPTH: " + ans);      
        }
    }
}