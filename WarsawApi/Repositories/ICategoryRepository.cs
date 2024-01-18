using WarsawApi.Dto.Category;
using WarsawApi.Entities;

namespace WarsawApi.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<CategoryEntity> GetCategories();
        CategoryEntity GetCategoryById(int id);
        CategoryEntity CreateCategory(CreateCategoryDto dto);
        CategoryEntity UpdateCategory(UpdateCategoryDto dto);
        void DeleteCategory(int id);
    }
}
