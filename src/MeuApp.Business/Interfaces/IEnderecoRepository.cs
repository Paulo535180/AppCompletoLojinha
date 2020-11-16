using MeuApp.Business.Models;
using System;
using System.Threading.Tasks;

namespace MeuApp.Business.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}
