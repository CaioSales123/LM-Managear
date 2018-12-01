
namespace LM.Code
{
    public class DTO
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string produto;
        public string Produto
        {
            get { return produto; }
            set { produto = value; }
        }

        private string categoria;
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        private string quantidade;
        public string Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
    }
}