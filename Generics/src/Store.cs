using System;

namespace GenericsPart;

public class Store<T> where T : class , IHasId 
{
    private readonly List<T> store = new();

    public void Add(T item)
    {
        store.Add(item);
    }

    public T? GetById(int id) 
    {
        foreach(var item in store)
        {
            if(item.Id == id)
                return item;
        }
        return null;
    }

    public IReadOnlyList<T> GetAll()
    {
        return store;   
    }

    public void Remove(int id)
    {
        store.Remove(GetById(id)!);
    }
}
