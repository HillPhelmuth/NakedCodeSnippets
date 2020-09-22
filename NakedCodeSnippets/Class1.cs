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
            var filteredResult = studentList.Where(s => s.Age > 12 && s.Age < 20);
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
            var studentsInAscOrder = studentList.OrderBy(s => s.StudentName);
            Console.WriteLine("Order by ascending");
            foreach (var student2 in filteredResult)
            {
                Console.WriteLine($"ID: {student2.StudentID} Name: {student2.StudentName} Age: {student2.Age}");
            }

            // Order by descending using .OrderByDescending
            var studentsInDescOrder = studentList.OrderByDescending(s => s.Age);

            Console.WriteLine("Order by descending");
            foreach (var student3 in filteredResult)
            {
                Console.WriteLine($"ID: {student3.StudentID} Name: {student3.StudentName} Age: {student3.Age}");
            }

            //After filtering, Select a property to list using .Select()
            var studentNames = studentList.Where(x => x.Age >= 18).Select(x => x.StudentName);
            Console.WriteLine("Adult students, names only");
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

        public void MainMethod3()
        {
            // .Average
            var avgAge = studentList.Average(s => s.Age);
            Console.WriteLine(".Average does what you'd expect");
            Console.WriteLine("<br/>=============================================<br/>");
            Console.WriteLine($"Average Age of Student: {avgAge}");
            Console.WriteLine("<br/>=============================================<br/>");

            //.Count() and .Count(Func<instanceType, bool> filter)
            Console.WriteLine(".Count returns number of instances. Includes a filter overload");
            Console.WriteLine("<br/>=============================================<br/>");
            var totalStudents = studentList.Count();
            Console.WriteLine($"Total Students: {totalStudents}");
            var adultStudents = studentList.Count(s => s.Age >= 18);
            Console.WriteLine($"Number of Adult Students: {adultStudents}");
            Console.WriteLine("<br/>=============================================<br/>");

            //.Max to get highest numerical value
            var oldest = studentList.Max(s => s.Age);
            Console.WriteLine($"Oldest Student Age: {oldest}");
            Console.WriteLine("<br/>=============================================<br/>");

            //.Sum to get total numerical value
            var sumOfAge = studentList.Sum(s => s.Age);
            Console.WriteLine($"Sum of all student's age: {sumOfAge}");
            Console.WriteLine("<br/>=============================================<br/>");
        }

        public void MainMethod4()
        {
            // Distinct Set
            var strList = new List<string>() { "One", "Two", "Three", "Two", "Three" };
            var intList = new List<int>() { 1, 2, 3, 2, 4, 4, 3, 5 };
            var distinctList1 = strList.Distinct();
            Console.WriteLine("Get unique strings");
            Console.WriteLine("<br/>=============================================<br/>");
            foreach (var str in distinctList1)
                Console.WriteLine(str);
            Console.WriteLine("<br/>=============================================<br/>");
            Console.WriteLine("Or unique numbers");
            Console.WriteLine("<br/>=============================================<br/>");
            var distinctList2 = intList.Distinct();
            foreach (var num in distinctList2)
                Console.WriteLine(num);
            Console.WriteLine("<br/>=============================================<br/>");

            // Except Set
            var strList1 = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            var strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight" };

            var result = strList1.Except(strList2);
            Console.WriteLine(".Except returns values from list 1 that are not contained in list 2");
            Console.WriteLine("<br/>=============================================<br/>");
            foreach (string str in result)
                Console.WriteLine(str);
            Console.WriteLine("<br/>=============================================<br/>");
        }

        public void MainMethod5()
        {
            // Union
            var strList1 = new List<string>() { "One", "Two", "three", "Four" };
            var strList2 = new List<string>() { "Two", "THREE", "Four", "Five" };
            Console.WriteLine("Merges two collections and returns unique values");
            Console.WriteLine("<br/>=============================================<br/>");
            var union = strList1.Union(strList2);
            foreach (string str in union)
                Console.WriteLine(str);
            Console.WriteLine("<br/>=============================================<br/>");

            //Intersect
            var strList3 = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            var strList4 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight" };
            Console.WriteLine("Merges two collections and returns unique values");
            Console.WriteLine("<br/>=============================================<br/>");
            var intersect = strList1.Intersect(strList2);
            foreach (string str in intersect)
                Console.WriteLine(str);

        }
    }
}
