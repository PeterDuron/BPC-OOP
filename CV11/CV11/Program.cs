using cv11.EFCore;
using CV11;
using CV11.EFCore;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main()
    {
        using var context = new VyukaContext();
        context.Database.Migrate();
        DataSeeder.SeedDatabase(context);

        Console.WriteLine("\nPredmety a počet zapísaných študentov:");

        var predmetySeStudenty = context.Predmet
            .Select(p => new
            {
                Nazev = p.Nazev,
                PocetStudentu = p.StudentPredmety.Count
            })
            .OrderByDescending(p => p.PocetStudentu)
            .ToList();

        foreach (var p in predmetySeStudenty)
        {
            Console.WriteLine($"{p.Nazev} - {p.PocetStudentu} študentov");
        }

        Console.ReadLine();

        Console.WriteLine("\nŠtudenti zapísaný na FYZ01:");
        foreach (var student in Queries.StudentiPredmetu(context, "FYZ01"))
        {
            Console.WriteLine($"{student.Jmeno} {student.Prijmeni}");
        }

        Console.WriteLine("\nPredmety študenta s ID 2:");
        foreach (var predmet in Queries.PredmetyStudenta(context, 2))
        {
            Console.WriteLine(predmet.Nazev);
        }

        Console.WriteLine("\nPriemerné známky v predmetoch:");

        var prumerneZnamky = context.Predmet
            .Select(p => new
            {
                Nazev = p.Nazev,
                PrumernaZnamka = p.Hodnoceni.Any()
                    ? p.Hodnoceni.Average(h => h.Znamka)
                    : 0
            })
            .ToList();

        foreach (var p in prumerneZnamky)
        {
            Console.WriteLine($"{p.Nazev}: {p.PrumernaZnamka:F2}");
        }
    }
}
