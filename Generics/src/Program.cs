namespace GenericsPart;

class Program
{
    static void Main(string[] args)
    {
        var store = new StudentStore();

        // 1. Add two students and retrieve each by ID.
        store.Add(new Student { Id = 1, Name = "Ahmed" });
        store.Add(new Student { Id = 2, Name = "Mona" });

        Console.WriteLine("Test 1: Add and retrieve students");
        Console.WriteLine(store.GetById(1)?.Name == "Ahmed"); // True
        Console.WriteLine(store.GetById(2)?.Name == "Mona");  // True

        // 2. Search for an ID that doesn't exist.
        Console.WriteLine("\nTest 2: Missing student");
        Console.WriteLine(store.GetById(99) is null); // True

        // 3. Remove an existing student and verify it is gone.
        store.Remove(1);

        Console.WriteLine("\nTest 3: Remove existing student");
        Console.WriteLine(store.GetById(1) is null); // True
        Console.WriteLine(store.GetAll().Count == 1); // True

        // 4. Remove a nonexistent ID — expect no exception.
        Console.WriteLine("\nTest 4: Remove nonexistent student");
        store.Remove(99);
        Console.WriteLine("No exception thrown."); // Reaching this line means success
    }
}