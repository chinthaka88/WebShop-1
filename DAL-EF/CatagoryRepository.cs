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
    public class CatagoryRepository : ICatagoryDataAccess
    {
        WebShopEntities context = new WebShopEntities();
        public void AddNew(CatagoryDTO ex)
        {
            context.Catagories.Add(Map(ex));
            context.SaveChanges();
        }

        public void Update(CatagoryDTO ex)
        {
            context.Entry(Map(ex)).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int catagoryid)
        {
            Catagory sub = context.Catagories.Find(catagoryid);
            context.Catagories.Remove(sub);
            context.SaveChanges();
        }

        public IEnumerable<CatagoryDTO> GetCatagory()
        {
            List<Catagory> itms = context.Catagories.ToList<Catagory>();
            return Map(itms);
        }
        private Catagory Map(CatagoryDTO dto)
        {
            Mapper.CreateMap<CatagoryDTO, Catagory>();
            return Mapper.Map<Catagory>(dto);
        }
        private List<CatagoryDTO> Map(List<Catagory> entity)
        {
            List<CatagoryDTO> dtos = new List<CatagoryDTO>();
            foreach (var x in entity)
            {
                Mapper.CreateMap<Catagory, CatagoryDTO>();
                CatagoryDTO dto = Mapper.Map<CatagoryDTO>(x);
                dtos.Add(dto);

            }
            return dtos;
        }
    }
}
