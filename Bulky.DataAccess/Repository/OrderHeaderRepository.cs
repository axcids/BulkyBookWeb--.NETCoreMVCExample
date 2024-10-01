using BulkyBook.DataAccess.Data;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository {
    public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository {

        private ApplicationDbContext _db;
        public OrderHeaderRepository(ApplicationDbContext db) : base(db) {
            _db = db;
        }
        public void Update(OrderHeader obj) {
            _db.OrderHeaders.Update(obj);
        }
		public void UpdateStatus(int id, string orderStatus, string? PaymentStatus = null) {
			var orderFromDb = _db.OrderHeaders.FirstOrDefault(u=>u.Id == id);
			if (orderFromDb != null) {
				orderFromDb.OrderStatus = orderStatus;
				if (!string.IsNullOrEmpty(PaymentStatus)) {
					orderFromDb.PaymentStatus = PaymentStatus;
				}
			}
			
		}
		public void UpdatePaymentID(int id, string sessionId, string PaymentIntentId) {
			var orderFromDb = _db.OrderHeaders.FirstOrDefault(u => u.Id == id);
			if (!string.IsNullOrEmpty(sessionId)) {
				orderFromDb.SessionId = sessionId;
			}
			if (!string.IsNullOrEmpty(PaymentIntentId)) {
				orderFromDb.PaymentIntentId	= PaymentIntentId;
				orderFromDb.PaymentDate = DateTime.Now;
			}
		}
	}
}
