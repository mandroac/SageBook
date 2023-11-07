using Domain.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SageBookMvc.Models
{
    public class EditSageViewModel
    {
        public Sage Sage { get; set; }
        public List<SelectListItem> BooksSelectedList { get; set; }
        public List<Guid> SelectedBookIds { get; set; } = new List<Guid>();
        public IFormFile Photo { get; set; }
    }
}
