using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class PlacesDTO
    {
        public PlacesDTO()
        {
            this.Photos = new HashSet<PhotosDTO>();
            this.Films = new HashSet<FilmsDTO>();
        }

        public int Place_Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Region { get; set; }

        public virtual ICollection<PhotosDTO> Photos { get; set; }
        public virtual ICollection<FilmsDTO> Films { get; set; }
    }
}
