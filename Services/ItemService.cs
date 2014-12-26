using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceInterfaces;
using DALInterfaces;
using DTO;

namespace Services
{
    public class ItemService : IItemService
    {
        private IItemDataAccess repository;

        public ItemService(IItemDataAccess repository)
        {
            this.repository = repository;
        }

        public bool AddNewItem(ItemDTO ex)
        {
            if (this.Validate(ex))
            {
                repository.AddNew(ex);
                return true;
            }
            return false;
        }

        public bool UpdateItem(ItemDTO ex)
        {
            if (this.Validate(ex))
            {
                repository.AddNew(ex);
                return true;
            }
            return false;
        }

        public bool DeleteItem(int itemid)
        {
            repository.Delete(itemid);
            return true;
        }

        public IEnumerable<ItemDTO> GetItems()
        {
            return repository.GetItem();
        }

        public bool Validate(ItemDTO Item)
        {
            throw new NotImplementedException();
        }
    }
}
