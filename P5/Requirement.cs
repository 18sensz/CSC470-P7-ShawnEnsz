using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public class Requirement
    {
        public int Id { get; set; }
        public int ProjectId = -1;
        public int FeatureId = -1;
        public string Statement { get; set; }
    }
}
