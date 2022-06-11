using PriceProject.DAL.Models;

namespace PriceProject.DAL.Repositories.Interfaces
{
    public interface IShopRepository
    {
        Shop Create(Shop shop);
        void Update(Shop shop);
        void Delete(int id);
        Shop Get(int id);
        List<Shop> GetShops();
    }
}
