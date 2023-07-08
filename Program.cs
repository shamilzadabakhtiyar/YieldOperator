int counter = 0;
var students = GetStudents();
var enumurator = students.GetEnumerator();


while (true)
{
    if(enumurator.MoveNext())
        System.Console.WriteLine(enumurator.Current.FirstName);
    else
        break;
}
 
IEnumerable<int> GetNumbers()
{
    return new List<int>()
    {
        1, 2, 3
    };
}

IEnumerable<int> GetOddNumbers()
{
    while (true)
    {
        counter++;
        if(counter % 2 == 1)
        yield return counter;
    }
}

IEnumerable<Student> GetStudents()
{
    yield return new Student("Bakhtiyar", "Shamilzada");
    yield break;
    yield return new Student("Vuqar", "Ahmadli");
}

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Student(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        System.Console.WriteLine("Student class generated");
    }
}