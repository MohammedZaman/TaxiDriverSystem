using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TaxiDriverSystem
{
     public class GenericRepository<T> : IRepository<T> where T: class  // T can only be class, interface, delegate, or array type
    {

        private LinqToSQlDataContext db;
       

        public GenericRepository()
        {
            DBCon Dbcon = new DBCon();
            String constr = Properties.Settings.Default.dbString;
            db = new LinqToSQlDataContext(constr);


        }
        

        public void delete(T type)
        {
            db.GetTable<T>().DeleteOnSubmit(type);
        }

        public void insert(T type)
        {
            db.GetTable<T>().InsertOnSubmit(type);
        }

        public void save()
        {
            db.SubmitChanges();
        }

        public IEnumerable<T> SelectAll()
        {
            throw new NotImplementedException();
        }

        public T SelectByID(object id)
        {
            throw new NotImplementedException();
        }

        public void update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
