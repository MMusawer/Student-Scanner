namespace WindowsFormsApplication1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.n_start = new System.Windows.Forms.NumericUpDown();
            this.n_num = new System.Windows.Forms.NumericUpDown();
            this.startingNum = new System.Windows.Forms.Label();
            this.lineNum = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.voterLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.fileLoadedLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.endingNum = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.n_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_num)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "Read All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(91, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 22);
            this.button2.TabIndex = 1;
            this.button2.Text = "Read Some Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // n_start
            // 
            this.n_start.Location = new System.Drawing.Point(259, 37);
            this.n_start.Name = "n_start";
            this.n_start.Size = new System.Drawing.Size(48, 20);
            this.n_start.TabIndex = 5;
            this.n_start.ValueChanged += new System.EventHandler(this.n_start_ValueChanged);
            // 
            // n_num
            // 
            this.n_num.Location = new System.Drawing.Point(403, 37);
            this.n_num.Name = "n_num";
            this.n_num.Size = new System.Drawing.Size(48, 20);
            this.n_num.TabIndex = 6;
            this.n_num.ValueChanged += new System.EventHandler(this.endNum_ValueChanged);
            // 
            // startingNum
            // 
            this.startingNum.AutoSize = true;
            this.startingNum.Location = new System.Drawing.Point(170, 42);
            this.startingNum.Name = "startingNum";
            this.startingNum.Size = new System.Drawing.Size(83, 13);
            this.startingNum.TabIndex = 7;
            this.startingNum.Text = "Starting Number";
            // 
            // lineNum
            // 
            this.lineNum.Location = new System.Drawing.Point(0, 0);
            this.lineNum.Name = "lineNum";
            this.lineNum.Size = new System.Drawing.Size(100, 23);
            this.lineNum.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(830, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Save File";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 555);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(891, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // voterLabel
            // 
            this.voterLabel.AutoSize = true;
            this.voterLabel.Location = new System.Drawing.Point(313, 9);
            this.voterLabel.Name = "voterLabel";
            this.voterLabel.Size = new System.Drawing.Size(32, 13);
            this.voterLabel.TabIndex = 13;
            this.voterLabel.Text = "Voter";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(439, 485);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(461, 64);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(439, 485);
            this.listBox2.TabIndex = 15;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(751, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 22);
            this.button4.TabIndex = 16;
            this.button4.Text = "Clear All";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // fileLoadedLabel
            // 
            this.fileLoadedLabel.AutoSize = true;
            this.fileLoadedLabel.Location = new System.Drawing.Point(91, 12);
            this.fileLoadedLabel.Name = "fileLoadedLabel";
            this.fileLoadedLabel.Size = new System.Drawing.Size(62, 13);
            this.fileLoadedLabel.TabIndex = 18;
            this.fileLoadedLabel.Text = "File Loaded";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(351, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 20;
            // 
            // endingNum
            // 
            this.endingNum.AutoSize = true;
            this.endingNum.Location = new System.Drawing.Point(313, 42);
            this.endingNum.Name = "endingNum";
            this.endingNum.Size = new System.Drawing.Size(84, 13);
            this.endingNum.TabIndex = 22;
            this.endingNum.Text = "Number of Lines";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(73, 23);
            this.button5.TabIndex = 23;
            this.button5.Text = "Select File";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(672, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(73, 22);
            this.button6.TabIndex = 24;
            this.button6.Text = "Clear";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 590);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.endingNum);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.fileLoadedLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.voterLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lineNum);
            this.Controls.Add(this.startingNum);
            this.Controls.Add(this.n_num);
            this.Controls.Add(this.n_start);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Data Handler";
            ((System.ComponentModel.ISupportInitialize)(this.n_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown n_start;
        private System.Windows.Forms.NumericUpDown n_num;
        private System.Windows.Forms.Label startingNum;
        private System.Windows.Forms.Label lineNum;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label voterLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label fileLoadedLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label endingNum;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}