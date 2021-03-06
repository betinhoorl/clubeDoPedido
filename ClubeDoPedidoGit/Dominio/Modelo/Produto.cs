﻿using System;

namespace Dominio.Modelo
{
    public class Produto
    {
        // Propriedades
        public int ProdutoID { get; set; }
        public string DescricaoReduzida { get; set; }
        public string DescricaoDetalhada { get; set; }
        public decimal ValorUnitario { get; set; }
        public byte[] Imagem { get; set; }
        public int ParceiroID { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }

        // Relacionamentos
        public virtual Parceiro Parceiro { get; set; }

        // Construtor
        public Produto() {}
    }
}
