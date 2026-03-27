using DesafioIndustriALL.Application.DTOs;
using DesafioIndustriALL.Application.Interfaces;
using DesafioIndustriALL.Application.Repository;
using DesafioIndustriALL.Domain.Entities;
using DesafioIndustriALL.Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DesafioIndustriALL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
     
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {             
            return Ok(_userRepository.GetAllUsers());
        }

        [HttpPost]
        public IActionResult CreateUser(UserDTO newUser)
        {
            _userRepository.CreateUser(newUser);
            if(_userRepository.SaveUser())
            {
                return Ok("Usuário criado com sucesso.");
            }
            return BadRequest("Ocorreu um erro inesperado.");
            
        }
    }
}
