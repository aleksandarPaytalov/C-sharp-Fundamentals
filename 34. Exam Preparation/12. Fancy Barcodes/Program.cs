using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

int n = int.Parse(Console.ReadLine());
string pattern = @"[\@][\#]+(?<barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])[\@][\#]+";
Regex regex = new Regex(pattern);

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    Match barcode = regex.Match(input);

    if (barcode.Success)
    {
        string code = string.Empty;
        int count = 0;
        string barcodeName = barcode.Groups["barcode"].Value;

        for (int j = 0; j < barcodeName.Length; j++)
        {
            char letter = barcodeName[j];
            if (char.IsDigit(letter))
            {
                code += letter;
                count++;
            }            
        }
        if (count == 0)
        {
            code = "00";
        }
        Console.WriteLine($"Product group: {code}");
    }
    else
    {
        Console.WriteLine("Invalid barcode");
    }
}
