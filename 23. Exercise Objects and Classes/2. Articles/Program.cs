string[] inputArticle = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

string title = inputArticle[0];
string content = inputArticle[1];
string author = inputArticle[2];

int n = int.Parse(Console.ReadLine());
Article article = new Article(title, content, author);

for (int i = 0; i < n; i++)
{
    string[] cmd = Console.ReadLine()
        .Split(": ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
    string cmdtype = cmd[0];
    string input = cmd[1];
    if (cmdtype == "Edit")
    {
        article.Edit(input);
    }
    else if (cmdtype == "ChangeAuthor")
    {
        article.ChangeAuthor(input);
    }
    else
    {
        article.Rename(input);
    }
}
Console.WriteLine(article);

class Article
{
    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }
    public string Title { get; set; }

    public string Content { get; set; }

    public string Author { get; set; }

    public void Edit(string content)
    {
        Content = content;
    }
    public void ChangeAuthor(string author)
    {
        Author = author;
    }
    public void Rename(string title)
    {
        Title = title;
    }
    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}