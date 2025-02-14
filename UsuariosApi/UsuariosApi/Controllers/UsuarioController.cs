using Microsoft.AspNetCore.Mvc;
using UsuariosApi.Data.Dtos;
using UsuariosApi.Services;

namespace UsuariosApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioService _usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost("cadastro")]
        public async Task<IActionResult> CadastraUsuario(CadastrarUsuarioDto cadastrarUsuarioDto)
        {
            await _usuarioService.Cadastra(cadastrarUsuarioDto);

            return Ok("Usuário cadastrado!");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUsuarioDto loginUsuarioDto)
        {
            var token = await _usuarioService.Login(loginUsuarioDto);

            return Ok(token);
        }
    }
}
