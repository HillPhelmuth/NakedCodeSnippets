public class Student { public int StudentID { get; set; } public string StudentName { get; set; } public int Age { get; set; } }

List<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 13},
            new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 },
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 },
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20},
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
        };

public void MainMethod()
{
    // Filter objects using .Where. This will return all students Ages 13 - 19.
    // Lambda expression must return boolean
    var filteredResult = studentList.Where(s => s.Age > 12 && s.Age < 20).ToList();
    Console.WriteLine("Filter using .Where()");
    Console.WriteLine("<br/>=============================================<br/>");
    foreach (var student in filteredResult)
    {
        Console.WriteLine($"ID: {student.StudentID} Name: {student.StudentName} Age: {student.Age}<br/>");
    }
    // Get the first result using a boolean filter
    var student1 = studentList.FirstOrDefault(x => x.StudentName == "John");
    Console.WriteLine("<br/>=============================================<br/>");
    Console.WriteLine("Filter object to the first result");
    Console.WriteLine("<br/>=============================================<br/>");
    Console.WriteLine($"ID: {student1.StudentID} Name: {student1.StudentName} Age: {student1.Age}<br/>");
    Console.WriteLine("<br/>=============================================<br/>");

    //After filtering, Select a property to list using .Select()
    var studentNames = studentList.Where(x => x.Age >= 18).Select(x => x.StudentName);
    Console.WriteLine("<br/>=============================================<br/>");
    Console.WriteLine("Adult students, names only using .Select");
    Console.WriteLine("<br/>=============================================<br/>");
    foreach (string name in studentNames)
    {
        Console.WriteLine($"{name}");
    }

}
MainMethod();