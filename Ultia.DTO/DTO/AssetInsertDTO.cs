using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultia.DTO.DTO
{
    public class AssetInsertDTO
    {
        public AssetDTO Asset { get; set; }
        public AssetTypeDTO AssetType { get; set; }
        public BrandModelDTO Brand { get; set; }
        public AssetOwnerDTO AssetOwner { get; set; }
        public CurrencyDTO Currency { get; set; }
    }
}
