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
    public class OrderRepository : IOrderDataAccess
    {
        WebShopEntities context = new WebShopEntities();
        public void AddNew(OrderDTO ex)
        {
            context.Orders.Add(Map(ex));
            context.SaveChanges();
        }

        public void Update(OrderDTO ex)
        {
            context.Entry(Map(ex)).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int orderid)
        {
            Order sub = context.Orders.Find(orderid);
            context.Orders.Remove(sub);
            context.SaveChanges();
        }

        public IEnumerable<OrderDTO> GetOrder()
        {
            List<Order> itms = context.Orders.ToList<Order>();
            return Map(itms);
        }

        private Order Map(OrderDTO dto)
        {
            Mapper.CreateMap<OrderDTO, Order>();
            return Mapper.Map<Order>(dto);
        }
        private List<OrderDTO> Map(List<Order> entity)
        {
            List<OrderDTO> dtos = new List<OrderDTO>();
            foreach (var x in entity)
            {
                Mapper.CreateMap<Order, OrderDTO>();
                OrderDTO dto = Mapper.Map<OrderDTO>(x);
                dtos.Add(dto);

            }
            return dtos;
        }
    }
}
