using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;

namespace L8Hands_OnwebAPI.Models 
{
    public class SongContext : DbContext
    {
        public SongContext(DbContextOptions<SongContext> options)
        : base(options)
        {

        }
        public DbSet<Song> Songs {get; set;}
    }
}
