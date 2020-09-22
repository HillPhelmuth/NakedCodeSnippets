using System;
using System.Collections.Generic;
using System.Linq;

namespace NakedCodeSnippets
{
    public class Class1
    {
        public class Student
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public int Age { get; set; }
        }

        List<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
            new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
        };

        public void MainMethod1()
        {
            // Filter objects using .Where. This will return all students Ages 13 - 19.
            // Lambda expression must return boolean
            var filteredResult = studentList.Where(s => s.Age > 12 && s.Age < 20).ToList();
            Console.WriteLine("Filter using .Where()");
            foreach (var student in filteredResult)
            {
                Console.WriteLine($"ID: {student.StudentID} Name: {student.StudentName} Age: {student.Age}");
            }

            // Filter object to the first result using a boolean filter
            var student1 = studentList.FirstOrDefault(x => x.StudentName == "John");

            Console.WriteLine("Filter object to the first result");
            Console.WriteLine($"ID: {student1.StudentID} Name: {student1.StudentName} Age: {student1.Age}");

            // Order by ascending using .OrderBy
            var studentsInAscOrder = studentList.OrderBy(s => s.StudentName).ToList();
            Console.WriteLine("Order by ascending");
            foreach (var student2 in filteredResult)
            {
                Console.WriteLine($"ID: {student2.StudentID} Name: {student2.StudentName} Age: {student2.Age}");
            }

            // Order by descending using .OrderByDescending
            var studentsInDescOrder = studentList.OrderByDescending(s => s.Age).ToList();

            Console.WriteLine("Order by descending");
            foreach (var student3 in filteredResult)
            {
                Console.WriteLine($"ID: {student3.StudentID} Name: {student3.StudentName} Age: {student3.Age}");
            }

            // Select a property to list using .Select()
            var studentNames = studentList.Select(x => x.StudentName);
            Console.WriteLine("Student names only");
            foreach (string name in studentNames)
            {
                Console.WriteLine($"{name}");
            }

        }

        public void MainMethod2()
        {
            var strList = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            // creates a string separated by a ','
            var commaSeperatedString = strList.Aggregate((s1, s2) => s1 + ", " + s2);
            Console.WriteLine("Aggregate Simple");
            Console.WriteLine("<br/>=============================================<br/>");
            Console.WriteLine(commaSeperatedString);
            Console.WriteLine("<br/>=============================================<br/>");
            //Aggregate types <instanceType, OutputType> with seed value
            var commaNames = studentList.Aggregate<Student, string>("Student Names: ", (name, sdnt) => name += $"{sdnt.StudentName},");
            Console.WriteLine("Aggregate Complex");
            Console.WriteLine("<br/>=============================================<br/>");
            Console.WriteLine(commaNames);
            Console.WriteLine("<br/>=============================================<br/>");
            //Aggregate types <instanceType, OutputType (Func<> with string input)> with seed value
            string commaSeparatedStudentNames = studentList.Aggregate<Student, string, string>(
                string.Empty, // seed value
                (str, s) => str += s.StudentName + ",",
                str => str.Substring(0, str.Length - 1) + "!"); // result selector function that replaces last comma
            Console.WriteLine("Aggregate Complex with selector function");
            Console.WriteLine("<br/>=============================================<br/>");
            Console.WriteLine(commaSeparatedStudentNames);
        }
    }
}
