int senturies = int.Parse(Console.ReadLine());
int years = senturies * 100;
int days = (int)(years * 365.2422d);
int hours = days * 24;
int minutes = hours * 60;

Console.WriteLine($"{senturies} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");