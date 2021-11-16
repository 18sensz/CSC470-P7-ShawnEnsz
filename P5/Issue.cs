using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public class Issue
    {
        public int Id;
        public int ProjectId;
        public string Title;
        public DateTime DiscoveryDate;
        public string Discoverer;
        public string InitialDescription;
        public string Component;
        public int IssueStatusId;
    }
}
