using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class PersonsDTO
    {
        public PersonsDTO()
        {
            this.Photos = new HashSet<PhotosDTO>();
            this.Films = new HashSet<FilmsDTO>();
        }

        public int Person_Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<PhotosDTO> Photos { get; set; }
        public virtual ICollection<FilmsDTO> Films { get; set; }
    }
}
