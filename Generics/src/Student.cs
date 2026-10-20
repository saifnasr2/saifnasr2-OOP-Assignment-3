using System;

namespace GenericsPart;

public class Student
{
    public int Id { get; set; }
    public string? Name { get; set; }
}

public class StudentStore
{
    private readonly List<Student> store = new();

    public void Add(Student student)
    {
        store.Add(student);
    }

    public Student? GetById(int id)
    {
        foreach(var item in store)
        {
            if(item.Id == id)
                return item;
        }
        return null;
    }

    public IReadOnlyList<Student> GetAll()
    {
        return store;   
    }

    public void Remove(int id)
    {
        store.Remove(GetById(id)!);
    }
}
