using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultia.DTO.DTO
{
    public class ActionStatusDTO
    {
        public int ID { get; set; }
        public int AssetActionID { get; set; }
        public int StatusID { get; set; }
        public bool IsActive { get; set; }
    }
}
