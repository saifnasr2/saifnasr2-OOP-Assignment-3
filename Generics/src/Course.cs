using System;

namespace GenericsPart;

public class Course
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public decimal Price { get; set; }
}

public class CourseStore
{
    private readonly List<Course> courses = new();

    public void Add(Course course)
    {
        courses.Add(course);
    }

    public Course? GetById(int id)
    {
        foreach(var item in courses)
        {
            if(item.Id == id)
                return item;
        }
        return null;
    }

    public IReadOnlyList<Course> GetAll()
    {
        return courses;   
    }

    public void Remove(int id)
    {
        courses.Remove(GetById(id)!);
    }
}
