
int AgeCalculator(DateTime birthday)
{
    DateTime today = DateTime.Today;
    int age = today.Year - birthday.Year;
    if (birthday > today.AddYears(-age))
    {
        age--;
    }
    return age;
}
Console.Write("Enter your birthday (yyyy-mm-dd): ");
DateTime birthday = DateTime.Parse(Console.ReadLine());

int age = AgeCalculator(birthday);
Console.WriteLine("Your age is: " + age);