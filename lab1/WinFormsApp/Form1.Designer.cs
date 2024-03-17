namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRun = new Button();
            labelNumberOfItems = new Label();
            labelSeed = new Label();
            labelCapacity = new Label();
            numberOfItems = new TextBox();
            seed = new TextBox();
            capacity = new TextBox();
            labelInstance = new Label();
            labelResult = new Label();
            textBoxInstance = new TextBox();
            textBoxResult = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.Font = new Font("Segoe UI", 14F);
            btnRun.Location = new Point(52, 335);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(190, 40);
            btnRun.TabIndex = 0;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // labelNumberOfItems
            // 
            labelNumberOfItems.AutoSize = true;
            labelNumberOfItems.Font = new Font("Segoe UI", 14F);
            labelNumberOfItems.Location = new Point(52, 36);
            labelNumberOfItems.Name = "labelNumberOfItems";
            labelNumberOfItems.Size = new Size(150, 25);
            labelNumberOfItems.TabIndex = 1;
            labelNumberOfItems.Text = "number of items";
            labelNumberOfItems.Click += labelNumberOfItems_Click;
            // 
            // labelSeed
            // 
            labelSeed.AutoSize = true;
            labelSeed.Font = new Font("Segoe UI", 14F);
            labelSeed.Location = new Point(52, 122);
            labelSeed.Name = "labelSeed";
            labelSeed.Size = new Size(51, 25);
            labelSeed.TabIndex = 2;
            labelSeed.Text = "seed";
            // 
            // labelCapacity
            // 
            labelCapacity.AutoSize = true;
            labelCapacity.Font = new Font("Segoe UI", 14F);
            labelCapacity.Location = new Point(52, 215);
            labelCapacity.Name = "labelCapacity";
            labelCapacity.Size = new Size(81, 25);
            labelCapacity.TabIndex = 3;
            labelCapacity.Text = "capacity";
            labelCapacity.Click += labelCapacity_Click;
            // 
            // numberOfItems
            // 
            numberOfItems.Font = new Font("Segoe UI", 14F);
            numberOfItems.Location = new Point(52, 76);
            numberOfItems.Name = "numberOfItems";
            numberOfItems.Size = new Size(190, 32);
            numberOfItems.TabIndex = 4;
            numberOfItems.TextChanged += numberOfItems_TextChanged;
            // 
            // seed
            // 
            seed.Font = new Font("Segoe UI", 14F);
            seed.Location = new Point(52, 168);
            seed.Name = "seed";
            seed.Size = new Size(190, 32);
            seed.TabIndex = 5;
            seed.TextChanged += seed_TextChanged;
            // 
            // capacity
            // 
            capacity.Font = new Font("Segoe UI", 14F);
            capacity.Location = new Point(52, 265);
            capacity.Name = "capacity";
            capacity.Size = new Size(190, 32);
            capacity.TabIndex = 6;
            capacity.TextChanged += capacity_TextChanged;
            // 
            // labelInstance
            // 
            labelInstance.AutoSize = true;
            labelInstance.Font = new Font("Segoe UI", 14F);
            labelInstance.Location = new Point(637, 22);
            labelInstance.Name = "labelInstance";
            labelInstance.Size = new Size(82, 25);
            labelInstance.TabIndex = 8;
            labelInstance.Text = "instance";
            labelInstance.Click += labelInstance_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI", 14F);
            labelResult.Location = new Point(660, 461);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(59, 25);
            labelResult.TabIndex = 10;
            labelResult.Text = "result";
            labelResult.Click += labelResult_Click;
            // 
            // textBoxInstance
            // 
            textBoxInstance.Font = new Font("Segoe UI", 14F);
            textBoxInstance.Location = new Point(321, 76);
            textBoxInstance.Multiline = true;
            textBoxInstance.ScrollBars = ScrollBars.Vertical;
            textBoxInstance.Name = "textBoxInstance";
            textBoxInstance.ReadOnly = true;
            textBoxInstance.Size = new Size(398, 368);
            textBoxInstance.TabIndex = 11;
            textBoxInstance.TextChanged += textBoxInstance_TextChanged;
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Segoe UI", 14F);
            textBoxResult.Location = new Point(52, 498);
            textBoxResult.Multiline = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(667, 151);
            textBoxResult.TabIndex = 12;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(52, 403);
            button1.Name = "button1";
            button1.Size = new Size(190, 44);
            button1.TabIndex = 13;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 694);
            Controls.Add(button1);
            Controls.Add(textBoxResult);
            Controls.Add(textBoxInstance);
            Controls.Add(labelResult);
            Controls.Add(labelInstance);
            Controls.Add(capacity);
            Controls.Add(seed);
            Controls.Add(numberOfItems);
            Controls.Add(labelCapacity);
            Controls.Add(labelSeed);
            Controls.Add(labelNumberOfItems);
            Controls.Add(btnRun);
            Name = "Form1";
            Text = "Knapsack";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRun;
        private Label labelNumberOfItems;
        private Label labelSeed;
        private Label labelCapacity;
        private TextBox numberOfItems;
        private TextBox seed;
        private TextBox capacity;
        private Label labelInstance;
        private Label labelResult;
        private TextBox textBoxInstance;
        private TextBox textBoxResult;
        private Button button1;
    }
}
