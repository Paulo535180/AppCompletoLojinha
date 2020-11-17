using System.Collections.Generic;

namespace MeuApp.Business.Models
{
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }

        //Relação com o Entity//

        public IEnumerable<Produto> Produtos { get; set; }
    }
}
