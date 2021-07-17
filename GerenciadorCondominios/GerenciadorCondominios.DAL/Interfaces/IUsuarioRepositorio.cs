using GerenciadorCondominios.BLL.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace GerenciadorCondominios.DAL.Interfaces
{
    public interface IUsuarioRepositorio : IRepositorioGenerico<Usuario>
    {
        int VerificarSeExisteRegistro();

        Task RealizarLoginUsuario(Usuario usuario, bool lembrarUsuario);

        Task<IdentityResult> CriarUsuario(Usuario usuario, string senha);

        Task IncluirFuncaoAoUsuario(Usuario usuario, string funcao);
    }
}
