# Sorting Visualization in C#

### Description:
This is a small project done with C# meant to show how sorting algorithms sort the data behind the scenes. Some of such examples can be often seen on YouTube, but I wanted to take a look at how this can be implemented in a relativelly simple program.

### Curent Build:
#### Simulation:
At the current stage, the program created has 4 sorting algorithms inbuilt into it.
* Bubble Sort
* Selection Sort
* Insertion Sort
* ShellSort

Mostly code for them has been refrenced from the following websites:
* https://www.geeksforgeeks.org
* http://anh.cs.luc.edu/170/notes/CSharpHtml/sorting.html

Therefore, full credit to them, as they only have been slightly modified to fit the visualization nature of this work.

#### Nuances:
At the current stage the program has been developed so that up to 135 values could be visualized in being sorted. This values is currently hardcoded and is only present, because with more information the sorting algorithms start taking a while to finish, which might be seen as an inconvenience. Additionally, with substantially more values than that, bars representing array values become complicated to draw, as they become too slim to be distinguishable from one another. 

One more questionable issue - the bars representing values that are sorted are white and swapped upside down to conventional understanding. That means that the left side represents values of the highest magnitude and right - of the lowest. This was done to solve an issue that occurred with drawing of the bars, however in the long run created this inconvenience. Overall, this does not affect how the information in how it is sorted, rather it is only an issue of getting used to reading the data in an unconventional manner.

#### Implement your sorting algorithm.
In the __Form1.cs__ class you can implement your own sorting algorithm in the methoid called _btn_Sort_Click_. The method has the following description explaining how that could be performed:

To add more sorting algorithms, it is just required to add another switch case component with a new sorting mechanism. This can be done first by adding a new sorter to the DropDown box that currently is identified as Box_Sorter. 

Afterwards the general sorting algorithm can be inserted as one of the switch cases and the following lines need to be added, when it is decided, that it is appropriate to update the data in the simulation:

```C#
this.databars = generator.generateBars(input: this.data);
UpdateDrawing(newDataBars: this.databars, originalDataBars: originalDataBars);
originalDataBars = this.databars;
Task.Delay(millisecondsDelay: 1).Wait();
```

The lines perform the following tasks:
* Line 1: when your data goes through one sorting itteration - you want to update how the DataBars in the graph look, that represent your data. The data itself should be drawn from the _this.data_ parameter saved in the class of the Form (do reference pre-existing algorithms to update your own). 
* Line 2: you update the drawing/simulation screen. Do not worry about the inputs. The reference to "originalDataBars was saved before the switch cases were implemented and is updated with the Line 3. The first input - this.databars, hopefully is the range of information that youhave prepared and performing sorting on, as you do not need to create any auxilary variables.
* Line 3: Updates your legacy datapoints after the simulation has been updated.
* Line 4: Halts the execution of the simulation/your computer, in order to allow for visualization of the data in visual steps.

#### Run the program as is
To run the program, simply navigate to the __bin__ folder -> __Release__ -> __SortingViz.exe__

#### What to expect

The program currently looks the following way:

__Insertion Sort:__
---
![](https://github.com/Si-ja/Sorting-Algorithms-Visualization---C-Sharp/blob/master/Visuals/InsertionSort.gif "Insertion Sort")

__Selection Sort:__
---
![](https://github.com/Si-ja/Sorting-Algorithms-Visualization---C-Sharp/blob/master/Visuals/SelectionSort.gif "Selection Sort")
