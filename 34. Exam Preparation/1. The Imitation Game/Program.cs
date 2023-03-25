string encryptedMessage = Console.ReadLine();
string input = string.Empty;

while ((input = Console.ReadLine()) != "Decode")
{
    string[] cmd = input.Split("|").ToArray();
    string cmdtype = cmd[0];

    if (cmdtype == "Move")
    {
        int lettersToMove = int.Parse(cmd[1]);
        string substring = encryptedMessage.Substring(0, lettersToMove);
        encryptedMessage = encryptedMessage.Remove(0, lettersToMove);
        encryptedMessage += substring;       
    }
    else if (cmdtype == "Insert")
    {
        int index = int.Parse(cmd[1]);
        string textToInsert = cmd[2];
        encryptedMessage = encryptedMessage.Insert(index, textToInsert);        
    }
    else if (cmdtype == "ChangeAll")
    {
        char substring = char.Parse(cmd[1]);
        char newSubstring = char.Parse(cmd[2]);
        //foreach (var item in encryptedMessage)
        //{
        //    if (item == substring)
        //    {
        //        encryptedMessage = encryptedMessage.Replace(item, newSubstring);
        //    }
        //}
        if (encryptedMessage.Contains(substring))
        {
            encryptedMessage = encryptedMessage.Replace(substring, newSubstring);
        }
    }
}
Console.WriteLine($"The decrypted message is: {encryptedMessage}");