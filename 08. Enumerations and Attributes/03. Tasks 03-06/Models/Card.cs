using System;

public class Card : IComparable<Card>
{
    private Rank rank;
    private Suit suit;
    private int power;
    
    public Card(Rank rank, Suit suit)
    {
        this.Rank = rank;
        this.Suit = suit;
    }

    public Rank Rank
    {
        get { return this.rank; }
        private set { this.rank = value; }
    }

    public Suit Suit
    {
        get { return this.suit; }
        private set { this.suit = value; }
    }

    private int Power { get => (int)this.Rank + (int)this.Suit; }

    public int CompareTo(Card other)
    {
        if (this.Power.CompareTo(other.Power) == 1)
        {
            return this.Power.CompareTo(other.Power);
        }
        return other.Power.CompareTo(this.Power);
    }

    public override string ToString()
    {
        return $"Card name: {this.rank} of {this.suit}; Card power: {this.Power}";
    }
}