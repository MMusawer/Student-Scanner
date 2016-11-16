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
        public Form1()
        {
            InitializeComponent();
        }
        DataManager dataHandler = new DataManager();
        string[] data;
        string file;
        //make drag and drop functions

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
            if (data != null) //if the file is not blank
            {
                if (textBox2.Text != "") //if a 'Voter' has been selected
                {
                    dataHandler.writeAllDataToFile(textBox2.Text + ".txt", listBox2); //save file

                }
                else
                {
                    listBox1.Items.Clear(); //clears listBox1
                    listBox1.Items.Add("You need to select a Voter!"); //print text to listBox1
                }
            }
            else
            {
                listBox1.Items.Clear(); //clears listBox1
                listBox1.Items.Add("Your file is blank!"); //print text to listBox1
            }
        }
        //Clear All
        private void button4_Click_1(object sender, EventArgs e)
        {
            //clear ListBoxes and TextBoxes
            dataHandler.clearAllData(listBox1);
            dataHandler.clearAllData(listBox2);
            textBox1.Text = "";
            textBox2.Text = "";
            //reset start and num values
            n_start.Value = 0;
            n_num.Value = 0;
            data = null;
            file = "";
        }
        //Clear
        private void button6_Click(object sender, EventArgs e)
        {
            //clear ListBoxes and TextBoxes
            dataHandler.clearAllData(listBox1);
            dataHandler.clearAllData(listBox2);
            textBox2.Text = "";
        }

        private void endNum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void n_start_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals("")) //if it's the first name selected
            {
                dataHandler.MoveSelectedItemsToTextBox(listBox1, textBox2); //move text from listBox1 to textBox2
            }
            else
            {
                dataHandler.MoveSelectedItemsToListBox(listBox1, listBox2); //move text from listBox1 to listBox2
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataHandler.MoveSelectedItemsToListBox(listBox2, listBox1); //move text from listBox1 to listBox2
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            file = openFileDialog1.SafeFileName;
            textBox1.Text = file; //fileLoaded text
        }
        //Make Teams
        private void button7_Click(object sender, EventArgs e)
        {
            if (n_teamSize.Value == 0)
            {
                listBox1.Items.Clear(); //clears listBox1
                listBox1.Items.Add("You need to enter how many members you want in each team!");
            }
            else if (n_teamNum.Value == 0)
            {
                listBox1.Items.Clear(); //clears listBox1
                listBox1.Items.Add("You need to enter how many teams to make!");
            }
            else
            {
                teamHandler.makeTeams((int)n_teamSize.Value, (int)n_teamNum.Value); //call makeTeams method
            }
        }

        private void memberNum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void teamNum_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}