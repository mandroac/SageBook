using Domain.Models;

namespace SageBookMvc.Models
{
    public class UserChatViewModel
    {
        public AppUser FirstUser { get; set; }
        public AppUser SecondUser { get; set; }
        public ICollection<UserMessage> Messages { get; set; }
    }
}
