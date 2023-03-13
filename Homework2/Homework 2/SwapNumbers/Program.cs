Console.WriteLine("Please type number:");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Please type second number:");
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Before Swapping:");
Console.WriteLine($"First Number: {firstNumber}");
Console.WriteLine($"Second Number: {secondNumber}");

int prvBroj = firstNumber;
firstNumber = secondNumber;
secondNumber = prvBroj;

Console.WriteLine("Output after Swapping:");
Console.WriteLine($"First Number: {firstNumber}");
Console.WriteLine($"Second Number: {secondNumber}");

Console.ReadLine();