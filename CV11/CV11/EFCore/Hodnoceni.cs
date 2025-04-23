using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cv11.EFCore;

namespace CV11.EFCore
{
    public class Hodnoceni
    {
        public int IdStudent { get; set; }
        public string ZkratkaPredmet { get; set; }

        public DateTime Datum { get; set; }
        public double Znamka { get; set; }

        public Student Student { get; set; }
        public Predmet Predmet { get; set; }


    }
}
