using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal interface IUpdateEnty<T>
    {
        T Update(T entity);
    }
}
