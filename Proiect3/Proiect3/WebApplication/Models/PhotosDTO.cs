using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class PhotosDTO
    {
        public PhotosDTO()
        {
            this.Persons_Photo = new HashSet<PersonsDTO>();
        }

        public int Photo_Id { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Event { get; set; }
        public string Landscape { get; set; }
        public string Path { get; set; }

        public virtual PlacesDTO Places_Photo { get; set; }
        public virtual ICollection<PersonsDTO> Persons_Photo { get; set; }
    }
}
