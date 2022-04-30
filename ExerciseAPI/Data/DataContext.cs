using ExerciseAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ExerciseAPI.Data
{
    public class DataContext: DbContext
    {
        //generic type arg = a class that inherits from DbContext class
        //base : the constructor calls the parameterized constructor of the parent DbContext class and passes in the DbContextOptions instance (options)
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //Define DbSet properties 
        public DbSet<Exercise> Exercises{ get; set; }
        public DbSet<MuscleGroup> MuscleGroups{ get; set; }

     
        //configure models w/ fluent API 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //optional one-to-many configuration
            modelBuilder.Entity<Exercise>()
                .HasOne(e => e.MuscleGroup)
                .WithMany(m => m.Exercises)
                .HasForeignKey(e => e.MuscleGroupId);


        }

    }
}
