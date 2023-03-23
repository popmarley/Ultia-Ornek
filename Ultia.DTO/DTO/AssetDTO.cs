using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultia.DTO.DTO
{
    public class AssetDTO
    {
        public int ID { get; set; }
        public bool hasBarcode { get; set; }
        public Guid? RegistrationNumber { get; set; }
        public int CompanyID { get; set; }
        public int AssetGroupID { get; set; }
        public int AssetTypeID { get; set; }
        public int CurrencyID { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public bool? Guarantee { get; set; }
        public bool IsActive { get; set; }
    }
}
