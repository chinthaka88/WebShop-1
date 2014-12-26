using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ItemDTO
    {
        public int ID { get; set; }
        public int CatagorieId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ItemPictureUrl { get; set; }
        public byte[] InternalImage { get; set; }
    
    }
}
