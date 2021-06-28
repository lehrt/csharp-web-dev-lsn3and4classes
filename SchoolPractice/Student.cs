using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        private string _name = "rese";
        private int _studentId;
        private int _numberOfCredits;
        private double _gpa;

    public Student (string name, int studentId, int numberOfCredits, double gpa)
        {
            this._name = name;
            this._studentId = studentId;
            this._numberOfCredits = numberOfCredits;
            this._gpa = gpa;
        }
    public void StudentInfo()
        {
            Console.WriteLine($"Name: {this._name} (Student ID: {this._studentId}), has {this._numberOfCredits} credit(s), GPA is: {this._gpa}.");
        }




    }
}
