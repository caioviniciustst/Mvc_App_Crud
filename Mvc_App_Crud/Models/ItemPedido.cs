namespace Mvc_App_Crud.Models
{
    public class ItemPedido
    {
        public int ItemPedidoId { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }

        // Chave estrangeira para Pedido
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }

        // Chave estrangeira para Produto
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
    }
}
