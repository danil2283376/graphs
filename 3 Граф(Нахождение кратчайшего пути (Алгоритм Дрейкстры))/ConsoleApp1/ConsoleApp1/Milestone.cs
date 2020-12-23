using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Milestone
    {
        public string name { get; set; }
        public int costs { get; set; }

        public string[] parrent;

        public Milestone(string name, int costs, string[] parrent)
        {
            this.name = name;
            this.costs = costs;
            this.parrent = parrent;
        }
    }
}
