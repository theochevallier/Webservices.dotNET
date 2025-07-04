using APIWebServices.Dtos;
using APIWebServices.Model;
using APIWebServices.Repository;
using Microsoft.AspNetCore.Http.HttpResults;

namespace APIWebServices.Service
{
    public class UserService
    {
        // private readonly UserRepository _userRepository;

        private readonly List<User> _users = new()
        {
            new User { Id = 1, Name = "John", Email = "john@gmail.com" },
            new User { Id = 2, Name = "Mary", Email = "mary@gmail.com" },
            new User { Id = 3, Name = "Peter", Email = "peter@gmail.com" }
        };

        public List<User> GetAllUsers() => _users;

        public User? GetUserById(int id) => _users.FirstOrDefault(u => u.Id == id);

        public String? GetEmailUserById(int id){
            User? user = _users.FirstOrDefault(u => u.Id == id);
            return user?.Email;
        }

        public void AddUser(User user)
        {
            user.Id = _users.Max(u => u.Id) + 1;
            _users.Add(user);
        }

        public void DeleteUser(int id)
        {
            User? user = _users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                _users.Remove(user);
            } else {
                throw new KeyNotFoundException("Utilisateur non trouvé");
            }
        }
        
        // public UserService(UserRepository userRepository)
        // {
        //     _userRepository = userRepository;
        // }

        // public async Task<List<User>> GetAllUsers() => await _userRepository.GetUsers();

        // public async Task<User?> GetUserById(int id) => await _userRepository.GetUserById(id);

        // public async Task AddUser(UserDto userDto)
        // {
        //     var user = new User
        //     {
        //         Name = userDto.Name,
        //         Email = userDto.Email
        //     };
        //     await _userRepository.AddUser(user);
        // }
    }
}
