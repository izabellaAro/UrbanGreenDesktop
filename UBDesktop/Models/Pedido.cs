using System;
using System.Collections.Generic;

namespace UBDesktop.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string NomeComprador { get; set; }
        public double ValorTotal { get; set; }
        public List<ReadItemPedidoDto> ItemPedidos { get; set; }
    }

    public class ReadItemPedidoDto
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public int ProdutoId { get; set; }
        public double Valor { get; set; }
        public string NomeProduto { get; set; }
    }
}
