public class Rebel : IPerson, IBuyer
{
    private string name;
    private string group;
    private int age;
    private int food;

    public Rebel(string name, string group, int age)
    {
        this.Name = name;
        this.Group = group;
        this.Age = age;
        this.Food = 0;
    }

    public string Name { get => this.name; set => this.name = value; }

    public string Group { get => this.group; set => this.group = value; }

    public int Age { get => this.age; set => this.age = value; }

    public int Food { get => this.food; set => this.food = value; }

    public void BuyFood()
    {
        this.Food += 5;
    }
}