using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Classes
{
    public class TypeGame
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;
       
        public string Description { get; set; } = null!;
      
        public string Picture { get; set; } = null!;

        public int Price { get; set; }

    }
}
