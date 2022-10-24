namespace AspNetCoreEmpty.Models
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> Categories { get; }
    }
}
