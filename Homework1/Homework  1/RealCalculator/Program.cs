Console.WriteLine("This is Real Calculator with 2 numbers. Please enter the First number:");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter the Second number:");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter the desired operation (+, -, *, /):");
string operation = Console.ReadLine();

double result = 0;
switch (operation)
{
    case "+":
        result = num1 + num2;
        break;
    case "-":
        result = num1 - num2;
        break;
    case "*":
        result = num1 * num2;
        break;
    case "/":
        result = num1 / num2;
        break;
    default:
        Console.WriteLine("Error!!!");
        break;
}

Console.WriteLine("The result of the operation is: " + result);