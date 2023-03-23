using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultia.DTO.DTO
{
    public class BrandModelDTO
    {
        public int ID { get; set; }
        public int? MasterID { get; set; }
        public bool? IsBrand { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }
        public bool IsActive { get; set; }

    }
}
