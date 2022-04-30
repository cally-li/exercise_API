using AutoMapper;
using ExerciseAPI.Dtos;
using ExerciseAPI.Interfaces;
using ExerciseAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExerciseAPI.Controllers
{
    //attributes
    [ApiController]
    //all routes start with api. [controller] is a placeholder 
    [Route("api/[controller]")]
    public class exercisesController : Controller
    {
        private readonly IExerciseRepository _exerciseRepository;
        private readonly IMapper _mapper;

        //constructor: DI with repository pattern
        public exercisesController(IExerciseRepository exerciseRepository, IMapper mapper)
        {
            _exerciseRepository = exerciseRepository;
            _mapper = mapper;
        }

        //get all exercises
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(List<Exercise>))]
        public async Task<IActionResult> GetAllExercises()
        {
            var allExercises=await _exerciseRepository.GetAllExercises();   
            var allExercisesToReturn=_mapper.Map<List<ExerciseDto>>(allExercises);   
            
            return Ok(allExercisesToReturn);
        }

        //get exercise by id
        [HttpGet("{exerciseId}")]
        [ProducesResponseType(200, Type = typeof(Exercise))]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetExerciseById(int exerciseId)
        {
            //validate id exists
            if (! await _exerciseRepository.ExerciseExists(exerciseId))
                return NotFound();

            var exercise =await _exerciseRepository.GetById(exerciseId);
            var exerciseToReturn =_mapper.Map<ExerciseDto>(exercise);
            return Ok(exerciseToReturn);
                
        }

        //get exercises by muscle group name
        [HttpGet("category/{muscleGroupName}")]
        [ProducesResponseType(200, Type = typeof(List<Exercise>))]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetExercisesByMuscleGroup(string muscleGroupName)
        {
            //validate muscle group exists
            if (! await _exerciseRepository.MuscleGroupExists(muscleGroupName))
                return NotFound(muscleGroupName);

            var exercises = await _exerciseRepository.GetExercisesByMuscleGroup(muscleGroupName);
            var exercisesToReturn = _mapper.Map <List<ExerciseDto>>(exercises);
            return Ok(exercisesToReturn);
        }



    }
}
