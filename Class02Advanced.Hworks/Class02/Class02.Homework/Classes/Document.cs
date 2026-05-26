using Class02.Homework.Interfaces;

public class Document : ISearchable
{
    public string Title { get; set; }
    public string Content { get; set; }

    public Document(string title, string content)
    {
        Title = title;
        Content = content;
    }

    public bool Search(string word)
    {
        if (string.IsNullOrEmpty(word) || string.IsNullOrEmpty(Content))
            return false;

        return Content
            .ToLower()
            .Contains(word.ToLower());
    }
}