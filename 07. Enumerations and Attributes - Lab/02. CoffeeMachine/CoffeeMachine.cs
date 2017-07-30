using System;
using System.Collections.Generic;

public class CoffeeMachine
{
    private int coinsValue;

    public CoffeeMachine()
    {
        this.CoffeesSold = new List<CoffeeType>();
    }

    public List<CoffeeType> CoffeesSold { get; set; }

    public void BuyCoffee(string size, string type)
    {
        CoffeeType coffeeType = (CoffeeType)Enum.Parse(typeof(CoffeeType), type);
        CoffeePrice price = (CoffeePrice)Enum.Parse(typeof(CoffeePrice), size);

        if (this.coinsValue >= (int)price)
        {
            this.CoffeesSold.Add(coffeeType);
            this.coinsValue -= (int)price;
        }
    }

    public void InsertCoin(string coin)
    {
        Coin coins = (Coin)Enum.Parse(typeof(Coin), coin);
        this.coinsValue += (int)coins;
    }
}