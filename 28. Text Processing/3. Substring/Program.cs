string wordToRemove = Console.ReadLine();
string word = Console.ReadLine();

while (word.Contains(wordToRemove))
{
    int index = word.IndexOf(wordToRemove);
    word = word.Remove(index, wordToRemove.Length);
}

Console.WriteLine(word);