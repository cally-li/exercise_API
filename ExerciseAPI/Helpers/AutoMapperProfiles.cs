using ExerciseAPI.Dtos;
using ExerciseAPI.Models;
using AutoMapper;

namespace ExerciseAPI.Helpers
{
    public class AutoMapperProfiles :Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<MuscleGroupDto, MuscleGroup>().ReverseMap();
            CreateMap<ExerciseDto, Exercise >().ReverseMap();


        }
    }
}
