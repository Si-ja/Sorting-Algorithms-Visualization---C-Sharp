using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViz
{
    /// <summary>
    /// This class allows for the creationg of the field in which the visualization will be taking place.
    /// The field can be modified, which will modify the performance of the bars of data in it as well. However,
    /// it does hold also pre-determined parameters, that so far were seen as the better fitting for the enviornmnet
    /// that has been created for visualization purposes. The field has X and Y staring coordinates and parameters for
    /// field width and height.
    /// </summary>
    class Field
    {
        public float x { get; set; } = 50;  // Where the field is located on the X axis
        public float y { get; set; } = 100; // Where the fields is located on the Y axis
        public float width { get; set; } = 320f;  // How wide the field is
        public float height { get; set; } = 200f; // How highe is the field
    }
}
