using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CustomList<T> : IEnumerable<T> where T : IComparable<T>
{
    private IList<T> data;

    public CustomList()
    {
        this.data = new List<T>();
    }

    public CustomList(IList<T> list)
    {
        this.data = new List<T>(list);
    }

    public void Add(T element)
    {
        this.data.Add(element);
    }

    public T Remove(int index)
    {
        var val = this.data[index];
        this.data.RemoveAt(index);
        return val;
    }

    public bool Contains(T element)
    {
        return this.data.Contains(element);
    }

    public void Swap(int pos1, int pos2)
    {
        var firsBox = this.data[pos1];
        this.data[pos1] = this.data[pos2];
        this.data[pos2] = firsBox;
    }

    public int CountGreaterThan(T element)
    {
        int count = 0;
        foreach (T val in this.data)
        {
            if (val.CompareTo(element) == 1)
            {
                count++;
            }
        }
        return count;
    }

    public T Max()
    {
        return this.data.Max();
    }

    public T Min()
    {
        return this.data.Min();
    }

    public IEnumerator<T> GetEnumerator()
    {
        return this.data.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IList<T> GetList()
    {
        return this.data;
    }

    public string Print()
    {
        var sb = new StringBuilder();
        foreach (T d in this.data)
        {
            sb.AppendLine(d.ToString());
        }
        return sb.ToString().Trim();
    }
}