using ExerciseAPI.Data;
using ExerciseAPI.Interfaces;
using ExerciseAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ExerciseAPI.Repositories
{
    public class ExerciseRepository : IExerciseRepository
    {
        private readonly DataContext _context;

        //constrctor: interact w. DbContext class
        public ExerciseRepository(DataContext context)
        {
            _context = context;
        }
        
        //get all exercises - return a list of all exercises
        public async Task<List<Exercise>> GetAllExercises()
        {
            return await _context.Exercises.ToListAsync();
        }

        //get exercise by Id
        public async Task<Exercise> GetById(int id)
        {
            return await _context.Exercises.Where(e=>e.ExerciseId==id).FirstOrDefaultAsync();
        }

        //check if exercise exists
        public async Task<bool> ExerciseExists(int id)
        {
            return await _context.Exercises.AnyAsync(e=>e.ExerciseId==id);
        }

        //check if muscle group exists by name
        public async Task<bool> MuscleGroupExists(string muscleGroupName)
        {
            return await _context.MuscleGroups.AnyAsync(m => m.MuscleGroupName == muscleGroupName);
        }


        //get exercises by musclegroup
        public async Task<List<Exercise>> GetExercisesByMuscleGroup(string muscleGroup)
        {
            return await _context.Exercises.Where(e => e.MuscleGroup.MuscleGroupName== muscleGroup).ToListAsync();

        }

        //add exercise

    }
}
