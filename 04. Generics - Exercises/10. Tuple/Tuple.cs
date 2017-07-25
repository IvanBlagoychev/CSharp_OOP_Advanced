using System.Runtime.InteropServices;

public class Tuple <T, V, K>
{
    private T item1;
    private V item2;
    private K item3;

    public Tuple(T item1, V item2, K item3)
    {
        this.Item1 = item1;
        this.Item2 = item2;
        this.Item3 = item3;
    }

    public T Item1 { get => this.item1; private set => this.item1 = value; }
    public V Item2 { get => this.item2; private set => this.item2 = value; }
    public K Item3 { get => this.item3; private set => this.item3 = value; }

    public override string ToString()
    {
        return $"{this.Item1} -> {this.Item2} -> {this.Item3}";
    }
}