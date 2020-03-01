using Microsoft.AspNetCore.Mvc;
using Identicon.Algorithms;
using Identicon.Mappers;
using Identicon.Models;

namespace Identicon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IconGeneratorController : ControllerBase
    {
        [HttpGet("{size}/{seed}")]
        //[Produces("image/png")]
        public ActionResult<IdenticonResult> Get(int size, string seed)
        {
            if(!(seed == ""))
            {
                byte[] image = new IdenticonAlgorithm().CreateIdenticon(seed, size);
                return Ok(Mapper.Map(image, size));
            } else
            {
                return BadRequest();
            }
            
        }
    }
}
