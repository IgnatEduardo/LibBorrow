using proiectDaw.Data.UitOfWork;
using proiectDaw.Helper.JwUtils;
using proiectDaw.Models;
using proiectDaw.Models.DTOs;
using proiectDaw.Repositories.UserRepository;
using BCryptNet = BCrypt.Net.BCrypt;

namespace proiectDaw.Services.UserService
{
    public class UserService : IUserService
    {
        public IUserRepository _userRepository;
        public IJwtUtils _jwtUtils;
        public IUnitOfWork _unitOfWork;

        public UserService(IUserRepository userRepository, IJwtUtils jwtUtils)
        {
            _userRepository = userRepository;
            _jwtUtils = jwtUtils;
        }

        public UserResponseDTO Authentificate(UserRequestDTO model)
        {
            var user = _userRepository.FindByEmail(model.Email);
            if (user == null || !BCryptNet.Verify(model.Password, user.PasswordHash))
            {
                return null;
            }

            var token = _jwtUtils.GenerateJwtToken(user);
            return new UserResponseDTO(user, token);
        }

        public async Task Create(User newUser)
        {
            await _userRepository.CreateAsync(newUser);
            await _userRepository.SaveAsync();
        }

        public async Task Delete(User deleteUser)
        {
            _userRepository.Delete(deleteUser);
            await _unitOfWork.SaveAsync();
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _userRepository.GetAllAsync();
        }

        public User GetById(Guid id)
        {
            return _userRepository.FindById(id);
        }

        public bool Save()
        {
            return _userRepository.Save();
        }

        public async Task Update(User updateUser)
        {
            _userRepository.Update(updateUser);
            await _unitOfWork.SaveAsync();
        }
    }
}
