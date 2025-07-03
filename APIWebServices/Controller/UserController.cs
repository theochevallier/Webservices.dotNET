using Microsoft.AspNetCore.Mvc;
using APIWebServices.Dtos;
using APIWebServices.Model;
using APIWebServices.Service;

namespace APIWebServices.Controller
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// Retourne tous les utilisateurs
        /// </summary>
        /// <returns>La liste des utilisateurs</returns>
        /// <response code="200">Retourne la liste des utilisateurs</response>
        /// <response code="404">Retourne une erreur si aucun utilisateur n'a été trouvé</response>
        [HttpGet("getAllUsers")]
        [ProducesResponseType(typeof(List<User>), 200)]
        [ProducesResponseType(404)]
        public ActionResult<List<User>> GetAllUsers()
        {
            return _userService.GetAllUsers();
        }

        /// <summary>
        /// Retourne l'email d'un utilisateur par son ID
        /// </summary>
        /// <param name="id">ID de l'utilisateur</param>
        /// <returns>Retourne l'email si trouvé</returns>
        /// <response code="200">Retourne l'email</response>
        /// <response code="404">Retourne une erreur si l'utilisateur n'a pas été trouvé</response>
        [HttpGet("{id}/getEmail")]
        public ActionResult<string> GetEmail(int id)
        {
            var email = _userService.GetEmailUserById(id);
            if (email == null) return NotFound();
            return email;
        }

        /// <summary>
        /// Retourne un utilisateur par son ID
        /// </summary>
        /// <param name="id">ID de l'utilisateur</param>
        /// <returns>Retourne l'utilisateur si trouvé</returns>
        /// <response code="200">Retourne l'utilisateur</response>
        /// <response code="404">Retourne une erreur si l'utilisateur n'a pas été trouvé</response>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(User), 200)]
        [ProducesResponseType(404)]
        public ActionResult<User> GetUser(int id)
        {
            var user = _userService.GetUserById(id);
            if (user == null) return NotFound();
            return user;
        }

        /// <summary>
        /// Ajoute un nouvel utilisateur
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Retourne l'utilisateur créé</returns>
        [HttpPost]
        public ActionResult AddUser(User user)
        {
            _userService.AddUser(user);
            return CreatedAtAction(nameof(GetUser), new { id = user.Name }, user);
        }

        /// <summary>
        /// Supprime un utilisateur par son ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <response code="200">Utilisateur supprimé</response>
        /// <response code="404">Retourne une erreur si l'utilisateur n'a pas été trouvé</response>
        [HttpDelete("{id}")]
        public ActionResult DeleteUser(int id)
        {
            try {
                _userService.DeleteUser(id);
            } catch (KeyNotFoundException) {
                return NotFound( new { Message = "Suppression impossible, utilisateur non trouvé" });
            }
            return NoContent();
        }
    }
}
