using DotNetEnv;
using firstASPNET.Models;
using Microsoft.EntityFrameworkCore;

namespace firstASPNET.Data;

public class MvcMovieContext : DbContext
{
    public DbSet<Movie> Movie { get; set; }

    public MvcMovieContext(DbContextOptions<MvcMovieContext> options) : base(options)
    {

    }
}
