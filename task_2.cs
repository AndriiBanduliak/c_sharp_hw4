//task 2


using static System.Console;
Clear();

Write("Enter the Number: ");
WriteLine($"The sum of the digits in the number is: {sum(int.Parse(ReadLine()))}");

int sum(int digit)
{
    int result = 0;
    while (digit != 0)
    {
        result+=digit%10;
        digit /= 10;
    }
    return result;
}