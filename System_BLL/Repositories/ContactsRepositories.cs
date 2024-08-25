using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_BLL.Interfaces;
using System_DAL.Contexts;
using System_DAL.Models;

namespace System_BLL.Repositories
{
    public class ContactsRepositories : IContactsRepositories
    {
        private readonly SystemDbContext _dbContext;

        public ContactsRepositories(SystemDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Add(Contacts contact)
        {
            _dbContext.Contacts.Add(contact);
            return _dbContext.SaveChanges();
        }

        public int Delete(int id)
        {
            var contact = _dbContext.Contacts.Find(id);
            if (contact != null)
            {
                _dbContext.Contacts.Remove(contact);
                return _dbContext.SaveChanges();
            }
            return 0; // No record found with the given ID
        }

        public IEnumerable<Contacts> GetAll()
        {
            return _dbContext.Contacts.ToList();
        }

        public Contacts GetById(int id)
        {
            return _dbContext.Contacts.Find(id);
        }

        public int Update( Contacts contact)
        {
            _dbContext.Update(contact);
            return _dbContext.SaveChanges();
        }
    }
}
