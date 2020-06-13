namespace SortingViz
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Title = new System.Windows.Forms.Label();
            this.UpDown_Quantity = new System.Windows.Forms.NumericUpDown();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.btn_Sort = new System.Windows.Forms.Button();
            this.Box_Sorters = new System.Windows.Forms.ComboBox();
            this.lbl_max = new System.Windows.Forms.Label();
            this.lbl_min = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Lato", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(150, 49);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(268, 34);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Sorting Visualization";
            // 
            // UpDown_Quantity
            // 
            this.UpDown_Quantity.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_Quantity.Location = new System.Drawing.Point(581, 101);
            this.UpDown_Quantity.Maximum = new decimal(new int[] {
            135,
            0,
            0,
            0});
            this.UpDown_Quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDown_Quantity.Name = "UpDown_Quantity";
            this.UpDown_Quantity.Size = new System.Drawing.Size(112, 31);
            this.UpDown_Quantity.TabIndex = 1;
            this.UpDown_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpDown_Quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(593, 56);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(87, 24);
            this.lbl_Quantity.TabIndex = 2;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // btn_Generate
            // 
            this.btn_Generate.Font = new System.Drawing.Font("Lato", 12F);
            this.btn_Generate.Location = new System.Drawing.Point(581, 153);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(112, 36);
            this.btn_Generate.TabIndex = 3;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // btn_Sort
            // 
            this.btn_Sort.Font = new System.Drawing.Font("Lato", 12F);
            this.btn_Sort.Location = new System.Drawing.Point(581, 288);
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.Size = new System.Drawing.Size(112, 32);
            this.btn_Sort.TabIndex = 4;
            this.btn_Sort.Text = "Sort";
            this.btn_Sort.UseVisualStyleBackColor = true;
            this.btn_Sort.Click += new System.EventHandler(this.btn_Sort_Click);
            // 
            // Box_Sorters
            // 
            this.Box_Sorters.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Sorters.FormattingEnabled = true;
            this.Box_Sorters.Items.AddRange(new object[] {
            "Bubble Sort",
            "Selection Sort",
            "Insertion Sort",
            "ShellSort"});
            this.Box_Sorters.Location = new System.Drawing.Point(562, 336);
            this.Box_Sorters.Name = "Box_Sorters";
            this.Box_Sorters.Size = new System.Drawing.Size(154, 32);
            this.Box_Sorters.TabIndex = 5;
            // 
            // lbl_max
            // 
            this.lbl_max.AutoSize = true;
            this.lbl_max.Font = new System.Drawing.Font("Lato", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_max.Location = new System.Drawing.Point(62, 372);
            this.lbl_max.Name = "lbl_max";
            this.lbl_max.Size = new System.Drawing.Size(34, 17);
            this.lbl_max.TabIndex = 6;
            this.lbl_max.Text = "max";
            // 
            // lbl_min
            // 
            this.lbl_min.AutoSize = true;
            this.lbl_min.Font = new System.Drawing.Font("Lato", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_min.Location = new System.Drawing.Point(465, 102);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(31, 17);
            this.lbl_min.TabIndex = 7;
            this.lbl_min.Text = "min";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.lbl_min);
            this.Controls.Add(this.lbl_max);
            this.Controls.Add(this.Box_Sorters);
            this.Controls.Add(this.btn_Sort);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.UpDown_Quantity);
            this.Controls.Add(this.lbl_Title);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorting Visualized";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.NumericUpDown UpDown_Quantity;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.Button btn_Sort;
        private System.Windows.Forms.ComboBox Box_Sorters;
        private System.Windows.Forms.Label lbl_max;
        private System.Windows.Forms.Label lbl_min;
    }
}

