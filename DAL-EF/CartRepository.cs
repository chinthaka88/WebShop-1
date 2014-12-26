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
    public class CartRepository : ICartDataAccesss
    {
        WebShopEntities context = new WebShopEntities();
        public void AddNew(CartDTO ex)
        {
            context.Carts.Add(Map(ex));
            context.SaveChanges();
        }

        public void Update(CartDTO ex)
        {
            context.Entry(Map(ex)).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int cartid)
        {
            Cart sub = context.Carts.Find(cartid);
            context.Carts.Remove(sub);
            context.SaveChanges();
        }

        public IEnumerable<CartDTO> GetCart()
        {
            List<Cart> cats = context.Carts.ToList<Cart>();
            return Map(cats);
        }

        private Cart Map(CartDTO dto)
        {
            Mapper.CreateMap<CartDTO, Cart>();
            return Mapper.Map<Cart>(dto);
        }
        private List<CartDTO> Map(List<Cart> entity)
        {
            List<CartDTO> dtos = new List<CartDTO>();
            foreach (var x in entity)
            {
                Mapper.CreateMap<Cart, CartDTO>();
                CartDTO dto = Mapper.Map<CartDTO>(x);
                dtos.Add(dto);

            }
            return dtos;
        }


        public IEnumerable<CartDTO> GetCartItem()
        {
            List<Cart> cats = context.Carts.ToList<Cart>();
            return Map(cats);
        }
        private Item Map(ItemDTO dto)
        {
            Mapper.CreateMap<ItemDTO, Item>();
            return Mapper.Map<Item>(dto);
        }

        public void AddToCart(ItemDTO ex)
        {
            context.Items.Add(Map(ex));
            context.SaveChanges();
        }

        public void RemoveFromCart(int cartid)
        {
            Cart sub = context.Carts.Find(cartid);
            context.Carts.Remove(sub);
            context.SaveChanges();
        }

        public void EmptyCart()
        {
            throw new NotImplementedException();
        }

        public List<CartDTO> GetCartItems()
        {
            List<Cart> cats = context.Carts.ToList<Cart>();
            return Map(cats);
        }

        public int GetCount(string cartid)
        {
            // Get the count of each item in the cart and sum them up
            int? count = (from cartItems in context.Carts
                          where cartItems.CartId == cartid
                          select (int?)cartItems.Count).Sum();
            // Return 0 if all entries are null
            return count ?? 0;
        }

        public decimal GetTotal(string cartid)
        {
            // Multiply item price by count of that item to get 
            // the current price for each of those items in the cart
            // sum all item price totals to get the cart total
            decimal? total = (from cartItems in context.Carts
                              where cartItems.CartId == cartid
                              select (int?)cartItems.Count *
                              cartItems.Item.Price).Sum();

            return total ?? decimal.Zero;
        }

        public void CreateOrder(OrderDTO order)
        {
            throw new NotImplementedException();
        }

        public string GetCartId(int cartid)
        {
            throw new NotImplementedException();
        }
    }
}
