using BookMyTicketServices.Modals;
using BookMyTicketServices.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookMyTicketServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowController : ControllerBase
    {
        private readonly IShowServices Services;

        public ShowController(IShowServices services)
        {
            Services = services;
        }

        [HttpGet]
        public IEnumerable<ShowDTO> GetShowList()
        {
            return Services.GetShowList();
        }
        [HttpGet("{id}")]
        public ShowDTO GetShowById(int id)
        {
            return Services.GetShowById(id);
        }
        [HttpPost]
        public ShowDTO AddShow(ShowDTO show)
        {
            return Services.AddShow(show);
        }
        [HttpPatch]
        public ShowDTO UpdateShowDetails(int id, ShowDTO show)
        {
            return Services.UpdateShowDetails(id, show);
        }
        [HttpDelete]
        public void DeleteShow(int id)
        {
            Services.DeleteShow(id);
        }
    }
}
