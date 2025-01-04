using Microsoft.EntityFrameworkCore;

namespace automobiles.Data
{
    public class AutomobileContext : DbContext
    {
       

        public DbSet<Automobile> Automobiles { get; set; }
    }

    public class Automobile
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}