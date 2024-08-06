Console.Write("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(Numbers(1, n));

string Numbers(int i, int n)
{
    if (i <= n) return (Numbers(i + 1, n) + $"{i} ");
    else return String.Empty;
}
