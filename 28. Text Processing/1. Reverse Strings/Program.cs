string currentWord = string.Empty;

while ((currentWord = Console.ReadLine()) != "end")
{
	string reversedWord = string.Empty;
	for (int i = currentWord.Length - 1; i >= 0; i--)
	{
		char currentLetter = currentWord[i];
		reversedWord += currentLetter;
	}
	Console.WriteLine($"{currentWord} = {reversedWord}");
}