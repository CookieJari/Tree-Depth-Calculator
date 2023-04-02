using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Branch
    {
        List<Branch> branches = new List<Branch>();

        public void AddBranch(Branch branch)
        {
            branches.Add(branch);
        }

        // Doing a Depth First search
        public int GetDepth(Branch branchInp)
        {
            // We first check if this node is the end
            if (branchInp.branches.Count <= 0) 
            {
                return 1;
            }
            // If its not at the end we loop through all its children
            else
            {
                // To keep track of the maximum depth
                int maxDepth = 0;
                // We loop through its children and call this function again so we can see its children's maximum depth first
                for (int i = 0; i < branchInp.branches.Count; i++)
                {
                    int temp = branches[i].GetDepth(branches[i]);
                    if (temp>=maxDepth)
                    {
                        maxDepth = temp;
                    }
                }
                // After looping through its children we then add the depth of this node as well
                maxDepth += 1;
                return maxDepth;
            }
            
        }
    }

    
}
