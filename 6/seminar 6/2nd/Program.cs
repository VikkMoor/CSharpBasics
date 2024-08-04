void PrintArray(int[] arr)
{
    int len = arr.Length;
    int pos = 0;
    while (pos < len)
    {
        Console.Write($"{arr[pos]}");
        pos++;
    }
    Console.WriteLine();
}
void ReverseArray(int[] arr3)
{
    int digit = 0;
    int len3 = arr3.Length;
    for (int i = 0; i < len3 / 2; i++)
    {
        digit = arr3[i];
        arr3[i] = arr3[len3 - 1 - i];
        arr3[len3 - 1 - i] = digit;
    }
}
Console.Write("Enter number: ");
int input = Convert.ToInt32(Console.ReadLine());
int count = 0, res = 0, j = 0;
for (int i = input; i > 0; i /= 2) count++;
int[] array = new int[count];
while (input > 0)
{
    res = input % 2;
    input = input / 2;
    array[j] = res;
    j++;
}
ReverseArray(array);
PrintArray(array);