using BookMyTicketServices.Modals;
using BookMyTicketServices.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BookMyTicketServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersServices Services;

        public UsersController(IUsersServices services)
        {
            Services = services;
        }

        [HttpGet]
        public IEnumerable<UsersDTO> GetContact()
        {
            return Services.GetUserList();
        }

        [HttpGet("{id}")]
        public UsersDTO GetContact(int id)
        {
            return Services.GetUserById(id);
        }

        [HttpPost]
        public UsersDTO AddUser(UsersDTO user)
        {
            Services.AddUser(user);
            return user;
        }

        [HttpPut("{id}")]
        public UsersDTO UpdateUserDetails(int id, UsersDTO user)
        {
            Services.UpdateUserDetails(id, user);
            return user;
        }

        [HttpDelete("{id}")]
        public void DeleteUser(int id)
        {
            Services.DeleteUser(id);
        }
    }
}
