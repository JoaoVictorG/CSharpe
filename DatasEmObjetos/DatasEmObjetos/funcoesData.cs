using System;
using System.Collections.Generic;
using System.Text;

namespace DatasEmObjetos
{
    class funcoesData
    {
    }
    public class Pedido
    {
        public int PedidoId { get; set; }
        public DateTime DtPedido { get; set; }
        public DateTime DtVencimento() => DtPedido.AddDays(30);
        public DateTime DtPagto { get; set; }
        public TimeSpan DiasAtraso => DtPagto.Subtract(DtVencimento());
        public decimal Valor { get; set; }
        public decimal Multa => Valor * 0.10M;
    }
}
