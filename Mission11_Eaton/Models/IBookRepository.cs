namespace Mission11_Eaton.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
