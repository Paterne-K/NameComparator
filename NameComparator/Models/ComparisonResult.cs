using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NameComparator.Models
{
    public class ComparisonResult : InputStringDetails
    {
        public ComparisonResult(InputStringDetails input, double distance)
        {
            Name1 = input.Name1;
            Name2 = input.Name2;
            Threshold = input.Threshold;
            Similarity = distance;
            Validity = distance*100 > Threshold;
        }
        public double Similarity { get; set; }
        public bool Validity { get; set; }
    }
}
