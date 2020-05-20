using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace RazorPagesMyPhotos.Models
{
  
    [DataContract(IsReference = true)]
    public partial class FilmsDTO
    {
        public FilmsDTO()
        {
            this.Persons = new HashSet<PersonsDTO>();
            this.Places_Photo = new HashSet<PlacesDTO>();
        }

        [DataMember]
        public int Film_Id { get; set; }
        [DataMember]
        public Nullable<System.DateTime> Date { get; set; }
        [DataMember]
        public string Event { get; set; }
        [DataMember]
        public string Landscape { get; set; }
        [DataMember]
        public string Path { get; set; }

        [DataMember]
        public virtual ICollection<PersonsDTO> Persons { get; set; }
        [DataMember]
        public virtual ICollection<PlacesDTO> Places_Photo { get; set; }
    }
}
