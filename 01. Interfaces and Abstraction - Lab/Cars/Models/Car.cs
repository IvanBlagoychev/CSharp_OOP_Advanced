using System.Text;

public class Car : ICar
{
    private string model;
    private string color;

    public Car(string model, string color)
    {
        this.Model = model;
        this.Color = color;
    }

    public string Model { get => this.model; private set => this.model = value; }
    public string Color { get => this.color; private set => this.color = value; }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(this.Start());
        sb.AppendLine(this.Stop());
        return sb.ToString().Trim();
    }
}