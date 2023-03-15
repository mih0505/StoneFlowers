using Domain.OrderModels;

namespace Domain.Common
{
    public class User : BaseModel
    {
        /// <summary>
        /// Идентификатор в Identity Server
        /// </summary>
        public Guid IdentityId { get; init; }

        /// <summary>
        /// Имя сотрудника
        /// </summary>
        public PersonName UserName { get; set; }

        public IEnumerable<Order> Orders { get; set; }

        public IEnumerable<Payment> Payments { get; set; }

        public User(IEnumerable<Order> orders, IEnumerable<Payment> money)
        {
            Orders = orders;
            Payments = money;
        }
    }
}
