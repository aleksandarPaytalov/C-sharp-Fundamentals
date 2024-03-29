﻿int n = int.Parse(Console.ReadLine());

List<Article> articles = new List<Article>();
for (int i = 0; i < n; i++)
{
    string[] inputArticle = Console.ReadLine()
     .Split(", ", StringSplitOptions.RemoveEmptyEntries)
     .ToArray();

    string title = inputArticle[0];
    string content = inputArticle[1];
    string author = inputArticle[2];
    Article article = new Article(title, content, author);

    articles.Add(article);
}

foreach (var article in articles)
{
    Console.WriteLine(article);
}

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
   
    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}