using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BusinessLogicLayer {
    public class RepositoryEmployee {
        public List<Employee> GetEmployees() {
            using (FloraSampleDbEntities db = new FloraSampleDbEntities()) {
                return db.Employees.ToList();
            }
        }

        public void Add(Employee emp) {
            using (FloraSampleDbEntities db = new FloraSampleDbEntities()) {
                db.Employees.Add(emp);
                db.SaveChanges();
            }
        }

        public void Edit(Employee emp) {
            using (FloraSampleDbEntities db = new FloraSampleDbEntities()) {
                db.Entry(emp).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Delete(Employee emp) {
            using (FloraSampleDbEntities db = new FloraSampleDbEntities()) {
                db.Entry(emp).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}
