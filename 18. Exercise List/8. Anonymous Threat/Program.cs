using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main()
    {
        List<string> words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

        string command;
        while ((command = Console.ReadLine()) != "3:1")
        {
            string[] cmdArg = command
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string cmdType = cmdArg[0];
            if (cmdType == "merge")
            {
                int startIndex = int.Parse(cmdArg[1]);
                int endIndex = int.Parse(cmdArg[2]);

                StartAndEndIndexInRange(words, ref startIndex, ref endIndex);
                MergedText(words, startIndex, endIndex);

            }
            else if (cmdType == "divide")
            {
                int index = int.Parse(cmdArg[1]);
                int partitions = int.Parse(cmdArg[2]);
                string word = words[index];
                List<string> partitionList = DividedWord(word, partitions);

                words.RemoveAt(index);
                words.InsertRange(index, partitionList);
            }
        }
        Console.WriteLine(string.Join(" ",words));
    }
    static void StartAndEndIndexInRange(List<string> words, ref int startIndex, ref int endIndex)
    {
        if (startIndex < 0)
        {
            startIndex = 0;
        }
        if (startIndex > words.Count - 1)
        {
            startIndex = words.Count - 1;

        }
        if (endIndex >= words.Count)
        {
            endIndex = words.Count - 1;
        }
    }
    static void MergedText(List<string> words, int startIndex, int endIndex)
    {
        string mergedText = string.Empty;

        for (int i = startIndex; i <= endIndex; i++)
        {
            string currentWord = words[startIndex];
            mergedText += currentWord;
            words.RemoveAt(startIndex);
        }
        words.Insert(startIndex, mergedText);

    }

    static List<string> DividedWord(string word, int partitions)
    {        
        int substringLength = word.Length / partitions;
        int lastSubstringLength = substringLength + word.Length % partitions;

        List<string> partitionList = new List<string>();
        for (int i = 0; i < partitions; i++)
        {
            int desiredLength = substringLength;
            if (i == partitions - 1)
            {
                desiredLength = lastSubstringLength;
            }
            char[] newPartitionArr = word
                .Skip(i * substringLength)
                .Take(desiredLength)
                .ToArray();
            string newPartition = string.Join("", newPartitionArr);
            partitionList.Add(newPartition);

        }
        return partitionList;
    }
}