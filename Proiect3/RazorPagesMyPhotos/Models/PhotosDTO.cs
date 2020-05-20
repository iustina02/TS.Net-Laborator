using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RazorPagesMyPhotos.Models
{
    [DataContract(IsReference = true)]
    public partial class PhotosDTO
    {
        public PhotosDTO()
        {
            this.Persons_Photo = new HashSet<PersonsDTO>();
        }

        [DataMember]
        public int Photo_Id { get; set; }
        [DataMember]
        public Nullable<System.DateTime> Date { get; set; }
        [DataMember]
        public string Event { get; set; }
        [DataMember]
        public string Landscape { get; set; }
        [DataMember]
        public string Path { get; set; }

        [DataMember]
        public virtual PlacesDTO Places_Photo { get; set; }
        [DataMember]
        public virtual ICollection<PersonsDTO> Persons_Photo { get; set; }
    }
}
