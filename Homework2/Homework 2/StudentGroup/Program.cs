string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentsG2 = { "Dana", "Natali", "Petra", "Joana", "Elena" };

Console.WriteLine("Enter student group: (1 for G1 & 2 for G2)");
int groupNumber = int.Parse(Console.ReadLine());

if (groupNumber == 1)
{
    Console.WriteLine("The Students of G1:");
    foreach (string students in studentsG1)
    {
        Console.WriteLine(students);
    }
}
else if (groupNumber == 2)
{
    Console.WriteLine("The Students of G2:");
    foreach (string students in studentsG2)
    {
        Console.WriteLine(students);
    }
}
else
{
    Console.WriteLine("Error!");
}

Console.ReadLine();