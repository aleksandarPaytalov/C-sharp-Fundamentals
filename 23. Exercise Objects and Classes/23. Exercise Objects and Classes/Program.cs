﻿int n = int.Parse(Console.ReadLine());

string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };

string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };

string[] autors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

for (int i = 0; i < n; i++)
{
    Random random = new Random();
    string phrase = phrases[random.Next(phrases.Length)];
    string @event = events[random.Next(events.Length)];
    string author = autors[random.Next(autors.Length)];
    string city = cities[random.Next(cities.Length)];

    Console.WriteLine($"{phrase} {@event} {author} – {city}.");
}
