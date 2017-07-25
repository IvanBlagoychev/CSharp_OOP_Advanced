public class Citizen : IPersonallity
{
    private string id;
    private string name;
    private int age;

    public Citizen(string id, string name, int age)
    {
        this.Id = id;
        this.Name = name;
        this.Age = age;
    }

    public string Id { get => this.id; private set => this.id = value; }
    public string Name { get=>this.name; private set => this.name = value; }
    public int Age { get => this.age; private set => this.age = value; }
}