using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class FilmsDTO
    {
        public FilmsDTO()
        {
            this.Persons = new HashSet<PersonsDTO>();
            this.Places_Photo = new HashSet<PlacesDTO>();
        }

        public int Film_Id { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Event { get; set; }
        public string Landscape { get; set; }
        public string Path { get; set; }

        public virtual ICollection<PersonsDTO> Persons { get; set; }
        public virtual ICollection<PlacesDTO> Places_Photo { get; set; }
    }
}
