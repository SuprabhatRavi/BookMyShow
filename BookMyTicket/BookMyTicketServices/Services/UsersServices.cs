using AutoMapper;
using BookMyTicketServices.Modals;

namespace BookMyTicketServices.Services
{
    public class UsersServices : IUsersServices
    {
        private PetaPoco.Database db;
        private IMapper Mapper;

        public UsersServices(IMapper mapper, PetaPoco.Database dbo)
        {
            Mapper = mapper;
            db = dbo;
        }

        public UsersDTO AddUser(UsersDTO user)
        {
            db.Insert("Users", "UserId", true, user);
            return user;
        }

        public void DeleteUser(int id)
        {
            Users UserDetails = db.Single<Users>($"Select * from users where UserId = {id}");
            db.Delete("Users", "UserId", UserDetails);
        }

        public UsersDTO GetUserById(int id)
        {
            Users UserDetails = db.Single<Users>($"Select * from users where UserId = {id}");
            return Mapper.Map<UsersDTO>(UserDetails);
        }

        public IEnumerable<UsersDTO> GetUserList()
        {
            var UserList = db.Query<Users>("Select * from users");
            return Mapper.Map<IEnumerable<UsersDTO>>(UserList);
        }

        public UsersDTO UpdateUserDetails(int id, UsersDTO user)
        {
            if (id == user.UserId)
            {
                db.Update("Users", "UserId", user);
            }
            return user;
        }
    }
}
