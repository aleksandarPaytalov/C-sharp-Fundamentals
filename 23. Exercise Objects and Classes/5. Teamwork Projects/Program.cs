List<Teams> teams = new List<Teams>();

TeamsCreation(teams);
TeamToJoing(teams);

PrintValidTeams(teams);
PrintTeamsToDisband(teams);


static void PrintTeamsToDisband(List<Teams> teams)
{
    List<Teams> teamsToDisband = teams
        .Where(x => x.Members.Count == 0)
        .OrderBy(x => x.Team)
        .ToList();

    Console.WriteLine("Teams to disband:");
    foreach (var team in teamsToDisband)
    {
        Console.WriteLine($"{team.Team}");
    }
}
static void PrintValidTeams(List<Teams> teams)
{
    List<Teams> teamsWithMembers = teams
        .Where(x => x.Members.Count > 0)
        .OrderByDescending(x => x.Members.Count)
        .ThenBy(x => x.Team)
        .ToList();

    foreach (Teams team in teamsWithMembers)
    {
        Console.WriteLine($"{team.Team}");
        Console.WriteLine($"- {team.Creator}");
        foreach (var member in team.Members.OrderBy(m => m))
        {
            Console.WriteLine($"-- {member}");
        }
    }
}
static void TeamToJoing(List<Teams> teams)
{
    string input = string.Empty;
    while ((input = Console.ReadLine()) != "end of assignment")
    {
        string[] inputCmd = input
            .Split("->", StringSplitOptions.RemoveEmptyEntries);
        string playerToJoin = inputCmd[0];
        string team = inputCmd[1];

        if (AlreadyMemberOfATeam(teams, playerToJoin))
        {
            Console.WriteLine($"Member {playerToJoin} cannot join team {team}!");

        }
        else if (!TeamExist(teams, team))
        {
            Console.WriteLine($"Team {team} does not exist!");
        }
        else
        {
            Teams teamToJoin = teams
                .First(x => x.Team == team);
            teamToJoin.AddMember(playerToJoin);
        }
    }
}
static void TeamsCreation(List<Teams> teams)
{
    int n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
        string[] cmdInput = Console.ReadLine()
            .Split("-", StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        string creator = cmdInput[0];
        string team = cmdInput[1];

        if (TeamExist(teams, team))
        {
            Console.WriteLine($"Team {team} was already created!");
        }
        else if (AlreadyCreatedATeam(teams, creator))
        {
            Console.WriteLine($"{creator} cannot create another team!");
        }
        else
        {
            Teams crntTeam = new Teams(creator, team);
            teams.Add(crntTeam);
            Console.WriteLine($"Team {team} has been created by {creator}!");
        }        
    }
}
static bool AlreadyMemberOfATeam(List<Teams> teams, string playerToJoin)
{
    return teams.Any(x => x.Members.Contains(playerToJoin)) ||
        teams.Any(x => x.Creator == playerToJoin);
}
static bool TeamExist(List<Teams> teams, string team)
{
    return teams.Any(x => x.Team == team);
}
static bool AlreadyCreatedATeam(List<Teams> teams, string creator)
{
    return teams.Any(x => x.Creator == creator);
}

public class Teams
{
    private readonly List<string> members;
    public Teams(string creator, string team)
    {
        this.Creator = creator;
        this.Team = team;

        this.members = new List<string>();
    }
    public string Creator { get; set; }

    public string Team { get; set; }

    // get only property
    public List<string> Members => this.members;

    public void AddMember(string memberName)
    {
       this.members.Add(memberName);
    }
}

