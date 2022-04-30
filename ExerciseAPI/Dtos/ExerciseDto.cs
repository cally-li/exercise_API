using ExerciseAPI.Models;
using System.Text.Json.Serialization;

namespace ExerciseAPI.Dtos
{
    public class ExerciseDto
    {
        public int ExerciseId { get; set; }
        public string ExerciseName { get; set; }

        [JsonIgnore]
        public MuscleGroup MuscleGroup { get; set; }    

    }
}
