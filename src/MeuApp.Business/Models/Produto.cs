﻿using System;

namespace MeuApp.Business.Models
{
    public class Produto : Entity
    {
        public Guid FornecedorId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        //Relação com o Entity//

        public Fornecedor Fornecedor { get; set; }
    }
}
