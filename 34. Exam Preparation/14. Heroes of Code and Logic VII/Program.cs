int n = int.Parse(Console.ReadLine());
Dictionary<string, string> heroes = new Dictionary<string, string>();

for (int i = 0; i < n; i++)
{
    string[] heroInfo = Console.ReadLine()
        .Split(" ")
        .ToArray();
    string heroName = heroInfo[0];
    string hp = heroInfo[1];
    string mp = heroInfo[2];

    heroes[heroName] = $"{hp}:{mp}";   
}

string input = string.Empty;
while ((input = Console.ReadLine()) != "End")
{
    string[] cmd = input.Split(" - ").ToArray();
    string cmdType = cmd[0];
    string heroName = cmd[1];

    int[] currentHerroInfo = heroes[heroName].Split(":").Select(int.Parse).ToArray();
    int currentHP = currentHerroInfo[0];
    int currentMP = currentHerroInfo[1];

    if (cmdType == "CastSpell")
    {
        int neededMP = int.Parse(cmd[2]);
        string spellName = cmd[3];

        if (currentMP >= neededMP)
        {
            currentMP -= neededMP;
            heroes[heroName] = $"{currentHP}:{currentMP}";
            Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {currentMP} MP!");
        }
        else
        {
            Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
        }
        
    }
    else if (cmdType == "TakeDamage")
    {
        int damage = int.Parse(cmd[2]);
        string attackerName = cmd[3];

        currentHP -= damage;
        if (currentHP > 0)
        {
            Console.WriteLine($"{heroName} was hit for {damage} HP by {attackerName} and now has {currentHP} HP left!");
            heroes[heroName] = $"{currentHP}:{currentMP}";
        }
        else
        {
            Console.WriteLine($"{heroName} has been killed by {attackerName}!");
            heroes.Remove(heroName);
        }
    }
    else if (cmdType == "Recharge")
    {
        int recharge = int.Parse(cmd[2]);

        int storedMP = currentMP;
        currentMP += recharge;
        if (currentMP > 200)
        {
            Console.WriteLine($"{heroName} recharged for {200 - storedMP} MP!");
            currentMP = 200;
        }
        else
        {
            Console.WriteLine($"{heroName} recharged for {recharge} MP!");
        }
        heroes[heroName] = $"{currentHP}:{currentMP}";
    }
    else if (cmdType == "Heal")
    {
        int heal = int.Parse(cmd[2]);

        int storedHP = 100 - currentHP;
        currentHP += heal;
        if (currentHP > 100)
        {                      
            Console.WriteLine($"{heroName} healed for {storedHP} HP!");
            currentHP = 100;
        }
        else
        {
            Console.WriteLine($"{heroName} healed for {heal} HP!");
        }
        heroes[heroName] = $"{currentHP}:{currentMP}";
    }
}

foreach (var item in heroes)
{
    int[] currentHerroInfo = heroes[item.Key].Split(":").Select(int.Parse).ToArray();
    int currentHP = currentHerroInfo[0];
    int currentMP = currentHerroInfo[1];

    Console.WriteLine($"{item.Key}");
    Console.WriteLine($"HP: {currentHP}");
    Console.WriteLine($"MP: {currentMP}");
}