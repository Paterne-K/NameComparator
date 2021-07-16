using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NameComparator.Models
{
    public class InputStringDetails
    {
        /// <summary>
        /// The first name to compare
        /// </summary>
        public string Name1 { get; set; }
        /// <summary>
        /// The second name to compare
        /// </summary>
        public string Name2 { get; set; }
        /// <summary>
        /// The threshold for the comparison (For jaro winkler)
        /// </summary>
        public int Threshold { get; set; }
    }
}
