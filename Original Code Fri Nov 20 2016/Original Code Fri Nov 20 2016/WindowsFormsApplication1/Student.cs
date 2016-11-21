using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Student
    {
        public Student() //constructor
        {
            //Student has:
                //Grade
                //Class
                //ID

            int grade;
            string studentClass;
            string id;
        }

        DataManager dataHandler = new DataManager();
        string[] data;

        //Assign ID to Student
        public void setID(string id)
        {
            //id = ?
        }
    }
}
