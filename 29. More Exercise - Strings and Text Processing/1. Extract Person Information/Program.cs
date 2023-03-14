using System;
using System.Text;

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
	string input = Console.ReadLine();
	StringBuilder sbName = new StringBuilder();
	StringBuilder sbAge = new StringBuilder();
	
	foreach (var item in input)
	{
		if (item == '@')
		{
			int indexName = input.IndexOf(item);
            for (int j = indexName + 1; j < input.Length; j++)
            {
				if (input[j] != '|')
				{
					sbName.Append(input[j]);
				}
				else
				{
					break;
				}
            }
        }
		if (item == '#')
		{
			int indexAge = input.IndexOf('#');
            for (int j = indexAge + 1; j < input.Length; j++)
            {
                if (input[j] != '*')
                {
                    sbAge.Append(input[j]);
                }
                else
                {
                    break;
                }
            }
		}
	}
	Console.WriteLine($"{sbName} is {sbAge} years old.");
}