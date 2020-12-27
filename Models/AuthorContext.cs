using Microsoft.EntityFrameworkCore;

namespace webapisqlsv1.Models{
  public class AuthorContext:DbContext{
    public AuthorContext(DbContextOptions<AuthorContext> options)
      :base(options){

    }

    public DbSet<AuthorModel> TblAuthor {get; set;}
  }

}