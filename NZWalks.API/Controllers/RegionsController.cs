using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;
using NZWalks.API.Response;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly NZWalksDbContext _dbContext;

        public RegionsController(NZWalksDbContext nzWalksDbContext)
        {
            this._dbContext = nzWalksDbContext;

        }
        
        [HttpGet("/regions-dummy")]
        public IActionResult RegionsDummy()
        {
            var regions = new List<Region>
            {
                new Region(id: Guid.NewGuid(), name: "Auckland Region", code: "AKL",
                    regionImageUrl:
                    "https://www.pexels.com/photo/young-woman-sitting-in-an-armchair-in-a-modern-room-18238186/"),
                new Region(id: Guid.NewGuid(), name: "Maryland", code: "MRY",
                    regionImageUrl: "https://www.pexels.com/photo/feeling-series-18417020/")
            };
            return Ok(regions);
        }

        [HttpGet]
        public IActionResult Regions()
        {
            List<Region> list = _dbContext.Regions.ToList() ??
                                throw new ArgumentNullException($"{nameof(_dbContext)}.Regions.ToList()");
            var regions = list;
            return regions.Count > 0 ? Ok(regions) : NotFound("regions not found");
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public IActionResult GetById([FromRoute] Guid id)
        {
            // var region = _dbContext.Regions.Find(id);

            var region = _dbContext.Regions.FirstOrDefault(x => x.Id == id);
            
            if (region == null)
            {
                return NotFound();
            }
            CommonResponse<Region> csr = new CommonResponse<Region>(20, "aa", region);

            return Ok(csr);
        }
    }
}
