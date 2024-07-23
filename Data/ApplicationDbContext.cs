using ArianNovinProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ArianNovinProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
