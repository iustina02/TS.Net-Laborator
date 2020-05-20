using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RazorPagesMyPhotos.Models
{
    [DataContract(IsReference = true)]
    public partial class PersonsDTO
    {
        public PersonsDTO()
        {
            this.Photos = new HashSet<PhotosDTO>();
            this.Films = new HashSet<FilmsDTO>();
        }

        [DataMember]
        public int Person_Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }


        [DataMember]
        public virtual ICollection<PhotosDTO> Photos { get; set; }
        [DataMember]
        public virtual ICollection<FilmsDTO> Films { get; set; }
    }
}
