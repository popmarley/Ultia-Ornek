using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultia.DTO.DTO
{
    public class AssetBarcodeDTO
    {
        public int ID { get; set; }
        public int AssetID { get; set; }
        public string Barcode { get; set; }
        public bool IsActive { get; set; }
    }
}
