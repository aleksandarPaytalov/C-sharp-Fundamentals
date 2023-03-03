string input = string.Empty;

Dictionary<string, List<string>> companies = 
    new Dictionary<string, List<string>>();
while ((input = Console.ReadLine()) != "End")
{
    string[] cmdArg = input.Split(" -> ");
    string companyName = cmdArg[0];
    string employeeID = cmdArg[1];

    List<string> IDs = new List<string>();
    //if (companies.ContainsKey(companyName) && companies[companyName].Contains(employeeID))
    //{        
    //    continue;
    //}    
    //if (!companies.ContainsKey(companyName))
    //{
    //    companies.Add(companyName, IDs);
    //}
    //
    //companies[companyName].Add(employeeID);

    if (!companies.ContainsKey(companyName))
    {
        companies[companyName] = IDs; // или = new List<string>(); и махаме листа IDs.
        // така можем да добавим конткертния Key вместо с .Add
    }
    if (!companies[companyName].Contains(employeeID))
    {
        companies[companyName].Add(employeeID);
    }
}
foreach (var company in companies)
{
    Console.WriteLine($"{company.Key}");
    foreach (var ID in company.Value)
    {
        Console.WriteLine($"-- {ID}");
    }

}