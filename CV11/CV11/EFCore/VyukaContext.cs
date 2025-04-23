using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using cv11.EFCore;
using CV11.EFCore;
using Microsoft.EntityFrameworkCore;

namespace cv11.EFCore;

public class VyukaContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Predmet> Predmet { get; set; }
    public DbSet<Hodnoceni> Hodnoceni { get; set; }
    public DbSet<StudentPredmet> StudentsPredmet { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\vyuka.mdf;Integrated Security=True;Connection Timeout=30");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StudentPredmet>()
            .HasKey(sp => new { sp.IdStudent, sp.ZkratkaPredmet });

        modelBuilder.Entity<Hodnoceni>()
            .HasKey(h => new { h.IdStudent, h.ZkratkaPredmet });

        modelBuilder.Entity<StudentPredmet>()
            .HasOne(sp => sp.Student)
            .WithMany(s => s.StudentPredmety)
            .HasForeignKey(sp => sp.IdStudent);

        modelBuilder.Entity<StudentPredmet>()
            .HasOne(sp => sp.Predmet)
            .WithMany(p => p.StudentPredmety)
            .HasForeignKey(sp => sp.ZkratkaPredmet);

        modelBuilder.Entity<Hodnoceni>()
            .HasOne(h => h.Student)
            .WithMany(s => s.Hodnoceni)
            .HasForeignKey(h => h.IdStudent);

        modelBuilder.Entity<Hodnoceni>()
            .HasOne(h => h.Predmet)
            .WithMany(p => p.Hodnoceni)
            .HasForeignKey(h => h.ZkratkaPredmet);
    }
}
