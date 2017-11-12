namespace VegaSystem.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using VegaSystem.Entities;
    using VegaSystem.Resources;

    [Route("/api/vehicles")]
    public class VehiclesController : Controller
    {
        private readonly IMapper mapper;

        public VehiclesController(IMapper mapper)
        {
            this.mapper = mapper;

        }

        public IActionResult CreateVehicle([FromBody] VehicleResource vehicleResource)
        {
            var vehicle = mapper.Map<VehicleResource, Vehicle>(vehicleResource);
            return Ok(vehicle);
        }
    }
}