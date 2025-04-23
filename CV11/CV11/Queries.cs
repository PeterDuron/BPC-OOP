using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;
using System.Linq;
using cv11.EFCore;

namespace CV11.EFCore;

public static class Queries
{
    public static IEnumerable<Student> StudentiPredmetu(VyukaContext context, string zkratkaPredmetu)
    {
        return context.StudentsPredmet
            .Where(sp => sp.ZkratkaPredmet == zkratkaPredmetu)
            .Select(sp => sp.Student)
            .ToList();
    }

    public static IEnumerable<Predmet> PredmetyStudenta(VyukaContext context, int studentId)
    {
        return context.StudentsPredmet
            .Where(sp => sp.IdStudent == studentId)
            .Select(sp => sp.Predmet)
            .ToList();
    }
}
