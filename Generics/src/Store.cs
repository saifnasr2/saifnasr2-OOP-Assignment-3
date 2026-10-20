using System;

namespace GenericsPart;

public class Store<T> where T : class , IHasId 
{
    private readonly Dictionary<int, T> store = new();

    public void Add(T item)
    {
        try
        {
            store.Add(item.Id, item);
        }
        catch (ArgumentException)
        {
            throw new ArgumentException($"An item with id {item.Id} already exists.");
        }
    }

    public T? GetById(int id) 
    {
        if(store.TryGetValue(id, out var item))
            return item;
        return null;
    }

    public IReadOnlyDictionary<int, T> GetAll()
    {
        return store;   
    }

    public void Remove(int id)
    {
        store.Remove(id);
    }
}
