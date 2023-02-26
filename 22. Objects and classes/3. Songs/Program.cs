int n = int.Parse(Console.ReadLine());
List<Song> songs = new List<Song>();

for (int i = 0; i < n; i++)
{
    string[] data = Console.ReadLine().Split("_");
    string typeList = data[0];
    string name = data[1];
    string time = data[2];

    Song song = new Song();
    song.Typelist = typeList;
    song.Name = name;
    song.Time = time;

    songs.Add(song);
}
string givenTypeList = Console.ReadLine();

foreach (var song in songs)
{
    if (givenTypeList == "all")
    {
        Console.WriteLine(song.Name);
    }
    else
    {
        if (song.Typelist == givenTypeList)
        {
            Console.WriteLine(song.Name);
        }    
    }
}
class Song
{
    public string Typelist { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }

}