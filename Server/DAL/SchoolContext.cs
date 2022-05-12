using BlazorWASMEFCore.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorWASMEFCore.Server.DAL;

/// <summary>
/// This class is used to describe the database i.e. that which we want to manage. 
/// Here we will describe our different tables.
/// </summary>
public class SchoolContext : DbContext
{
    public DbSet<Course> Courses { get; set; }
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-3SV3H5P;Initial Catalog=Databases;Database=SchoolDb;Integrated Security=True;Pooling=False");
    }
}
