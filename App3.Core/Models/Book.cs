namespace App3.Core.Models;

public class Book : Media
{
    public string Author
    {
        get; set;
    }

    public int Pages
    {
        get; set;
    }
}
