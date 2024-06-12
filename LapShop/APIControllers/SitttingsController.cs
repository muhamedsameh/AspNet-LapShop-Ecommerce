using Domains;
using LapShop.Bl;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LapShop.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SitttingsController : ControllerBase
    {
        ISittings oClsSittings;
        public SitttingsController(ISittings iSittings)
        {
            oClsSittings = iSittings;
        }

        // GET: api/<SitttingsController>
        [HttpGet]
        public TbSittings Get()
        {
            return oClsSittings.GetAll();
        }

    }
}
