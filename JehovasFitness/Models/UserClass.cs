using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JehovasFitness.Models
{
    public class UserClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }
        public DateTime RegDate { get; set; }
        public int CoachID { get; set; }
        public int ID { get; set; }
    }
}
