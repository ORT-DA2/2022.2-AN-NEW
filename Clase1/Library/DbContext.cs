using Microsoft.EntityFrameworkCore;

namespace Library;

public class ContextDb : DbContext
{

    public DbSet<PersonDocument>? PersonsDocuments {get; set; }
    public DbSet<Person>? Persons {get; set; }
    public DbSet<Document>? Documents {get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
	    //the connection string could be stored in appsettings.json 
        optionsBuilder.UseSqlServer(
            "Server=.\\SQLSERVER;Server=localhost,1433;Database=DB;Trusted_Connection=false;MultipleActiveResultSets=True;User=sa;Password=Test@321;");
    }
    
    protected override void OnModelCreating (ModelBuilder modelBuilder)
    {
	    modelBuilder.Entity<PersonDocument>()
		    .HasKey(pp => new { pp.Personld, pp.DocumentId });
	    modelBuilder.Entity<Person>(person =>
	    {
		    person?.HasKey(x => x.Id);
		    person?.HasMany(x => x.Personsdocuments)
			    .WithOne(personDocument => personDocument.Person)
			    .HasForeignKey(personDocument => personDocument.Personld);
	    });

	    modelBuilder.Entity<Document>(document =>
	    {
		    document?.HasKey(x => x.Id);
		    document?.HasMany(x => x.Personsdocuments)
			    .WithOne(personDocument => personDocument.Document)
			    .HasForeignKey(personDocument => personDocument.DocumentId);
	    });
    }
}

