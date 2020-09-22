public class Student { public int StudentID { get; set; } public string StudentName { get; set; } public int Age { get; set; } }

List<Student> studentList = new List<Student>() {
new Student() { StudentID = 1, StudentName = "John", Age = 13},
new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 },
new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 },
new Student() { StudentID = 4, StudentName = "Ram" , Age = 20},
new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
};

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
}
MainMethod3();