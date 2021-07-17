using GerenciadorCondominios.DAL.Interfaces;
using GerenciadorCondominios.DAL.Repositorios;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorCondominios.DAL
{
    public static class ConfiguracaoRepositorioExtension
    {
        public static void ConfigurarRepositorios(this IServiceCollection services)
        {
            services.AddTransient<IUsuarioRepositorio, UsuarioRepositorio>();
        }
    }
}
