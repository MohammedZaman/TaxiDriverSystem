using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiDriverSystem
{
    class DBCon
    {
        private LinqToSQlDataContext db;

        public LinqToSQlDataContext getDb() => db;

        public void createConnection() {
            try

            {

                String constr = Properties.Settings.Default.dbString;
                db = new LinqToSQlDataContext(constr);
                

            }

            catch (Exception es)

            {

                Console.WriteLine(es.Message);



            }


        }
    }
}
