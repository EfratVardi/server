using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Classes
{
    public class Settings
    {
        public int Id { get; set; }

        public string Background { get; set; } = null!;
       
        public string Color { get; set; } = null!;
        
        public string Music { get; set; } = null!;
    }
}
