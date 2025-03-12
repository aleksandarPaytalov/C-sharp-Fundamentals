string[] name = { "Stoyan", "Asenov", "Petkov" };

for (int i = 0; i < name.Length; i++)
{
    //if (i == name.Length - 1)
    //    Console.Write(name[i]);
    //else 
    //Console.Write(name[i] + "-");
   
}
name = name.Reverse().ToArray();
//Console.WriteLine(name);
Console.Write(string.Join(", ", name));