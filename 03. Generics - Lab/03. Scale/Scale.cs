using System;

public class Scale<T>  
    where T : IComparable<T>
{
    public Scale(T firstElement, T secondElement)
    {
        this.FirstElement = firstElement;
        this.SecondElement = secondElement;
    }

    private T FirstElement { get; }
    private T SecondElement { get;  }

    public T GetHavier()
    {
        if (this.FirstElement.CompareTo(this.SecondElement) == 1)
        {
            return this.FirstElement;
        }
        else if (this.FirstElement.CompareTo(this.SecondElement) == -1)
        {
            return this.SecondElement;
        }
        else return default(T);
    }
}