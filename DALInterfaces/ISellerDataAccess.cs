using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DALInterfaces
{
    public interface ISellerDataAccess
    {
        void AddNew(SellerDTO ex);
        void Update(SellerDTO ex);
        void Delete(int sellerid);
        IEnumerable<SellerDTO> GetSeller();
    }
}
