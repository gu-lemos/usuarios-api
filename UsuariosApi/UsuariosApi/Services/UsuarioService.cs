using AutoMapper;
using Microsoft.AspNetCore.Identity;
using UsuariosApi.Data.Dtos;
using UsuariosApi.Models;

namespace UsuariosApi.Services
{
    public class UsuarioService
    {
        private readonly IMapper _mapper;
        private readonly UserManager<Usuario> _userManager;
        private readonly SignInManager<Usuario> _signInManager;
        private readonly TokenService _tokenService;

        public UsuarioService(IMapper mapper, UserManager<Usuario> userManager, SignInManager<Usuario> signInManager, TokenService tokenService)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }

        public async Task Cadastra(CadastrarUsuarioDto cadastrarUsuarioDto)
        {
            var usuario = _mapper.Map<Usuario>(cadastrarUsuarioDto);

            var resultado = await _userManager.CreateAsync(usuario, cadastrarUsuarioDto.Password);

            if (resultado.Succeeded is false)
                throw new ApplicationException("Falha ao cadastrar usuário!");
        }

        public async Task<string> Login(LoginUsuarioDto loginUsuarioDto)
        {
            var resultado = await _signInManager.PasswordSignInAsync(loginUsuarioDto.Username, loginUsuarioDto.Password, false, false);

            if (resultado.Succeeded is false)
                throw new ApplicationException("Falha ao realizar o login!");

            var usuario = _signInManager.UserManager.Users.First(user => user.NormalizedUserName == loginUsuarioDto.Username.ToUpper());

            var token = _tokenService.GenerateToken(usuario);

            return token;
        }
    }
}
