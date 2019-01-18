using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiDriverSystem
{
    interface IRepository<T> where T:class
    {
        IEnumerable<T> SelectAll();
        T SelectByID(object id);
        void insert(T type);
        void update(T obj);
        void delete(object Id);
        void save();
    }
}
