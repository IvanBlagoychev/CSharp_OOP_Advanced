using System.Text;

public class Audi : Car
{
    public Audi(string model, string color) : base(model, color)
    { }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Color} {this.GetType().Name} {this.Model}");
        sb.AppendLine(base.ToString());
        return sb.ToString().Trim();
    }
}