using ExerciseAPI.Models;

namespace ExerciseAPI.Interfaces
{
    public interface IMuscleRepository
    {
        //get all muscle group categories
        Task<List<MuscleGroup>> GetAllMuscleGroups();



    }
}
