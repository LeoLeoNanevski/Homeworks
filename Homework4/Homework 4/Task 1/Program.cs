
Console.Write("Enter a string: ");
string input = Console.ReadLine();

if (input.Length >= 5)
{
    string lastFiveChars = input.Substring(input.Length - 5);
    Console.WriteLine("The last five characters of the string are: " + lastFiveChars);
}
else
{
    Console.WriteLine("The input string is less than 5 characters long.");
}