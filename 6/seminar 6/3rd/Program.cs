void PrintArray(int[] arr)
{
    int len = arr.Length;
    int pos = 0;
    while (pos < len)
    {
        Console.Write($"{arr[pos]} ");
        pos++;
    }
    Console.WriteLine();
}
Console.Write("Enter N: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arrr = new int[size];
arrr[0] = 0;
arrr[1] = arrr[2] = 1;
for (int i =3; i < arrr.Length; i++) arrr[i] = arrr[i - 1] + arrr[i - 2];
PrintArray(arrr);