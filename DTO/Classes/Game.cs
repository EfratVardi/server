using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Classes
{
    public class Game
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int TypeGameId { get; set; }
        
        public int DetailsId { get; set; }
       
        public DateTime StartDate { get; set; }
       
        public DateTime EndtDate { get; set; }
        
        public int SettingsId { get; set; }
        
        public int AudienceId{ get; set; }

    }
}
