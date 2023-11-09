namespace SageBookWebApi.Requests
{
    public class BookRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Guid> SageIds { get; set; } = new HashSet<Guid>();
    }
}
