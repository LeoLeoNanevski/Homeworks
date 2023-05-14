using PersonsAndDogs.DB;

// Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER
var result1 = Database.Persons
    .Where(p => p.FirstName.StartsWith("R"))
    .OrderByDescending(p => p.Age)
    .Select(p => p.FirstName);

Console.WriteLine("Persons with first name starting with 'R', ordered by Age (DESC):");
foreach (var name in result1)
{
    Console.WriteLine(name);
}

Console.WriteLine();

