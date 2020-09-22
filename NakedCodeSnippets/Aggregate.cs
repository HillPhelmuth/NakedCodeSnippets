public class Student { public int StudentID { get; set; } public string StudentName { get; set; } public int Age { get; set; }
}

    List<Student> studentList = new List<Student>() {
new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
};
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
        "Names: ", // seed value
        (str, s) => str += s.StudentName + ",",
        str => str.Substring(0, str.Length - 1) + "!"); // result selector function that replaces last comma
    Console.WriteLine("Aggregate Complex with selector function");
    Console.WriteLine("<br/>=============================================<br/>");
    Console.WriteLine(commaSeparatedStudentNames);
}
MainMethod2();