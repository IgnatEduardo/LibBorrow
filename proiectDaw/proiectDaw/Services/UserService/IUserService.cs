using proiectDaw.Models.DTOs;
using proiectDaw.Models;

namespace proiectDaw.Services.UserService
{
    public interface IUserService
    {
        UserResponseDTO Authentificate(UserRequestDTO model);
        User GetById(Guid id);
        Task<List<User>> GetAllUsers();
        Task Create(User newUser);
        Task Delete(User userToDelete);
        Task Update(User userToUpdate);
        bool Save();
    }
}
