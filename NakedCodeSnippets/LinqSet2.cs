public class Student { public int StudentID { get; set; } public string StudentName { get; set; } public int Age { get; set; } }

List<Student> studentList = new List<Student>() {
new Student() { StudentID = 1, StudentName = "John", Age = 13},
new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 },
new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 },
new Student() { StudentID = 4, StudentName = "Ram" , Age = 20},
new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
};

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