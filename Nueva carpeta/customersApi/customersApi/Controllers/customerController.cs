using Microsoft.AspNetCore.Mvc;
using customersApi.Dtos;
namespace customersApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class customerController : Controller
    {
        [HttpGet()]
        public async Task<List<CustomersDto> GetCustomers()
        {
            throw new NotImplementedException();
        }





        [HttpGet("{id}")]
      public async Task<CustomersDto>GetCustomers(long id)
        {
            throw new NotImplementedException();
        }
    [HttpDelete]

    }
}
