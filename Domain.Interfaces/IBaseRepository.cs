using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IBaseRepository<T>
    {
        List<T> GetAll();
        T Create(T item);
        T Edit(T item);
    }
}
