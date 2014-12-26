using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DALInterfaces
{
    public interface IOrderDataAccess
    {
        void AddNew(OrderDTO ex);
        void Update(OrderDTO ex);
        void Delete(int orderid);
        IEnumerable<OrderDTO> GetOrder();
    }
}
