using SharedResource.DTOs;

namespace CategoryServices.Repository
{
    public interface ICategoryRepo
    {
        Task<bool> Save(CategoryDTOs request);
    }
}
