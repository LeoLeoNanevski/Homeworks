Console.WriteLine("Please enter the First number:");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter the Second number:");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter the Third number:");
double num3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter the Fourth number:");
double num4 = Convert.ToDouble(Console.ReadLine());

double avg = (num1 + num2 + num3 + num4) / 4;

Console.WriteLine("The average of 4 entered numbers: " + num1 + ", " + num2 + ", " + num3 + " and " + num4 + " is: " + avg);