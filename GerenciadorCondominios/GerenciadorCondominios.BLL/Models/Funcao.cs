using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorCondominios.BLL.Models
{
    // Classe com as Funções dos Usuários no Sistema. No IdentityRole informa o tipo da FK
    public class Funcao : IdentityRole<string>
    {
    }
}
