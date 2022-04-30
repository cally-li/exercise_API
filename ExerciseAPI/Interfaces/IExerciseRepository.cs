using ExerciseAPI.Models;

namespace ExerciseAPI.Interfaces
{
    public interface IExerciseRepository
    {
        //get all exercises
        Task<List<Exercise>> GetAllExercises();

        //get exercise by Id
        Task<Exercise> GetById(int id);

        //check if exercise exists
        Task<bool> ExerciseExists(int id);

        //check if muscle group exists by name
        Task<bool> MuscleGroupExists(string muscleGroupName);

        //get list of exercises by muscle group
        Task<List<Exercise>> GetExercisesByMuscleGroup(string muscleGroup);



    }
}
