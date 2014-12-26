using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALInterfaces;
using System.Data.Entity;
using DTO;
using AutoMapper;

namespace DAL_EF
{
    public class ItemRepository : IItemDataAccess
    {
        WebShopEntities context = new WebShopEntities();
        public void AddNew(ItemDTO ex)
        {
            context.Items.Add(Map(ex));
            context.SaveChanges();
        }

        public void Update(ItemDTO ex)
        {
            context.Entry(Map(ex)).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int itemid)
        {
            Item sub = context.Items.Find(itemid);
            context.Items.Remove(sub);
            context.SaveChanges();
        }

        public IEnumerable<ItemDTO> GetItem()
        {
            List<Item> itms = context.Items.ToList<Item>();
            return Map(itms);
        }

        private Item Map(ItemDTO dto)
        {
            Mapper.CreateMap<ItemDTO, Item>();
            return Mapper.Map<Item>(dto);
        }
        private List<ItemDTO> Map(List<Item> entity)
        {
            List<ItemDTO> dtos = new List<ItemDTO>();
            foreach (var x in entity)
            {
                Mapper.CreateMap<Item, ItemDTO>();
                ItemDTO dto = Mapper.Map<ItemDTO>(x);
                dtos.Add(dto);

            }
            return dtos;
        }
    }
}
