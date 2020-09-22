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
    // Order by ascending using .OrderBy. Lambda sets determines the property to order by
    var studentsInAscOrder = studentList.OrderBy(s => s.StudentName).ToList();
    Console.WriteLine("Order by ascending");
    Console.WriteLine("<br/>=============================================<br/>");
    foreach (var student2 in studentsInAscOrder)
    {
        Console.WriteLine($"ID: {student2.StudentID} Name: {student2.StudentName} Age: {student2.Age}<br/>");
    }

    // Order by descending using .OrderByDescending
    var studentsInDescOrder = studentList.OrderByDescending(s => s.Age).ToList();
    Console.WriteLine("<br/>=============================================<br/>");
    Console.WriteLine("Order by descending");
    Console.WriteLine("<br/>=============================================<br/>");
    foreach (var student3 in studentsInDescOrder)
    {
        Console.WriteLine($"ID: {student3.StudentID} Name: {student3.StudentName} Age: {student3.Age}<br/>");
    }

  
}
MainMethod();