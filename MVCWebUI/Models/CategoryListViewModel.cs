using Entities.Concrete;

namespace MVCWebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories;

        public int CurrentCategory { get; set; }
    }
}
