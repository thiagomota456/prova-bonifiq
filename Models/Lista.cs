namespace ProvaPub.Models
{
    public abstract class Lista<T> where T : class
    {
        public List<T>? Elementos { get; set; }
        public int TotalCount { get; set; }
        public bool HasNext { get; set; }
    }
}
