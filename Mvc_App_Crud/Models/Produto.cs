namespace Mvc_App_Crud.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        // Relacionamento com ItemPedido
        public ICollection<ItemPedido> ItensPedido { get; set; }
    }
}
