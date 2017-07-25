using System;public class Box<T> where T : IComparable<T>
{
    public Box(T element)
    {
        this.GivenVal = element;
    }
    public T GivenVal { get; set; }

    public override string ToString()
    {
        return $"{this.GivenVal.GetType().FullName}: {this.GivenVal}";
    }
}