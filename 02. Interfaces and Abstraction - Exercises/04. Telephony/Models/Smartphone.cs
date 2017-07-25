using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Smartphone : IBrowse, ICaller
{
    private IList<string> numbers;
    private IList<string> urls;

    public Smartphone(IList<string> numbers, IList<string> urls)
    {
        this.numbers = numbers;
        this.urls = urls;
    }

    public string Call()
    {
        var sb = new StringBuilder();
        foreach (var number in this.numbers)
        {
            bool isValidNumber = true;
            foreach (char c in number)
            {
                if (!char.IsDigit(c))
                {
                    isValidNumber = false;
                    break;
                }
            }
            sb.AppendLine(isValidNumber ? $"Calling... {number}" : "Invalid number!");
        }
        return sb.ToString().Trim();
    }

    public string Browse()
    {
        var sb = new StringBuilder();
        foreach (var url in this.urls)
        {
            bool isValidURL = true;
            foreach (char c in url)
            {
                if (char.IsDigit(c))
                {
                    isValidURL = false;
                    break;
                }
            }
            sb.AppendLine(isValidURL ? $"Browsing: {url}!" : "Invalid URL!");
        }
        return sb.ToString().Trim();
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(this.Call()).AppendLine(this.Browse());
        return sb.ToString().Trim();
    }
}