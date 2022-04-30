using AutoMapper;
using ExerciseAPI.Dtos;
using ExerciseAPI.Interfaces;
using ExerciseAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExerciseAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class categoriesController :Controller
    {
        private readonly IMuscleRepository _muscleRepository;
        private readonly IMapper _mapper;

        //constructor
        public categoriesController(IMuscleRepository muscleRepository, IMapper mapper)
        {
            _muscleRepository = muscleRepository;
            _mapper = mapper;
        }

        //get all
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(List<MuscleGroup>))]
        public async Task<IActionResult> GetAllMuscleGroups()
        {
            var allCategories = await _muscleRepository.GetAllMuscleGroups();
            var allCategoriesToReturn =_mapper.Map<List<MuscleGroupDto>>(allCategories);
            return Ok(allCategoriesToReturn);
        }


    }
}
