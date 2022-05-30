using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireDepartment.Models;

namespace FireDepartment.Controllers
{
    public class FireDepartmentController
    {
        public List<Fireman> GetAll()
        {
            using (FireDepartmentEntities ex = new FireDepartmentEntities())
            {
                return ex.Firemans.ToList();
            }
        }
        public void CreateFireman(Fireman f)
        {
            using (FireDepartmentEntities db = new FireDepartmentEntities())
            {
                var lastFireman = db.Firemans.ToList().LastOrDefault();
                if (lastFireman == null)
                {
                    lastFireman = new Fireman();
                    lastFireman.Id = 0;
                }

                f.Id = lastFireman.Id + 1;
                db.Firemans.Add(f);
                db.SaveChanges();
            }
        }

        public static void DeleteFireman(int id)
        {
            using (FireDepartmentEntities ex = new FireDepartmentEntities())
            {
                var firemanDelete = ex.Firemans.Where(f => f.Id == id).FirstOrDefault();
                if (firemanDelete != null)
                {
                    ex.Firemans.Remove(firemanDelete);
                    ex.SaveChanges();
                }
            }
        }

        public static void UpdateFireman(int id, Fireman f)
        {
            using (FireDepartmentEntities ex = new FireDepartmentEntities())
            {
                var firemanUpdate = ex.Firemans.Where(p => p.Id == id).FirstOrDefault();
                if (firemanUpdate != null)
                {
                    firemanUpdate.Id = f.Id;
                    firemanUpdate.Name = f.Name;
                    firemanUpdate.Username = f.Username;
                    firemanUpdate.Password = f.Password;
                    firemanUpdate.TruckId = f.TruckId;
                    ex.SaveChanges();
                }
            }
        }
    }
}
