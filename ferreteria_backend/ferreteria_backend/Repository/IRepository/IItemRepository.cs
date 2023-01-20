using Microsoft.EntityFrameworkCore.ChangeTracking;
using ferreteria_backend.Models;
using System.Linq.Expressions;

namespace ferreteria_backend.Repository.IRepository
{
    public interface IItemRepository : IRepository <Item>
    {   
        
        Task <Item> UpdateAsync(Item entity);
    }
}
