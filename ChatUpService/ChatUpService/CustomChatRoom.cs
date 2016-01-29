using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ChatUpService
{
    [DataContract]
    [KnownType(typeof(CustomPost))]
    public class CustomChatRoom
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int RoomType { get; set; }
        [DataMember]
        public ICollection<Post> Post { get; set; }
    }
}