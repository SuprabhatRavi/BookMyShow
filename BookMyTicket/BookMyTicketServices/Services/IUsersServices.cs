using BookMyTicketServices.Modals;

namespace BookMyTicketServices.Services
{
    public interface IUsersServices
    {
        UsersDTO AddUser(UsersDTO user);
        void DeleteUser(int id);
        UsersDTO GetUserById(int id);
        IEnumerable<UsersDTO> GetUserList();
        UsersDTO UpdateUserDetails(int id, UsersDTO user);
    }
}