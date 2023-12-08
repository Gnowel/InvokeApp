using InvokeApp.Core.Entities;
using InvokeApp.Infrastructure.Context;
using InvokeApp.Shared.DTOs.Users;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InvokeApp.WebAPI.Controllers
{
    /// <summary>
    /// Контроллер для пользователей
    /// </summary>
    public class UserController : Controller
    {
        private readonly InvokeAppDbContext _context;

        public UserController(InvokeAppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Регистрация пользователя
        /// </summary>
        /// <param name="request">Данные регистрации</param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/user/register")]
        public async Task<ActionResult> RegisterAsync([FromBody] RegisterDto request)
        {

            if (await _context.Users.AnyAsync(u => u.Email == request.Email))
            {
                return BadRequest("Пользователь с такой почтой уже зарегистрирован.");
            }

            var user = new User()
            {
                Name = request.Name,
                Email = request.Email,
                Password = request.Password
            };

            await _context.AddAsync(user);
            await _context.SaveChangesAsync();

            return Ok("Успешная регистрация!");
        } 

        /// <summary>
        /// Обновляет данные пользователя (имя и фотографию)
        /// </summary>
        /// <param name="id">Id пользователя</param>
        /// <param name="request">Данные, которые нужно сменить</param>
        /// <returns>Пользователь с обновленными данными</returns>
        [HttpPatch]
        [Route("api/user/update-user/{id}")]
        public async Task <ActionResult> UpdateUser(int id, [FromBody] JsonPatchDocument<UserUpdateDto> request)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);

            if(user == null)
            {
                return NotFound();
            }

            var userDto = new UserUpdateDto()
            {
                Name = user.Name,
                ImageUrl = user.ImageUrl,
            };

            request.ApplyTo(userDto);

            user.Name = userDto.Name;
            user.ImageUrl = userDto.ImageUrl;

            _context.Update(user);
            await _context.SaveChangesAsync();

            return Ok(user);
        }
    }
}
