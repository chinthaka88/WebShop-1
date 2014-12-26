using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DALInterfaces
{
    public interface ICatagoryDataAccess
    {
        void AddNew(CatagoryDTO ex);
        void Update(CatagoryDTO ex);
        void Delete(int catagoryid);
        IEnumerable<CatagoryDTO> GetCatagory();
    }
}
