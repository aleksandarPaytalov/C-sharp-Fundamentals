int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

int targetsPoked = 0;
double halfPower = n * 0.5;

while (n >= m)
{             
    if (n == halfPower && y != 0)
    {                
        n /= y;
        continue;            
    }
    targetsPoked++; 
    n -= m;
}
Console.WriteLine(n);
Console.WriteLine(targetsPoked);