using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL_EF;
using DTO;
using System.ComponentModel.DataAnnotations;


namespace EShop.ViewModels
{
    public class ShoppingCartViewModel
    {
        [Key]
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }

        //////////
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public int AvailableItem { get; set; }
    }
}