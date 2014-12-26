using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DALInterfaces
{
    public interface IOrderDetailDataAccess
    {
        void AddNew(OrderDetailDTO ex);
        void Update(OrderDetailDTO ex);
        void Delete(int orderdetailid);
        IEnumerable<OrderDetailDTO> GetOrderDetail();
    }
}
