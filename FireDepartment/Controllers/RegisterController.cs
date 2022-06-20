using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireDepartment.Models;

namespace FireDepartment.Controllers
{
    internal class RegisterController
    {
        public void AddUser(Fireman f)
        {
            using (FireDepartmentEntities fr = new FireDepartmentEntities())
            {
                var lastFireman = fr.Firemans.ToList().LastOrDefault();
                if (lastFireman == null)
                {
                    lastFireman = new Fireman();
                    lastFireman.Id = 0;
                }
                f.Id = lastFireman.Id + 1;
                fr.Firemans.Add(f);
                fr.SaveChanges();
            }
        }
    }
}
