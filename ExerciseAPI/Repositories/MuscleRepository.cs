using ExerciseAPI.Data;
using ExerciseAPI.Interfaces;
using ExerciseAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ExerciseAPI.Repositories
{
    public class MuscleRepository : IMuscleRepository
    {
        private readonly DataContext _context;

        //constructor- interact with DbContext
        public MuscleRepository(DataContext context)
        {
            _context = context;
        }
        
        //get all muscle groups
        public async Task<List<MuscleGroup>> GetAllMuscleGroups()
        {
            return await _context.MuscleGroups.ToListAsync();
        }

     


    }


}
