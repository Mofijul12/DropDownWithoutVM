using Microsoft.AspNetCore.Mvc.Rendering;

namespace DropDownWithoutVM.Models
{
    public class ProductCategoryViewModel
    {
        // The list of categories to populate the dropdown
        public List<SelectListItem> Categories { get; set; }

        // The selected category ID (bound to the dropdown)
        public int SelectedCategoryId { get; set; }

        // Optionally, you can add other fields to this ViewModel, like a product name
        public string SelectedCategoryName { get; set; }
    }

}
