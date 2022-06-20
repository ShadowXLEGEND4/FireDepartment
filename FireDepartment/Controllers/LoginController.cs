using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireDepartment.Models;

namespace FireDepartment.Controllers
{
    internal class LoginController
    {
        public string ShowMessage(string username, string password)
        {
            using (FireDepartmentEntities fr = new FireDepartmentEntities())
            {
                var existingFireman = fr.Firemans.Where(s => s.Name == username).FirstOrDefault();
                if (existingFireman != null)
                {
                    if (existingFireman.Password == password)
                    {
                        return null;
                    }
                    else
                    {
                        return "Wrong Password!";
                    }
                }
                else
                {
                    return "No such User!";
                }
            }
        }
    }
}
