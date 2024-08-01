
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Models
{
    public enum OrderStatus
    {
        Draft,
        Submitted,
        Completed,
    }
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public List<Order> OrderItems { get; set; }
        public OrderStatus Status { get; set; }
        public decimal TotalAmount { get; set; }

    }
}
