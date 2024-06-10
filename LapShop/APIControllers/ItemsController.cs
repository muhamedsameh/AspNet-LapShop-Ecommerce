using LapShop.Bl;
using LapShop.Models;
using Microsoft.AspNetCore.Mvc;


namespace LapShop.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        IItems oItem;
        public ItemsController(IItems iItems)
        {
            oItem = iItems;
        }


        // GET: api/<Items>
        [HttpGet]
        public ApiResponse Get()
        {
            ApiResponse oApiResponse = new ApiResponse();
            oApiResponse.Data = oItem.GetAll();
            oApiResponse.Errors = null;
            oApiResponse.StatusCode = "200";

            return oApiResponse;
        }

        // GET api/<Items>/5
        [HttpGet("{id}")]
        public ApiResponse Get(int id)
        {
            ApiResponse oApiResponse = new ApiResponse();
            oApiResponse.Data = oItem.GetByID(id);
            oApiResponse.Errors = null;
            oApiResponse.StatusCode = "200";

            return oApiResponse;
        }

        // GET api/<Items>/GetByCategory/5
        [HttpGet("GetByCategory/{categoryId}")]
        public ApiResponse GetByCategory(int categoryId)
        {
            ApiResponse oApiResponse = new ApiResponse();
            oApiResponse.Data = oItem.GetAllItemsData(categoryId);
            oApiResponse.Errors = null;
            oApiResponse.StatusCode = "200";

            return oApiResponse;
        }

        // POST api/<ItemsController>
        [HttpPost]
        public ApiResponse Post([FromBody] TbItem item)
        {
            try
            {
                oItem.Save(item);

                ApiResponse oApiResponse = new ApiResponse();
                oApiResponse.Data = "done";
                oApiResponse.Errors = null;
                oApiResponse.StatusCode = "200";

                return oApiResponse;
            }
            catch (Exception ex)
            {
                ApiResponse oApiResponse = new ApiResponse();
                oApiResponse.Data = null;
                oApiResponse.Errors = ex.Message; // list of errors
                oApiResponse.StatusCode = "502";

                return oApiResponse;
            }
        }

        // POST api/<ItemsController>/5
        [HttpPost]
        [Route("Delete")]
        public ApiResponse Delete([FromBody] int id)
        {
            try
            {
                oItem.Delete(id);

                ApiResponse oApiResponse = new ApiResponse();
                oApiResponse.Data = "done";
                oApiResponse.Errors = null;
                oApiResponse.StatusCode = "200";

                return oApiResponse;
            }
            catch (Exception ex)
            {
                ApiResponse oApiResponse = new ApiResponse();
                oApiResponse.Data = null;
                oApiResponse.Errors = ex.Message;
                oApiResponse.StatusCode = "502";

                return oApiResponse;
            }
        }
    }
}
