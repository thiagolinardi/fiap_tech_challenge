using FIAP.TechChallenge.Application.ViewModels;

namespace FIAP.TechChallenge.Application.Interfaces
{
    public interface IProductServiceApp
    {
        Task SaveProduct(ProductViewModel viewModel, bool update = false);
        Task RemoveProduct(string id);
    }
}
