namespace App3.Core.Models;

public class Movie : Media
{
    public string Director
    {
        get; set;
    }
    public int Length
    {
        get; set;
    }
}