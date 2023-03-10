string[] userNames = Console.ReadLine()
    .Split(", ");

bool isValid = false;
foreach (var word in userNames)
{
    if (word.Length >= 3 && word.Length <= 16)
    {
        for (int i = 0; i < word.Length; i++)
        {
            char currentLetter = word[i];
            if (char.IsLetterOrDigit(currentLetter) || currentLetter == '-'
                || currentLetter == '_')
            {
                isValid = true;
            }
            else
            {
                isValid = false;
                break;
            }
        }
        if (isValid)
        {
            Console.WriteLine(word);
        }
    }
}
