using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViz
{
    /// <summary>
    /// This generator class helps with generation of randomly shuffled values that later are sorted. As well, it is responsible
    /// for generating individual databar instances, representing data arrays that are filtered and sorted.
    /// </summary>
    class Generator
    {
        DataBar databar = new DataBar();
        Field field = new Field();

        /// <summary>
        /// This method generates as many integer values as required for running of the sorting simulations. The class is responsible
        /// for generating the values and shuffling them.
        /// </summary>
        /// <param name="range">Range defines the interval up to which the random values need to be created. Essentially the values
        /// of integers will be created from 1 to range.</param>
        /// <returns>The method returns a List of shuffled integers with which the sorting can be performed</returns>
        public List<int> generateValues(int range)
        {
            // Prepare a number of values to use in the simulation
            List<int> output = new List<int>();
            for (int i = 1; i <= range; i++)
            {
                output.Add(i);
            }
            // Make sure to shuffle our values, to position them in a random order from the start
            output = shuffleValues(input: output);
            return output;
        }

        /// <summary>
        /// This is a helper method, that allows the "generateValues" method to shuffle all the values as randomly as possible.
        /// </summary>
        /// <param name="input">It is required to be indicated what List of integers needs to be shuffled.</param>
        /// <returns>The method returns a shuffled compared to the original input List of integers.</returns>
        private static List<int> shuffleValues(List<int> input)
        {
            // Shuffle the values generator in a random order
            Random rng = new Random();
            List<int> output = new List<int>();
            int itterations = input.Count();
            for (int i = 0; i < itterations; i++)
            {
                int idx = rng.Next(minValue: 0, maxValue: input.Count());
                output.Add(input[idx]);
                input.RemoveAt(index: idx);
            }
            return output;
        }

        /// <summary>
        /// Generate a set of bars that will be available for visualization as the shuffling will go on.
        /// As well prepare them in an already shuffled state. This just saves a bit on the resources. 
        /// </summary>
        /// <param name="input">List of integers which are desired to be converted into the format that will fit the visualization requirements.</param>
        /// <returns>A List of DataBars is returned, which can be visualized in the simulation instance.</returns>
        public List<DataBar> generateBars(List<int> input)
        {
            // Generate first each bar with their own unique information and put everything into a List
            float amount = (float) input.Count();
            float bar_width = field.width / amount;
            float starting_y = field.y;
            List<DataBar> output = new List<DataBar>();
            for (int i = 0; i < amount; i++)
            {
                DataBar new_bar = new DataBar();
                new_bar.x = (field.x + field.width) - bar_width * (i + 1);
                new_bar.y = starting_y;
                new_bar.height = (input[i] / amount) * field.height;
                new_bar.width = bar_width;
                output.Add(new_bar);
            }
            return output;
        }
    }
}
