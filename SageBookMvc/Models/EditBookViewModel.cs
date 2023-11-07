using Domain.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SageBookMvc.Models
{
    public class EditBookViewModel
    {
        public Book Book { get; set; } = new Book();
        public List<SelectListItem> SagesSelectedList { get; set; }
        public List<Guid> SelectedSageIds { get; set; } = new List<Guid>();
    }
}
