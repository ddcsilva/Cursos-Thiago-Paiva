using Microsoft.AspNetCore.Identity;

namespace GerenciadorCondominios.BLL.Models
{
    // Classe com as Funções dos Usuários no Sistema. No IdentityRole informa o tipo da FK
    public class Funcao : IdentityRole<string>
    {
    }
}
