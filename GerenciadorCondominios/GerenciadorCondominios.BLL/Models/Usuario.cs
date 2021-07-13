using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorCondominios.BLL.Models
{
    // Classe com os Usuários do Sistema. No IdentityUser informa o tipo da PK
    public class Usuario : IdentityUser<string>
    {
        public string CPF { get; set; }

        // Iremos gravar somente a URL do diretório da Foto
        public string Foto { get; set; }

        // No primeiro acesso ao sistema, deverá redefinir a senha
        public bool PrimeiroAcesso { get; set; }

        public StatusConta Status { get; set; }

        public virtual ICollection<Apartamento> MoradoresApartamento { get; set; }
        public virtual ICollection<Apartamento> ProprietariosApartamento { get; set; }
        public virtual ICollection<Veiculo> Veiculos { get; set; }
        public virtual ICollection<Evento> Eventos { get; set; }
        public virtual ICollection<Servico> Servicos { get; set; }
        public virtual ICollection<Pagamento> Pagamentos { get; set; }
    }
}
