using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Test.Business.Interfaces;
using Test.Business.Models;
using Test.Data.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Test.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class DestinationsController : ControllerBase
    {
        private readonly IUserService userService;
        private readonly IMapper mapper;
        private readonly IDestinationService destinationService;

        public DestinationsController(
            IUserService userService,
            IMapper mapper,
            IDestinationService destinationService
            )
        {
            this.userService = userService;
            this.mapper = mapper;
            this.destinationService = destinationService;
        }
  
        [HttpGet]
        public async Task<IActionResult> GetAsync(double lang1, double long1, double lang2, double long2)
        {
            var retObj = await destinationService.GetDistanceAsync(lang1, long1, lang2, long2);
            return Ok(retObj);
        }

        // GET api/<controller>/5
        [HttpGet("{userId}")]
        public async Task<IActionResult> GetAsync(int userId)
        {
            var destinations = await destinationService.GetUserDestinationsAsync(userId);
            var destinationDtos = mapper.Map<IList<DestinationDto>>(destinations);

            return Ok(destinationDtos);
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody]DestinationDto destinationDto)
        {
            var destination = mapper.Map<Destination>(destinationDto);

            var user = await userService.GetByIdAsync(destinationDto.UserId);
            user.Destinations.Add(destination);
            await userService.SaveChangesAsync();

            return Ok();
        }
    }
}
