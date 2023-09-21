using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Regions()
        {
            var regions = new List<Region>
            {
                Capacity = 0
            };

            regions.Add(new Region
            {
                Id = Guid.NewGuid(),
                Name = "Auckland Region",
                Code = "AKL",
                RegionImageUrl = "https://www.pexels.com/photo/young-woman-sitting-in-an-armchair-in-a-modern-room-18238186/"
            });

            regions.Add(new Region
            {
                Id = Guid.NewGuid(),
                Name = "Maryland",
                Code = "MRY",
                RegionImageUrl = "https://www.pexels.com/photo/feeling-series-18417020/"
            });

            return Ok(regions);
        }
    }
}
