using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace WindowsFormsApplication1
{
    class DataManager
    {
        //Read All Data
        public string[] readAllData(string fileName)
        {
            try{
                return File.ReadAllLines(fileName);
            }
            catch{
                return File.ReadAllLines(fileName +".txt");
            }
        }
        //Read Some Data
        public string[] readSomeData(string fileName, int start, int num)
        {
            StreamReader reader = new StreamReader(fileName);
            string[] data = new string[num];
            string dataLine = "";
            int i;

            for (i = 0; i < start - 1; i++)
            {
                if (reader.ReadLine() != null);
            }

            for (int j = 0; j < num; j++)
            {
                dataLine = reader.ReadLine();
                if (dataLine == null)
                {
                    reader.Close();
                    return data;
                }
                data[j] = dataLine;
            }
            return data;
        }
        //Save All Data
        public void writeAllDataToFile(string fileName, ListBox box)
        {
            var writer = new StreamWriter(fileName);

            foreach (string d in box.Items)
            {
                writer.WriteLine(d);
            }
            writer.Close();
        }
        //Load All Data
        public void loadAllData(string[] data, ListBox box)
        {
            box.Items.Clear();
            box.Items.Add("==> THE FIRST NAME SELECTED BECOMES THE VOTER <==");
            box.Items.Add("-------------------------------------------------------------------------------------------------------");
            box.Items.Add("");
            foreach(string d in data)
            {
                box.Items.Add(d);
            }
        }
        //Clear All Data
        public void clearAllData(ListBox box)
        {
            box.Items.Clear();
        }
        //Move Selected Items To ListBox
        public void MoveSelectedItemsToListBox(ListBox from, ListBox to)
        {
            for (int i = 0; i < from.SelectedItems.Count; i++)
            {
                to.Items.Add(from.SelectedItems[i].ToString());

                foreach (var item in new ArrayList(from.SelectedItems))
                {
                    from.Items.Remove(item);
                }
            }
        }
        //Move Selected Items To TextBox
        public void MoveSelectedItemsToTextBox(ListBox from, TextBox to)
        {
            for (int i = 0; i < from.SelectedItems.Count; i++)
            {
                to.AppendText(from.SelectedItems[i].ToString());

                foreach (var item in new ArrayList(from.SelectedItems))
                {
                    from.Items.Remove(item);
                }
            }
        }
    }
}
