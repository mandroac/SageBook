namespace SageBookWebApi.Requests
{
    public class SageRequest
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public IFormFile Photo { get; set; }
        public string City { get; set; }
        public ICollection<Guid> BookIds { get; set; } = new HashSet<Guid>();
    }
}
