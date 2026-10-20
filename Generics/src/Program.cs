
using GenericsPart;


var studentStore = new Store<Student>();
var courseStore = new Store<Course>();


studentStore.Add(new Student { Id = 1, Name = "Ahmed" });
studentStore.Add(new Student { Id = 2, Name = "Mona" });
studentStore.Add(new Student { Id = 3, Name = "Omar" });
studentStore.Add(new Student { Id = 4, Name = "Salma" });
studentStore.Add(new Student { Id = 5, Name = "Youssef" });


courseStore.Add(new Course { Id = 101, Title = "C# Fundamentals", Price = 1500 });
courseStore.Add(new Course { Id = 102, Title = "OOP with C#", Price = 2000 });
courseStore.Add(new Course { Id = 103, Title = "ASP.NET Core", Price = 3000 });


Console.WriteLine("Student by ID:");
Console.WriteLine(studentStore.GetById(3)?.Name);

Console.WriteLine("\nCourse by ID:");
Console.WriteLine(courseStore.GetById(102)?.Title);


try
{
    studentStore.Add(new Student { Id = 3, Name = "Duplicate Student" });
}
catch (ArgumentException ex)
{
    Console.WriteLine($"\nDuplicate ID error: {ex.Message}");
}
catch (InvalidOperationException ex)
{
    
    Console.WriteLine($"\nDuplicate ID error: {ex.Message}");
}


Console.WriteLine("\nPage 2 of students:");

foreach (var student in studentStore.GetAll().Values.Page(2, 2))
{
    Console.WriteLine($"{student.Id}: {student.Name}");
}


var courseList = new List<Course>
{
    new Course { Id = 201, Title = "Databases", Price = 1800 },
    new Course { Id = 202, Title = "Data Structures", Price = 2500 },
    new Course { Id = 203, Title = "Algorithms", Price = 2200 }
};

var foundCourse = courseList.FindById(202);
Console.WriteLine($"\nFindById on List<Course>: {foundCourse?.Title}");

// 8. This MUST NOT compile:
// var stringStore = new Store<string>();
