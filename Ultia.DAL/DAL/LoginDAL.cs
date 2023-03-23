using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ultia.DTO.DTO;
using Ultia.MyProvider.Repositories;
using Ultia.MyProvider;

namespace Ultia.DAL.DAL
{
    public class LoginDAL : ISelect<LoginDTO>
    {

        public MSSQLProvider provider = null;

        public void Select(LoginDTO login)
        {

            provider = new MSSQLProvider("Select * from Login where UserName='" + login.UserName + "'And Password='" + login.Password + "'");


        }
    }
}
