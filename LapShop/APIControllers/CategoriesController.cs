using LapShop.Bl;
using LapShop.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LapShop.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategories oCategories;
        public CategoriesController(ICategories iCategories)
        {
            oCategories = iCategories;
        }

        // GET: api/<Categories>
        [HttpGet]
        public IEnumerable<TbCategory> Get()
        {
            return oCategories.GetAll();
        }

        // GET api/<Categories>/5
        [HttpGet("{id}")]
        public TbCategory Get(int id)
        {
            return oCategories.GetByID(id);
        }

        // POST api/<Categories>
        [HttpPost]
        public void Post([FromBody] TbCategory category)
        {
            oCategories.Save(category);
        }

        // POST api/<Categories>/Delete
        [HttpPost]
        [Route("Delete")]
        public void Delete([FromBody] int id)
        {
            oCategories.Delete(id);
        }

    }
}
