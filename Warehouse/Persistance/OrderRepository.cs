using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Contracts;
using Warehouse.Models;

namespace Warehouse.Persistance
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private readonly KioskDbContext _kioskDbContext;
        public OrderRepository(KioskDbContext context)
        : base(context)
        {
            _kioskDbContext = context;
        }

        public IEnumerable<Order> GetOrdersByCustomer(int customerId)
        {
            return _kioskDbContext.Orders
                .Where(o => o.CustomerId == customerId)
                .ToList();
        }

        public IEnumerable<Order> GetAllOrdersSummary()
        {
            return _kioskDbContext.Orders
                .Select(o => new Order
                {
                    Id = o.Id,
                    OrderDate = o.OrderDate,
                    TotalAmount = o.TotalAmount,
                    Status = o.Status
                })
                .ToList();
        }

        public IEnumerable<Order> GetDraftOrders()
        {
            return _kioskDbContext.Orders
                .Where(o => o.Status == OrderStatus.Draft)
                .ToList();
        }

        public decimal GetHighestOrderAmount()
        {
            return _kioskDbContext.Orders
                .Max(o => o.TotalAmount);
        }

        public IEnumerable<Order> GetAllOrdersWithDetails()
        {
            return _kioskDbContext.Orders
                .Include(o => o.OrderItems)
                .ThenInclude(o => o.Product)
                .Select(o => new Order
                {
                    Id = o.Id,
                    OrderDate = o.OrderDate,
                    TotalAmount = o.TotalAmount,
                    Status = o.Status,
                    OrderItems = o.OrderItems.Select(oi => new OrderItem
                    {
                        Id = oi.Id,
                        OrderId = oi.OrderId,
                        ProductId = oi.ProductId,
                        Quantity = oi.Quantity,
                        UnitPrice = oi.UnitPrice,
                        Product = new Product
                        {
                            Name = oi.Product.Name,
                            Price = oi.Product.UnitPrice
                        }
                    }).ToList()
                })
                .ToList();
        }

        public void ChangeOrderStatusToCompleted(int orderId)
        {
            var order = _kioskDbContext.Orders.FirstOrDefault(o => o.Id == orderId);
            if (order != null && order.Status == OrderStatus.Submitted)
            {
                order.Status = OrderStatus.Completed;
                _kioskDbContext.SaveChanges();
            }
        }

        public void DeleteOrderById(int orderId)
        {
            var order = _kioskDbContext.Orders.FirstOrDefault(o => o.Id == orderId);
            if (order != null)
            {
                _kioskDbContext.Orders.Remove(order);
                _kioskDbContext.SaveChanges();
            }
        }

    }
}
