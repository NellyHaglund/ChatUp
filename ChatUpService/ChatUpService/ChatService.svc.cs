using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ChatUpService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.


    public class ChatService : IChatService
    {
        public void SubmitPost(CustomPost post)
        {
            using (var context = new ChatUp_DBEntities())
            { 
                var postis = new Post()
                {
                    Submitter = post.Submitter,
                    ChatRoomId = post.ChatRoomId,
                    Comment = post.Comment,
                    TimeSubmitted = post.TimeSubmitted

                };
                context.Post.Add(postis);
                context.SaveChanges();
            }
        }

        public ICollection<CustomPost> GetPosts(int chatRoomId)
        {
            List<CustomPost> posts;
            using (var context = new ChatUp_DBEntities())
            {
                posts= context.Post.Where(x => x.ChatRoom.Id == chatRoomId).Select(y=>new CustomPost()
                {
                    ChatRoomId = y.ChatRoomId,
                    Id = y.Id,
                    Comment = y.Comment,
                    Submitter = y.Submitter,
                    TimeSubmitted = y.TimeSubmitted
                }).ToList();
       
            }
            return posts;
        }

        public void RemovePost(int chatId)
        {
            throw new NotImplementedException();
        }
    }
}
