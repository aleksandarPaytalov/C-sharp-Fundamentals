
string[] input = Console.ReadLine().Split();


for (int i = 0; i < input.Length; i++)
{
    Random random = new Random();
    int randomIndex = random.Next(0, input.Length);


    string currentWord = input[i];
    string randomWord = input[randomIndex];

    input[i] = randomWord;
    input[randomIndex] = currentWord;

}

Console.WriteLine(string.Join(Environment.NewLine, input));