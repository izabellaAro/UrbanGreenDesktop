﻿namespace UBDesktop.Models
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; } = new Produto();
        public int Quantidade { get; set; }
        public int? PedidoId { get; set; }
    }
}
