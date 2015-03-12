using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer {
     public partial class FloraSampleDbEntities : DbContext
    {
        public FloraSampleDbEntities()
            : base("name=FloraSampleDbEntities")
        {
        
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }


        public virtual DbSet<Employee> Employees { get; set; }
    }
}
