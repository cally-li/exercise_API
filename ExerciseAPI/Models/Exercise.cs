namespace ExerciseAPI.Models
{
    public class Exercise
    {
        public int ExerciseId { get; set; }
        public string ExerciseName { get; set; }
        
        //foreign key
        public int MuscleGroupId { get; set; }  

        //inverse nav property
        public MuscleGroup MuscleGroup { get; set; }
        
    }
}

