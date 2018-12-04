using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsSolution
{
    class Student
    {
        private int ID { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private int Age { get; set; }
        private string Gender { get; set; }
        private double Vote { get; set; }

        public Student(int iD, string firstName, string lastName, int age, string gender, double vote)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
            Vote = vote;
        }

        //private Student(string ID, string FirstName, string LastName, string Age, string Gender, string Vote)
        //{

        //}
    }
}
