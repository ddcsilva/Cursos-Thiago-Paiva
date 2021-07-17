using GerenciadorCondominios.BLL.Models;
using GerenciadorCondominios.DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorCondominios.DAL.Repositorios
{
    public class UsuarioRepositorio : RepositorioGenerico<Usuario>, IUsuarioRepositorio
    {
        private readonly Contexto contexto;
        private readonly UserManager<Usuario> gerenciadorUsuarios;
        private readonly SignInManager<Usuario> gerenciadorLogin;

        public UsuarioRepositorio(Contexto contexto, UserManager<Usuario> gerenciadorUsuarios, SignInManager<Usuario> gerenciadorLogin) : base(contexto) 
        {
            this.contexto = contexto;
            this.gerenciadorUsuarios = gerenciadorUsuarios;
            this.gerenciadorLogin = gerenciadorLogin;
        }

        public async Task<IdentityResult> CriarUsuario(Usuario usuario, string senha)
        {
            try
            {
                return await gerenciadorUsuarios.CreateAsync(usuario, senha);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task IncluirFuncaoAoUsuario(Usuario usuario, string funcao)
        {
            try
            {
                await gerenciadorUsuarios.AddToRoleAsync(usuario, funcao);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task RealizarLoginUsuario(Usuario usuario, bool lembrarUsuario)
        {
            try
            {
                await gerenciadorLogin.SignInAsync(usuario, lembrarUsuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int VerificarSeExisteRegistro()
        {
            try
            {
                return this.contexto.Usuarios.Count();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
