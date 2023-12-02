using OrderService.API.Models;
using OrderService.API.Context;
using Microsoft.EntityFrameworkCore;

namespace OrderService.API.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DbContextOptions<ApplicationDbContext> _dbContext;

        public OrderRepository(DbContextOptions<ApplicationDbContext> dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> AddOrder(OrderHeader orderHeader)
        {
            if (orderHeader.CouponCode == null)
            {
                orderHeader.CouponCode = "";
            }
            await using var _db = new ApplicationDbContext(_dbContext);
            _db.OrderHeaders.Add(orderHeader);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task UpdateOrderPaymentStatus(int orderHeaderId, bool paid)
        {
            await using var _db = new ApplicationDbContext(_dbContext);
            var orderHeaderFromDb = await _db.OrderHeaders.FirstOrDefaultAsync(u => u.OrderHeaderId == orderHeaderId);
            if (orderHeaderFromDb != null)
            {
                orderHeaderFromDb.PaymentStatus = paid;
                await _db.SaveChangesAsync();
            }
        }

        public async Task<List<OrderHeader>> GetAllOrders(string userId)
        {
            await using var _db = new ApplicationDbContext(_dbContext);
            return await _db.OrderHeaders
                .Include(u => u.OrderDetails)
                .Where(u => u.UserId == userId)
                .ToListAsync();
        }
    }
}
