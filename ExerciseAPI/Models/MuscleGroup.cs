namespace ExerciseAPI.Models
{
    public class MuscleGroup
    {
        public int MuscleGroupId { get; set; } 
        public string MuscleGroupName { get; set; }

        // nav property
        public ICollection<Exercise>? Exercises { get; set; }

    }
}

//one to many (muscle to exercises)