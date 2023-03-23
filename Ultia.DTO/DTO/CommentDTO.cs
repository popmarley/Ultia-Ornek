using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultia.DTO.DTO
{
    public class CommentDTO
    {
        public int ID { get; set; }
        public int AssetID { get; set; }
        public int PersonnelID { get; set; }
        public string Note { get; set; }
        public DateTime Date { get; set; }
        public bool IsActive { get; set; }


    }
}
