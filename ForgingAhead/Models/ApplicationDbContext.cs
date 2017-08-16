using Microsoft.EntityFrameworkCore;

namespace ForgingAhead.Models{
	  public class ApplicationDbContext : DbContext{
	  	 public DbSet<Character> Characters { get;set; }
		 
	
	protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseInMemoryDatabase();
            base.OnConfiguring(options);
        }
	}
}