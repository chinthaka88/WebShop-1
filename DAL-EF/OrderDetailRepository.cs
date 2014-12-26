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
    public class OrderDetailRepository : IOrderDetailDataAccess
    {
        WebShopEntities context = new WebShopEntities();
        public void AddNew(OrderDetailDTO ex)
        {
            context.OrderDetails.Add(Map(ex));
            context.SaveChanges();
        }

        public void Update(OrderDetailDTO ex)
        {
            context.Entry(Map(ex)).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int orderdetailid)
        {
            OrderDetail sub = context.OrderDetails.Find(orderdetailid);
            context.OrderDetails.Remove(sub);
            context.SaveChanges();
        }

        public IEnumerable<OrderDetailDTO> GetOrderDetail()
        {
            List<OrderDetail> ordedetail = context.OrderDetails.ToList<OrderDetail>();
            return Map(ordedetail);
        }

        private OrderDetail Map(OrderDetailDTO dto)
        {
            Mapper.CreateMap<OrderDetailDTO, OrderDetail>();
            return Mapper.Map<OrderDetail>(dto);
        }
        private List<OrderDetailDTO> Map(List<OrderDetail> entity)
        {
            List<OrderDetailDTO> dtos = new List<OrderDetailDTO>();
            foreach (var x in entity)
            {
                Mapper.CreateMap<OrderDetail, OrderDetailDTO>();
                OrderDetailDTO dto = Mapper.Map<OrderDetailDTO>(x);
                dtos.Add(dto);

            }
            return dtos;
        }
    }
}
