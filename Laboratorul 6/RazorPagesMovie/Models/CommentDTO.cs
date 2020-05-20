using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    using System.Runtime.Serialization;

    [DataContract(IsReference = true)]
    public partial class CommentDTO
    {
        [DataMember]
        public int CommentId { get; set; }
        [DataMember]
        public string Text { get; set; }
        [DataMember]
        public int PostPostId { get; set; }

        [DataMember]
        public virtual PostDTO Posts { get; set; }
    }
}
