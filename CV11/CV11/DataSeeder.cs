using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cv11.EFCore;
using CV11.EFCore;

namespace CV11
{
    public static class DataSeeder
    {
        public static void SeedDatabase(VyukaContext context)
        {
            context.Database.EnsureCreated();

            // Studenti
            if (!context.Students.Any(s => s.StudentId == 1))
                context.Students.Add(new Student { StudentId = 1, Jmeno = "Eva", Prijmeni = "Nováková", DatumNarozeni = new DateTime(2000, 5, 12) });

            if (!context.Students.Any(s => s.StudentId == 2))
                context.Students.Add(new Student { StudentId = 2, Jmeno = "Jan", Prijmeni = "Horák", DatumNarozeni = new DateTime(1999, 8, 24) });

            if (!context.Students.Any(s => s.StudentId == 3))
                context.Students.Add(new Student { StudentId = 3, Jmeno = "Jan", Prijmeni = "Urban", DatumNarozeni = new DateTime(1989, 12, 2) });

            // Predmety
            if (!context.Predmet.Any(p => p.Zkratka == "MAT01"))
                context.Predmet.Add(new Predmet { Zkratka = "MAT01", Nazev = "Matematika" });

            if (!context.Predmet.Any(p => p.Zkratka == "FYZ01"))
                context.Predmet.Add(new Predmet { Zkratka = "FYZ01", Nazev = "Fyzika" });

            context.SaveChanges();

            // StudentsPredmet
            if (!context.StudentsPredmet.Any(sp => sp.IdStudent == 1 && sp.ZkratkaPredmet == "MAT01"))
                context.StudentsPredmet.Add(new StudentPredmet { IdStudent = 1, ZkratkaPredmet = "MAT01" });

            if (!context.StudentsPredmet.Any(sp => sp.IdStudent == 2 && sp.ZkratkaPredmet == "FYZ01"))
                context.StudentsPredmet.Add(new StudentPredmet { IdStudent = 2, ZkratkaPredmet = "FYZ01" });

            if (!context.StudentsPredmet.Any(sp => sp.IdStudent == 2 && sp.ZkratkaPredmet == "MAT01"))
                context.StudentsPredmet.Add(new StudentPredmet { IdStudent = 2, ZkratkaPredmet = "MAT01" });

            if (!context.StudentsPredmet.Any(sp => sp.IdStudent == 3 && sp.ZkratkaPredmet == "FYZ01"))
                context.StudentsPredmet.Add(new StudentPredmet { IdStudent = 3, ZkratkaPredmet = "FYZ01" });

            // Hodnoceni
            if (!context.Hodnoceni.Any(h => h.IdStudent == 1 && h.ZkratkaPredmet == "MAT01"))
                context.Hodnoceni.Add(new Hodnoceni { IdStudent = 1, ZkratkaPredmet = "MAT01", Datum = DateTime.Today, Znamka = 1.5 });

            if (!context.Hodnoceni.Any(h => h.IdStudent == 2 && h.ZkratkaPredmet == "FYZ01"))
                context.Hodnoceni.Add(new Hodnoceni { IdStudent = 2, ZkratkaPredmet = "FYZ01", Datum = DateTime.Today, Znamka = 2.0 });

            if (!context.Hodnoceni.Any(h => h.IdStudent == 2 && h.ZkratkaPredmet == "MAT01"))
                context.Hodnoceni.Add(new Hodnoceni { IdStudent = 2, ZkratkaPredmet = "MAT01", Datum = DateTime.Today, Znamka = 1.8 });

            if (!context.Hodnoceni.Any(h => h.IdStudent == 3 && h.ZkratkaPredmet == "FYZ01"))
                context.Hodnoceni.Add(new Hodnoceni { IdStudent = 3, ZkratkaPredmet = "FYZ01", Datum = DateTime.Today, Znamka = 2.3 });

            context.SaveChanges();
        }
        }
}
