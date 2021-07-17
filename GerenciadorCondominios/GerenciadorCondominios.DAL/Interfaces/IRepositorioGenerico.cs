using System.Collections.Generic;
using System.Threading.Tasks;

namespace GerenciadorCondominios.DAL.Interfaces
{
    public interface IRepositorioGenerico<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> ListarTodosRegistros();

        Task<TEntity> ConsultarPorId(int id);

        Task<TEntity> ConsultarPorId(string id);

        Task Inserir(TEntity entity);

        Task Atualizar(TEntity entity);

        Task Excluir(TEntity entity);

        Task Excluir(int id);

        Task Excluir(string id);
    }
}
