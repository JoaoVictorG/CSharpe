using System;

namespace DatasEmObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            var pedido = new Pedido
            {
                PedidoId = 1,
                DtPedido = DateTime.Today,
                DtPagto = DateTime.Today.AddDays(45),
                Valor = 1500
            };
            Console.WriteLine($"Pedido : {pedido.PedidoId} - " + $"Data: {pedido.DtPedido:dd/MMM/yyyy} - " + $"Vencimento: {pedido.DtVencimento(): dd/MMM/yyyy}");

            
        }
    }
}
