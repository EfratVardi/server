using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Classes
{
    public class UserDetails
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;
       
        public string LastName { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public int CenderId { get; set; }
        
        public int City { get; set; }
       
        public int HowKnownId { get; set; }

    }
}
