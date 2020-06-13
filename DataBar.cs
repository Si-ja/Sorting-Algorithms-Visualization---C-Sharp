using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SortingViz
{
    /// <summary>
    /// This class allows for a creation of individual databars. Parameters include - their starting X and Y coordinates and width and height.
    /// </summary>
    public class DataBar
    {
        public float height { get; set; } = 0;   // Height of the bar
        public float width { get; set; } = 0;    // Width of the bar
        public float x { get; set; } = 0;        // Position x at which the bar starts
        public float y { get; set; } = 0;        // Position y at which the bar starts (usually fixed to the value of the field where it is displayed)
    }
}
