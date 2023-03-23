using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultia.DTO.DTO
{
    public class CommunicationDTO
    {
        public int ID { get; set; }
        public int PersonnelID { get; set; }
        public int CommunicationTypeID { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

    }
}
