using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        BarCodeReader barcode = new BarCodeReader();
        public Form1()
        {
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            InitializeComponent();
        }
        DataManager dataHandler = new DataManager();
        string[] data;
        string file;
        string className;
        string teacherName;
        //make drag and drop functions
        //make save file destination option

        //Can't build if this code isn't here
        //--------------------------------------------------------------
        private void endNum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void n_start_ValueChanged(object sender, EventArgs e)
        {

        }
        //--------------------------------------------------------------
      
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            file = openFileDialog1.SafeFileName;
            textBox1.Text = file; //fileLoaded text
        }
        //Select a File
        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); //clears listBox1
            openFileDialog1.ShowDialog();
        }
        //Read All Data
        private void button1_Click(object sender, EventArgs e)
        {
            if (file != null) //if a file is selected
            {
                //file = "ics4u101_students.csv";
                data = dataHandler.readAllData(file); //read whole data file
                dataHandler.loadAllData(data, listBox1); //print data to listBox1
            }
            else
            {
                listBox1.Items.Clear(); //clears listBox1
                listBox1.Items.Add("You need to select a file!");
            }
        }
        //Read Some Data
        private void button2_Click(object sender, EventArgs e)
        {
            if (file != null) //if a file is selected
            {
                if (n_num.Value == 0) //if the number of lines wanting to be read is 0
                {
                    listBox1.Items.Clear(); //clears listBox1
                    listBox1.Items.Add("You need to enter a number of lines to be read!");
                }
                else
                {
                    data = dataHandler.readSomeData(file, (int)n_start.Value, (int)n_num.Value); //read some data
                    dataHandler.loadAllData(data, listBox1); //print data to listBox2
                }

                /*
                if (n_num.Value > ???) //if the number of lines wanting to be read is higher than the number of lines of the file
                {
                     listBox1.Items.Add("The file doesn't have that many lines!"); //print text to listBox1
                }
                */
            }
            else
            {
                listBox1.Items.Clear(); //clears listBox1
                listBox1.Items.Add("You need to select a file!");
            }
        }
        //Save All Data
        private void button3_Click_1(object sender, EventArgs e)
        {
            /*
             Stream myStream ;
             SaveFileDialog saveFileDialog1 = new SaveFileDialog();

             saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"  ;
             saveFileDialog1.FilterIndex = 2 ;
             saveFileDialog1.RestoreDirectory = true ;

             if(saveFileDialog1.ShowDialog() == DialogResult.OK)
             {
                 if((myStream = saveFileDialog1.OpenFile()) != null)
                 {
                     // Code to write the stream goes here.
                     myStream.Close();
                
            */
            if (data != null) //if the file is not blank
            {
                if (textBox2.Text != "") //if a 'Voter' has been selected
                {
                    dataHandler.writeAllDataToFile(textBox2.Text + ".txt", listBox2); //save file

                }
                else
                {
                        listBox1.Items.Clear(); //clears listBox1
                        listBox1.Items.Add("The teacher needs to type in their name! (LastName, FirstName)"); //print text to listBox1
                }
            }
            else
            {
                listBox1.Items.Clear(); //clears listBox1
                listBox1.Items.Add("Your file is blank!"); //print text to listBox1
            }
            //add additional info
            listBox2.Items.Add(""); //print text to listBox2
            listBox2.Items.Add("Teacher: " + teacherName); //print text to listBox2
            listBox2.Items.Add("Class: " + className); //print text to listBox2
            listBox2.Items.Add("Period: " + n_period.Value); //print text to listBox2
        }
        //Clear All
        private void button4_Click_1(object sender, EventArgs e)
        {
            //clear ListBoxes and TextBoxes
            dataHandler.clearAllData(listBox1);
            dataHandler.clearAllData(listBox2);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            //reset start and num values
            n_start.Value = 0;
            n_num.Value = 0;
            n_period.Value = 0;
            data = null;
            file = "";
            className = "";
        }
        //Clear
        private void button6_Click(object sender, EventArgs e)
        {
            //clear ListBoxes and TextBoxes
            dataHandler.clearAllData(listBox1);
            dataHandler.clearAllData(listBox2);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataHandler.MoveSelectedItemsToListBox(listBox1, listBox2); //move text from listBox1 to listBox2
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataHandler.MoveSelectedItemsToListBox(listBox2, listBox1); //move text from listBox1 to listBox2
        }

        //Period
        private void n_period_ValueChanged(object sender, EventArgs e)
        {
            if (n_period.Value < 1 || n_period.Value > 5)
            {
                listBox1.Items.Clear(); //clears listBox1
                listBox1.Items.Add("Invalid Period!"); //print text to listBox1
            }
        }
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            className = textBox3.Text; //Set Class 'name' to what's in textbox3
        }

        //Teacher Name
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            teacherName = textBox2.Text; //set teacherName to waht's in the textbox
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
            String s = barcode.codeReader(e.KeyChar);
            
            if (s != null)
            {
                listBox1.Visible = true;
                listBox1.Items.Add(s);
            }
        }
        

    }
}