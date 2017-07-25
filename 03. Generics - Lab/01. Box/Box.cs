using System.Collections.Generic;
using System.Linq;

public class Box<T> : IBox<T>
{
    private IList<T> elements;

    public Box()
    {
        this.elements = new List<T>();
    }

    public void Add(T element)
    {
        this.elements.Add(element);
    }

    public T Remove()
    {
        T lastElement = elements.LastOrDefault();
        this.elements.RemoveAt(this.elements.Count - 1);
        return lastElement;
    }

    public int Count { get => this.elements.Count; }
}