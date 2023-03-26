
Console.Write("Enter a sentence: ");
string input = Console.ReadLine();

string[] words = input.Split(' ');

Console.WriteLine("The words in the sentence are:");
foreach (string word in words)
{
    Console.WriteLine(word);
}