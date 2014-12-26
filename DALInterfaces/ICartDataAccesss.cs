using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DALInterfaces
{
    public interface ICartDataAccesss
    {
        void AddNew(CartDTO ex);
        void Update(CartDTO ex);
        void Delete(int cartid);
        IEnumerable<CartDTO> GetCart();


        IEnumerable<CartDTO> GetCartItem();
        void AddToCart(ItemDTO ex);
        void RemoveFromCart(int cartid);
        void EmptyCart();
        List<CartDTO> GetCartItems();
        int GetCount(string cartid);
        decimal GetTotal(string cartid);
        void CreateOrder(OrderDTO order);
        string GetCartId(int cartid);
    }
}
