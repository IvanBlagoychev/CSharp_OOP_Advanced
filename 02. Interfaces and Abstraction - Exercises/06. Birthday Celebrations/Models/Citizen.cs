using System;

public class Citizen : IPersonallity, ILivingPersonallty
{
    private string id;
    private string name;
    private int age;
    private string birthDate;

    public Citizen(string id, string name, int age, string birthDate)
    {
        this.Id = id;
        this.Name = name;
        this.Age = age;
        this.BirthDate = birthDate;
    }

    public string Id { get => this.id; private set => this.id = value; }
    public string Name { get=>this.name; private set => this.name = value; }
    public int Age { get => this.age; private set => this.age = value; }
    public string BirthDate { get=> this.birthDate; set => this.birthDate = value; }
}