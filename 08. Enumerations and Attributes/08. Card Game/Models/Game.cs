using System;
using System.Collections.Generic;
using System.Linq;

public class Game
{
    private Dictionary<string, List<Card>> player1Cards;
    private Dictionary<string, List<Card>> player2Cards;
    private List<Card> allCards;

    public Game()
    {
        this.player1Cards = new Dictionary<string, List<Card>>();
        this.player2Cards = new Dictionary<string, List<Card>>();
        this.allCards = new List<Card>();
    }

    public void Play()
    {
        string player1 = Console.ReadLine();
        string player2 = Console.ReadLine();

        this.GetCards(player1);
        this.GetCards(player2);

        Console.WriteLine(this.GetWinner(player1, player2));
    }

    private void GetCards(string player)
    {
        var cards = new List<Card>();
        for (int i = 0; i < 5; i++)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            var rankName = input[0];
            var suitName = input[2];

            bool rankValid = Enum.TryParse(rankName, out Rank rank);
            bool suitValid = Enum.TryParse(suitName, out Suit suit);

            if (!rankValid || !suitValid)
            {
                Console.WriteLine("No such card exists.");
                i--;
            }
            else
            {
                Card newCard = new Card(rank, suit);
                if (CheckForMatch(newCard))
                {
                    Console.WriteLine("Card is not in the deck.");
                    i--;
                }
                else
                {
                    this.allCards.Add(newCard);
                    cards.Add(newCard);
                }
            }
        }
        if (this.player1Cards.Keys.Count == 0) player1Cards[player] = cards;
        else player2Cards[player] = cards;
    }

    private bool CheckForMatch(Card card)
    {
        foreach (Card c in this.allCards)
        {
            if (c.CompareTo(card) == 0)
            {
                return true;
            }
        }
        return false;
    }

    public string GetWinner(string player1, string player2)
    {
        var highestPower1 = player1Cards[player1].OrderByDescending(x => x.Power).FirstOrDefault();
        var highestPower2 = player2Cards[player2].OrderByDescending(x => x.Power).FirstOrDefault();
        if (highestPower1.Power > highestPower2.Power)
        {
            return $"{player1} wins with {highestPower1.Rank} of {highestPower1.Suit}.";
        }
        return $"{player2} wins with {highestPower2.Rank} of {highestPower2.Suit}.";
    }
}