using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingViz
{
    public partial class Form1 : Form
    {
        Field field = new Field();
        List<int> data = new List<int>();
        List<DataBar> databars = new List<DataBar>();

        /// <summary>
        /// Initiate the main form and allow for Double Buffering to reduce the flickering when elements are drawn on the form.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Do nothing, just load the form
        }

        /// <summary>
        /// Create the original instance of the field where the simulation will be ran...It's just a black box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Field field = new Field();
            Graphics g = e.Graphics;
            Brush myBlackBrush = new SolidBrush(color: Color.Black);
            g.FillRectangle(brush: myBlackBrush, x: field.x, y: field.y, width: field.width, height: field.height);
        }

        /// <summary>
        /// Method that calls the button to generate data with which the simulations can be ran.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Generate_Click(object sender, EventArgs e)
        {
            // Button that initiates the generation of the Values for the simulation and of the field

            // Prepare the information that needs to be pre-processed - range in how big we want operate in
            int simulation_quantity = Convert.ToInt16(UpDown_Quantity.Value);

            // First generate the values. Use help of the Generator class
            Generator generator = new Generator();
            // Clean any data if it is still stored
            this.data.Clear();
            this.databars.Clear();

            this.data = generator.generateValues(range: simulation_quantity); ;
            this.databars = generator.generateBars(input: data);

            Graphics g = this.CreateGraphics();
            Brush myWhiteBrush = new SolidBrush(color: Color.White);
            Brush myBlackBrush = new SolidBrush(color: Color.Black);
            g.FillRectangle(brush: myBlackBrush, x: this.field.x, y: this.field.y, width: this.field.width, height: this.field.height);
            foreach (DataBar databar in this.databars)
            {               
                g.FillRectangle(brush: myWhiteBrush, x: databar.x, y: databar.y, width: databar.width - 1, height: databar.height);
            }
        }

        /// <summary>
        /// The button allows for sorting of the information that has been prepared earler. More sorting algorithms can be implemented here.
        /// Most of them are simple algorithms referenced from: https://www.geeksforgeeks.org and http://anh.cs.luc.edu/170/notes/CSharpHtml/sorting.html
        /// To add more, it is just required to add another switch case component with a new sorting mechanism. This can be done in the DropDown box that
        /// currently is identified as Box_Sorter. Afterwards the general sorting algorithm can be inserted as one of the switch cases and the following lines
        /// need to be added, when it is decided, that it is appropriate to update the data in the simulation:
        /// 
        /// this.databars = generator.generateBars(input: this.data);
        /// UpdateDrawing(newDataBars: this.databars, originalDataBars: originalDataBars);
        /// originalDataBars = this.databars;
        /// Task.Delay(millisecondsDelay: 1).Wait();
        /// 
        /// The lines perform the following tasks:
        /// Line 1: when your data goes through one sorting itteration - you want to update how the DataBars in the graph look, that represent your data
        /// Line 2: you update the drawing/simulation screen. Do not worry about the inputs. The reference to "originalDataBars was saved before the switch
        ///         cases were implemented and is updated with the Line 3. The first input - this.databars, hopefully is the range of information that you
        ///         have prepared and performing sorting on, as you do not need to create any auxilary variables.
        /// Line 3: Updates your legacy datapoints after the simulation has been updated.
        /// Line 4: Halts the execution of the simulation/your computer, in order to allow for visualization of the data.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Sort_Click(object sender, EventArgs e)
        {
            String sorter = Box_Sorters.Text;
            // Find which sorter the user wants to see used
            Generator generator = new Generator();
            Graphics g = this.CreateGraphics();
            Brush myWhiteBrush = new SolidBrush(color: Color.White);
            Brush myBlackBrush = new SolidBrush(color: Color.Black);
            List<DataBar> originalDataBars = this.databars;

            // If no data has been generated, then to avoid issues and errors - just stop the whole process.
            if (this.data.Count == 0 || this.databars.Count == 0)
            {
                return;
            }

            switch (sorter)
            {
                case "Bubble Sort":
                    // Perform a bubble sort
                    for (int p = 0; p <= this.data.Count - 2; p++)
                    {
                        for (int i = 0; i <= this.data.Count - 2; i++)
                        {
                            if (this.data[i] > this.data[i + 1])
                            {
                                int temp;
                                temp = this.data[i + 1];
                                this.data[i + 1] = this.data[i];
                                this.data[i] = temp;
                                this.databars = generator.generateBars(input: this.data);
                                UpdateDrawing(newDataBars: this.databars, originalDataBars: originalDataBars);
                                originalDataBars = this.databars;
                                Task.Delay(millisecondsDelay: 1).Wait();
                            }
                        }
                    }
                    break;

                case "Selection Sort":
                    // Perform a selection sort
                    for (int i = 0; i < this.data.Count - 1; i++)
                    {
                        int temp;
                        int smallest = i;
                        for (int j = i + 1; j < this.data.Count; j++)
                        {
                            if (this.data[j] < this.data[smallest])
                            {
                                smallest = j;
                            }
                        }
                        temp = this.data[smallest];
                        this.data[smallest] = this.data[i];
                        this.data[i] = temp;
                        this.databars = generator.generateBars(input: this.data);
                        UpdateDrawing(newDataBars: this.databars, originalDataBars: originalDataBars);
                        originalDataBars = this.databars;
                        Task.Delay(millisecondsDelay: 100).Wait();
                    }
                    break;

                case "Insertion Sort":
                    // Perform an insertion sort
                    for (int i = 1; i < this.data.Count; i++)
                    {
                        var key = this.data[i];
                        int j = i - 1;
                        while (j >= 0 && this.data[j] > key)
                        {
                            this.data[j + 1] = this.data[j];
                            j -= 1;
                            this.databars = generator.generateBars(input: this.data);
                            UpdateDrawing(newDataBars: this.databars, originalDataBars: originalDataBars);
                            originalDataBars = this.databars;
                            Task.Delay(millisecondsDelay: 1).Wait();
                        }
                        this.data[j + 1] = key;
                        this.databars = generator.generateBars(input: this.data);
                        UpdateDrawing(newDataBars: this.databars, originalDataBars: originalDataBars);
                        originalDataBars = this.databars;
                    }
                    break;

                case "ShellSort":
                    //Perform shellSort
                    for (int gap = this.data.Count / 2; gap > 0; gap /= 2)
                    {
                        for (int i = gap; i < this.data.Count; i += 1)
                        {
                            int temp = this.data[i];
                            int j;
                            for (j = i; j >= gap && this.data[j - gap] > temp; j -= gap)
                            {
                                this.data[j] = this.data[j - gap];
                                this.databars = generator.generateBars(input: this.data);
                                UpdateDrawing(newDataBars: this.databars, originalDataBars: originalDataBars);
                                originalDataBars = this.databars;
                                Task.Delay(millisecondsDelay: 1).Wait();
                            }
                            this.data[j] = temp;
                            this.databars = generator.generateBars(input: this.data);
                            UpdateDrawing(newDataBars: this.databars, originalDataBars: originalDataBars);
                            originalDataBars = this.databars;
                            Task.Delay(millisecondsDelay: 1).Wait();
                        }
                    }
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// This method helps re-draw what is going on in the simulation. It was optimized partially, in order only update those databars that
        /// have changed from one step before. This is done so not the whole screen of information needs to be re-drawn from scratch, saving on
        /// memory, processing, and most importantly - not causing seizure to your users with insane flickering of the screen.
        /// </summary>
        /// <param name="newDataBars">Current instance of databars and their information.</param>
        /// <param name="originalDataBars">Instance in time before the current of your databars and their information.</param>
        public void UpdateDrawing(List<DataBar> newDataBars, List<DataBar> originalDataBars)
        {
            Field field = new Field();
            Graphics g = this.CreateGraphics();
            Brush myWhiteBrush = new SolidBrush(color: Color.White);
            Brush myBlackBrush = new SolidBrush(color: Color.Black);
            for (int idx = 0; idx < this.databars.Count(); idx++)
            {
                if (newDataBars[idx].height != originalDataBars[idx].height)
                {
                    g.FillRectangle(brush: myBlackBrush, x: newDataBars[idx].x, y: this.field.y, width: newDataBars[idx].width, height: this.field.height);
                    g.FillRectangle(brush: myWhiteBrush, x: newDataBars[idx].x, y: newDataBars[idx].y, width: newDataBars[idx].width - 1, height: newDataBars[idx].height);
                }
            }
        }
    }
}
