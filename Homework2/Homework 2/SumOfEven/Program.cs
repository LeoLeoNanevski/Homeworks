int[] numbers = new int[7];

for (int i = 1; i < numbers.Length; i++)
{
    Console.Write($"Please enther the integer Number {i}: ");
    numbers[i] = int.Parse(Console.ReadLine());
}

int sum = 0;

foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        sum += number;
    }
}

Console.WriteLine($"Result: {sum}");

Console.ReadLine();