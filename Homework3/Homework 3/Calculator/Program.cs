
Console.WriteLine("Please enter the first number for the calculation: ");
double numberOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the second number for the calculation: ");
double numberTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the operation for the calculation: (+, -, *, /):");
char operation = char.Parse(Console.ReadLine());

double result = 0;

switch (operation)
{
    case '+':
        result = numberOne + numberTwo;
        break;
    case '-':
        result = numberOne - numberTwo;
        break;
    case '*':
        result = numberOne * numberTwo;
        break;
    case '/':
        if (numberTwo == 0)
        {
            Console.WriteLine("Error: all numbers divided by zero are \"0\"");
        }
        else
        {
            result = numberOne / numberTwo;
        }
        break;
    default:
        Console.WriteLine("Error!");
        break;
}

Console.WriteLine("Result of the operation is: " + result);