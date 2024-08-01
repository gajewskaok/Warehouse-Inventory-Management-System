using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models;

namespace Warehouse.Contracts
{
    public interface IOrderRepository : IRepository<Order>
    {
        IEnumerable<Order> GetOrdersByCustomer(int customerId);
        IEnumerable<Order> GetAllOrdersSummary();
        IEnumerable<Order> GetDraftOrders();
        decimal GetHighestOrderAmount();
        IEnumerable<Order> GetAllOrdersWithDetails();
        void ChangeOrderStatusToCompleted(int orderId);
        void DeleteOrderById(int orderId);
    }
}
