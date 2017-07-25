using System.Text;

public class Ferrari : ICar
{
    public const string Model = "488-Spider";
    private string driver;

    public Ferrari(string driver)
    {
        this.Driver = driver;
    }

    public string Driver { get => this.driver; private set => this.driver = value; }
    public string Brakes()
    {
        return "Brakes!";
    }

    public string Gas()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"{Model}/{this.Brakes()}/{this.Gas()}/{this.Driver}");
        return sb.ToString();
    }
}