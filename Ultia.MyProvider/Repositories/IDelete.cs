using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultia.MyProvider.Repositories
{
    public interface IDelete<T> where T : class
    {
        void Delete(T state);
    }
}
