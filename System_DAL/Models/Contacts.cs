using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_DAL.Models
{
    public class Contacts
    {
        [Key]
        public int ContactId { get; set; }  // Renamed from Contact to ContactId for clarity
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        public DateTime CreateDate { get; set; }

        public int UserId { get; set; }
    }
}
