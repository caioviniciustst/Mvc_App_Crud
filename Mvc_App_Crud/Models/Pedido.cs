namespace Mvc_App_Crud.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public DateTime DataPedido { get; set; }
        public string Cliente { get; set; }

        // Relacionamento com ItemPedido
        public ICollection<ItemPedido> ItensPedido { get; set; }
    }
}
