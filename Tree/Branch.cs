using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Branch
    {
        List<Branch> branches;

        public void AddBranch(Branch branch)
        {
            branches.Add(branch);
        }
    }
}
