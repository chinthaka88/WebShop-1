using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace ServiceInterfaces
{
    public interface IShoppingCartService
    {
        bool AddNewCart(CartDTO ex);
        bool UpdateCart(CartDTO ex);
        bool DeleteCart(int cartid);
        IEnumerable<CartDTO> GetCart();
        bool Validate(CartDTO Cart);

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
