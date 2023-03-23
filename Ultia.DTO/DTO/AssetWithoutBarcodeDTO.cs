using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultia.DTO.DTO
{
    public class AssetWithoutBarcodeDTO
    {
        public int ID { get; set; }
        public int AssetID { get; set; }
        public int UnitID { get; set; }
        public decimal Quantity { get; set; }
        public bool IsActive { get; set; }

    }
}
