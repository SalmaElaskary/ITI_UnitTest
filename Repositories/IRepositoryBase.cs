using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    interface IRepositoryBase<T>
    {
        T Add(T data);
        List<T> GetALL();
        bool Delete(int id);
        T Edit(T data);
        T Getbyid(int id);
    }
}
