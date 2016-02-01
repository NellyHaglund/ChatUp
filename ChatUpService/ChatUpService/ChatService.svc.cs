using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;

namespace ChatUpService
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true, InstanceContextMode = InstanceContextMode.Single)]
    public class ChatService : IChatService
    {
        //VARJE FEL SOM KASTAS/SKER SKALL SPARAS UNDAN I EN LOGG
        public void SubmitPost(CustomPost post)
        {
            try
            {
                if (post == null) throw new Exception();
                using (var context = new ChatUp_DBEntities())
                {
                    var chatRooms = context.ChatRoom.Select(x => x.Id).ToList();
                    if (!chatRooms.Contains(post.ChatRoomId))
                    {
                        throw new FaultException("Chat Room not found");
                    }
                    var newPost = new Post
                    {
                        Submitter = post.Submitter,
                        ChatRoomId = post.ChatRoomId,
                        Comment = post.Comment,
                        TimeSubmitted = post.TimeSubmitted,
                        IsActive = post.IsActive
                    };
                    context.Post.Add(newPost);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                WriteToExceptionFile(ex);
                throw new FaultException<Exception>(ex);
            }
        }


        public ICollection<CustomPost> GetPosts(int chatRoomId)
        {
            try
            {
                List<CustomPost> posts = new List<CustomPost>();
                using (var context = new ChatUp_DBEntities())
                {
                    posts = context.Post.Where(x => x.ChatRoom.Id == chatRoomId).Select(y => new CustomPost
                    {
                        ChatRoomId = y.ChatRoomId,
                        Id = y.Id,
                        Comment = y.Comment,
                        Submitter = y.Submitter,
                        TimeSubmitted = y.TimeSubmitted,
                        IsActive = y.IsActive
                    }).ToList();
                }
                return posts;
            }
            catch (Exception ex)
            {
                WriteToExceptionFile(ex);
                throw new FaultException(ex.Message);
            }
        }

        public void RemovePost(int postId)
        {
            try
            {
                using (var context = new ChatUp_DBEntities())
                {
                    var query = (from p in context.Post
                        where p.Id == postId
                        select p).FirstOrDefault();
                    if (query == null) throw new FaultException("Post not found");

                    context.Post.Remove(query);
                    context.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                WriteToExceptionFile(exception);
                throw new FaultException(exception.Message);
            }
        }

        private static void WriteToExceptionFile(Exception ex)
        {
            var directory = @"C:\ExceptionFolder\";

            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            File.WriteAllText(Path.Combine(directory, "ExceptionLog.txt"), $"{ex.InnerException} @ {DateTime.Now}");
        }
    }
}