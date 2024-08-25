using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System_BLL.Interfaces;
using System_BLL.Repositories;
using System_DAL.Models;

namespace Simple_Contact_Manage_System.Controllers
{
    public class ContactsController : Controller
    {
        private readonly IContactsRepositories _dbcontext;

        public ContactsController(IContactsRepositories dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public IActionResult Index()
        {
            var contacts = _dbcontext.GetAll();
            return View(contacts);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Contacts contact)
        {
           if(ModelState.IsValid)
            {
                contact.CreateDate = DateTime.Now;
                _dbcontext.Add(contact);
                return RedirectToAction(nameof(Index));
            }
           return View(contact);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var contact = _dbcontext.GetById(id);
            if (contact == null)
            {
                return NotFound();
            }
            _dbcontext.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int? id)
        {
            if(id is null)
            {
                return BadRequest();
            }
            var contact = _dbcontext.GetById(id.Value);
            if (contact == null)
                return NotFound();
            return View(contact);
        }
        [HttpPost]
        public IActionResult Edit(Contacts contact, [FromRoute]int id)
        {
            if(id!=contact.ContactId)
                return BadRequest();
            if (ModelState.IsValid)
            {
                _dbcontext.Update(contact);
                return RedirectToAction(nameof(Index));
            }
            return View(contact);
        }
    }
}
