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
    public class ShoppingCartService : IShoppingCartService
    {
        private ICartDataAccesss repository;

        public ShoppingCartService(ICartDataAccesss repository)
        {
            this.repository = repository;
        }
        public bool AddNewCart(CartDTO ex)
        {
            if (this.Validate(ex))
            {
                repository.AddNew(ex);
                return true;
            }
            return false;
        }

        public bool UpdateCart(CartDTO ex)
        {
            if (this.Validate(ex))
            {
                repository.AddNew(ex);
                return true;
            }
            return false;
        }

        public bool DeleteCart(int cartid)
        {
            repository.Delete(cartid);
            return true;
        }

        public IEnumerable<CartDTO> GetCart()
        {
            return repository.GetCart();
        }

        public bool Validate(CartDTO Cart)
        {
            throw new NotImplementedException();
        }




        public IEnumerable<CartDTO> GetCartItem()
        {
            return repository.GetCartItem();
        }

        public void AddToCart(ItemDTO ex)
        {
            repository.AddToCart(ex);
        }

        public void RemoveFromCart(int cartid)
        {
            repository.RemoveFromCart(cartid);
        }

        public void EmptyCart()
        {
            throw new NotImplementedException();
        }

        public List<CartDTO> GetCartItems()
        {
            throw new NotImplementedException();
        }

        public int GetCount(string cartid)
        {
            return repository.GetCount(cartid);
        }

        public decimal GetTotal(string cartid)
        {
            return repository.GetTotal(cartid);
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
