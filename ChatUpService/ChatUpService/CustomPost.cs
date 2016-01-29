using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ChatUpService
{
    [DataContract]
    [KnownType(typeof(CustomChatRoom))]
    public class CustomPost
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]

        public string Submitter { get; set; }
        [DataMember]

        public string Comment { get; set; }
        [DataMember]

        public DateTime? TimeSubmitted { get; set; }
        [DataMember]

        public int ChatRoomId { get; set; }
        //[DataMember]

        //public CustomChatRoom ChatRoom { get; set; }
    }
}