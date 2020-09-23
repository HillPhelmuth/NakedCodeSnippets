public class Student { public int StudentID { get; set; } public string StudentName { get; set; } public int Age { get; set; } }

List<Student> studentList = new List<Student>() {
new Student() { StudentID = 1, StudentName = "John", Age = 13},
new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 },
new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 },
new Student() { StudentID = 4, StudentName = "Ram" , Age = 20},
new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
};

public void DistinctAndExcept()
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
DistinctAndExcept();