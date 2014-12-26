using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DALInterfaces
{
    public interface IItemDataAccess
    {
        void AddNew(ItemDTO ex);
        void Update(ItemDTO ex);
        void Delete(int itemid);
        IEnumerable<ItemDTO> GetItem();
    }
}
