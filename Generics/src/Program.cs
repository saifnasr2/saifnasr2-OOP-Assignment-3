namespace GenericsPart;

class Program
{
    static void Main(string[] args)
    {
        var studentStore = new Store<Student>();
        var courseStore = new Store<Course>();

        // Add students
        studentStore.Add(new Student { Id = 1, Name = "Ahmed" });
        studentStore.Add(new Student { Id = 2, Name = "Mona" });
        studentStore.Add(new Student { Id = 3, Name = "Omar" });
        studentStore.Add(new Student { Id = 4, Name = "Salma" });
        studentStore.Add(new Student { Id = 5, Name = "Youssef" });

        // Add courses
        courseStore.Add(new Course { Id = 101, Title = "C# Fundamentals", Price = 1500 });
        courseStore.Add(new Course { Id = 102, Title = "OOP with C#", Price = 2000 });
        courseStore.Add(new Course { Id = 103, Title = "Data Structures", Price = 2500 });
        courseStore.Add(new Course { Id = 104, Title = "SQL Database", Price = 1800 });
        courseStore.Add(new Course { Id = 105, Title = "ASP.NET Core", Price = 3000 });

        Console.WriteLine(studentStore.GetById(3)?.Name);
        // Expected: Omar

        Console.WriteLine(courseStore.GetById(103)?.Title);
        // Expected: Data Structures

        Console.WriteLine(studentStore.GetById(99) is null);
        // Expected: True

        Console.WriteLine(courseStore.GetById(999) is null);
        // Expected: True
        
        studentStore.Remove(2);
        courseStore.Remove(102);

        Console.WriteLine(studentStore.GetById(2) is null);
        // Expected: True

        Console.WriteLine(courseStore.GetById(102) is null);
        // Expected: True

        Console.WriteLine(studentStore.GetAll().Count);
        // Expected: 4

        Console.WriteLine(courseStore.GetAll().Count);
        // Expected: 4

        studentStore.Remove(99);
        courseStore.Remove(999);

        Console.WriteLine(studentStore.GetAll().Count);
        // Expected: 4

        Console.WriteLine(courseStore.GetAll().Count);
        // Expected: 4
    }
}