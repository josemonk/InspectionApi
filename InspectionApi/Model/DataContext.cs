using Microsoft.EntityFrameworkCore;

namespace InspectionApi.Model
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<Inspection> Inspections { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<Status>Statuses { get; set; }

    }
}
