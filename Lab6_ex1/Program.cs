using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {

        // Create a List<int>
        IList<int> intList = new List<int>();

        // Add elements to the List using the Add() method
        intList.Add(1);
        intList.Add(2);
        intList.Add(3);
        intList.Add(4);

        IList<string> strList = new List<string>();
        {
            strList.Add("a");
            strList.Add("b");
            strList.Add("c");
            strList.Add("d");
            strList.Add(null);
            strList.Add(null);
        }

        IList<Student> studentList = new List<Student>();

        studentList.Add(new Student());
        studentList.Add(new Student());
        studentList.Add(new Student());
        
        IList <int> intList = new List<int>() { 10, 20, 30, 40 };

        //IList<Student> studentList = new List<Student>()
        //{
        //    new Student(){StudentID=1, StudentName= "Zahra"}
        //};
    }
}