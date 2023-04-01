string input = string.Empty;
Dictionary<string, int> children = 
    new Dictionary<string, int>();
Dictionary<string, int> presents =
    new Dictionary<string, int>();

while ((input = Console.ReadLine()) != "END")
{
    string[] currentChild = input.Split("->").ToArray();
    string childName = currentChild[0];

    if (childName == "Remove")
    {
        string nameToRemove = currentChild[1];
        if (children.ContainsKey(nameToRemove))
        {
            children.Remove(nameToRemove);
        }        
    }
    else
    {
        string toyName = currentChild[1];
        int toyNumber = int.Parse(currentChild[2]);

        if (!children.ContainsKey(childName))
        {
            children[childName] = toyNumber;
        }
        else
        {
            int totalPresents = children[childName] + toyNumber;
            children[childName] = totalPresents;
        }
        if (!presents.ContainsKey(toyName))
        {
            presents[toyName] = toyNumber;
        }
        else
        {
            int totalPresents = presents[toyName] + toyNumber;
            presents[toyName] = totalPresents;
        }
    }
}

var ordered = children.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

Console.WriteLine("Children:");
foreach (var child in ordered)
{
    Console.WriteLine($"{child.Key} -> {child.Value}");
}
Console.WriteLine("Presents:");
foreach (var gift in presents)
{
    Console.WriteLine($"{gift.Key} -> {gift.Value}");
}