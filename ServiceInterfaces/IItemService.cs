using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace ServiceInterfaces
{
    public interface IItemService
    {
        bool AddNewItem(ItemDTO ex);
        bool UpdateItem(ItemDTO ex);
        bool DeleteItem(int itemid);
        IEnumerable<ItemDTO> GetItems();
        bool Validate(ItemDTO Item);
    }
}
