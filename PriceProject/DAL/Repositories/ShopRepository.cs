using Dapper;
using PriceProject.DAL.Models;
using PriceProject.DAL.Repositories.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace PriceProject.DAL.Repositories
{
    public class ShopRepository : IShopRepository
    {
        private readonly string _connectionString;

        public ShopRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Shop Create(Shop shop)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var sqlQuery = "INSERT INTO SHOPS (NAME, COORDINATES, DESCRIPTION) VALUES(@NAME, @Coordinates, @Description); SELECT CAST(SCOPE_IDENTITY() as int)";
                int? userId = db.Query<int>(sqlQuery, shop).FirstOrDefault();
                shop.ID = userId.Value;
                return shop;
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var sqlQuery = "DELETE FROM SHOPS WHERE ID = @id";
                db.Execute(sqlQuery, new { id });
            }
        }

        public Shop Get(int id)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Query<Shop>("SELECT * FROM SHOPS WHERE ID = @id", new { id }).FirstOrDefault();
            }
        }

        public List<Shop> GetShops()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Query<Shop>("SELECT * FROM SHOPS").ToList();
            }
        }

        public void Update(Shop shop)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var sqlQuery = "UPDATE Users SET NAME = @NAME, COORDINATES = @Coordinates, DESCRIPTION = @Description";
                db.Execute(sqlQuery, shop);
            }
        }
    }
}
