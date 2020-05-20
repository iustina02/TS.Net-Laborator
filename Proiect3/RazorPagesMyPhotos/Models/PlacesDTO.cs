using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RazorPagesMyPhotos.Models
{
    [DataContract(IsReference = true)]
    public partial class PlacesDTO
    {
        public PlacesDTO()
        {
            this.Photos = new HashSet<PhotosDTO>();
            this.Films = new HashSet<FilmsDTO>();
        }

        [DataMember]
        public int Place_Id { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string Region { get; set; }

        [DataMember]
        public virtual ICollection<PhotosDTO> Photos { get; set; }
        [DataMember]
        public virtual ICollection<FilmsDTO> Films { get; set; }
    }
}
