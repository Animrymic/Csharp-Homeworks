using Class02.Homework.Interfaces;
using System.Text.RegularExpressions;

public class WebPage : ISearchable
{
    public string Url { get; set; }
    public string Html { get; set; }

    public WebPage(string url, string html)
    {
        Url = url;
        Html = html;
    }

    public bool Search(string word)
    {
        if (string.IsNullOrEmpty(word) || string.IsNullOrEmpty(Html))
            return false;

        string textOnly = Regex.Replace(Html, "<.*?>", "");

        return textOnly
            .ToLower()
            .Contains(word.ToLower());
    }
}