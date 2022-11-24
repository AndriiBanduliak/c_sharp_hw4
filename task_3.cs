// task 3

using static System.Console;
Clear();

WriteLine("Введите количество элементов в массиве: ");
int n = Int32.Parse(ReadLine());

printArrOfLength(n);


void printArrOfLength(int Length)
{
    int[] arr = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        WriteLine($"Enter the {i+1} array element ");
        arr[i] = int.Parse(ReadLine());
    }
    Write("[");
    for (int i = 0; i < Length; i++)
    {
        Write(arr[i]);
        if (i < arr.Length - 1) Write(", ");
    }
    Write("]");
}