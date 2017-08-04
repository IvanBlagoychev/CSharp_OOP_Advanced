using System;

public class Program
{
    static void Main()
    {
        //try
        //{
        //    var cardPower1 = Console.ReadLine();
        //    var suitType1 = Console.ReadLine();

        //    var cardPower2 = Console.ReadLine();
        //    var suitType2 = Console.ReadLine();

        //    Rank cardRank1 = (Rank)Enum.Parse(typeof(Rank), cardPower1);
        //    Rank cardRank2 = (Rank)Enum.Parse(typeof(Rank), cardPower2);
        //    Suit cardSuit1 = (Suit)Enum.Parse(typeof(Suit), suitType1);
        //    Suit cardSuit2 = (Suit)Enum.Parse(typeof(Suit), suitType2);

        //    Card newCard1 = new Card(cardRank1, cardSuit1);
        //    Card newCard2 = new Card(cardRank2, cardSuit2);

        //    if (newCard1.CompareTo(newCard2) == -1)
        //    {
        //        Console.WriteLine(newCard1);
        //    }
        //    else Console.WriteLine(newCard2);

        //}
        //catch (Exception e)
        //{
        //    Console.WriteLine(e.Message);
        //}


        // ===== Task 6 =====\\

        string input = Console.ReadLine();
        Type enumType = input == "Rank" ? typeof(Rank) : typeof(Suit);

        Console.WriteLine(string.Join(Environment.NewLine, enumType.GetCustomAttributes(false)));
    }
}