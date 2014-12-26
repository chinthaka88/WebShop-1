using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL_EF;
using DTO;
using System.ComponentModel.DataAnnotations;

namespace EShop.ViewModels
{
    public class OrderDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime? OrderDate { get; set; }

        public int OrderCount { get; set; }
    }
}