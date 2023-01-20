using Microsoft.EntityFrameworkCore;
using ferreteria_backend.Data;
using ferreteria_backend.Models;
using ferreteria_backend.Repository.IRepository;
using System.Linq.Expressions;

namespace ferreteria_backend.Repository
{
    public class ItemRepository : Repository<Item>, IItemRepository
	{
        private readonly ApplicationDbContext _db;
        public ItemRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Item> UpdateAsync(Item entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.Items.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
