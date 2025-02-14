using AutoMapper;
using Microsoft.AspNetCore.Identity;
using UsuariosApi.Data.Dtos;
using UsuariosApi.Models;

namespace UsuariosApi.Services
{
    public class CadastroService
    {
        private readonly IMapper _mapper;
        private readonly UserManager<Usuario> _userManager;

        public CadastroService(IMapper mapper, UserManager<Usuario> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task Cadastra(CadastrarUsuarioDto cadastrarUsuarioDto)
        {
            var usuario = _mapper.Map<Usuario>(cadastrarUsuarioDto);

            var resultado = await _userManager.CreateAsync(usuario, cadastrarUsuarioDto.Password);

            if (resultado.Succeeded is false)
                throw new ApplicationException("Falha ao cadastrar usuário!");
        }
    }
}
