//string str = Console.ReadLine();
//
//int indexOfFile = str.LastIndexOf('\\') + 1;
//int indexOfExtention = str.LastIndexOf('.');
//
//string fileName = str.Substring(indexOfFile, indexOfExtention - indexOfFile);
//string extentionName = str.Substring(indexOfExtention + 1) ;
//


string[] str = Console.ReadLine().Split("\\");
string lastString = str[str.Length - 1];

string[] lastStringSplited = lastString.Split('.').ToArray();
string fileName = lastStringSplited[0];
string extention = lastStringSplited[1];

Console.WriteLine($"File name: {fileName}");
Console.WriteLine($"File extension: {extention}");