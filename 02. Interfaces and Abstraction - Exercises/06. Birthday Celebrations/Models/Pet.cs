using System;

public class Pet : ILivingPersonallty
{
    private string name;
    private string birthDate;

    public Pet(string name, string birthDate)
    {
        this.Name = name;
        this.BirthDate = birthDate;
    }

    public string Name { get => this.name; private set => this.name = value; }
    public string BirthDate { get => this.birthDate; set => this.birthDate = value; }
}