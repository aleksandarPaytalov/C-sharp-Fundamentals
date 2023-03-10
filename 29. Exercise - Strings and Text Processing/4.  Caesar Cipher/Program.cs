using System.Text;

string str = Console.ReadLine();
//string strinng = string.Empty;
StringBuilder sb = new StringBuilder();
for (int i = 0; i < str.Length; i++)
{    
    int index = str[i] + 3;
    char letter = (char)index;
    sb.Append(letter);
    //strinng += letter;
}

Console.WriteLine(sb);