public class Citizen : IPerson, IBuyer
{
    private string id;
    private string name;
    private int age;
    private string birthDate;
    private int food;

    public Citizen(string id, string name, int age, string birthDate)
    {
        this.Id = id;
        this.Name = name;
        this.Age = age;
        this.BirthDate = birthDate;
        this.food = 0;
    }

    public string Id { get => this.id; private set => this.id = value; }
    public string Name { get=>this.name; private set => this.name = value; }
    public int Age { get => this.age; private set => this.age = value; }
    public string BirthDate { get=> this.birthDate; set => this.birthDate = value; }
    public int Food { get => this.food; private set => this.food = value; }

    public void BuyFood()
    {
        this.Food += 10;
    }
}