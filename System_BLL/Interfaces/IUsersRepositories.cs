using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_DAL.Models;

namespace System_BLL.Interfaces
{
    public interface IUsersRepositories
    {
        IEnumerable<Contacts> GetAll();
        Contacts GetById(int id);
        int Add(Contacts contact);
        int Update(Contacts contact);
        int Delete(int id);
    }
}
