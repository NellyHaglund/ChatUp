using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ChatService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IChatService
    {
        [OperationContract]
        void SubmitChat(Post post);

        [OperationContract]
        ICollection<Post> GetPosts(int chatRoomId);

        [OperationContract]
        void RemovePost(int postId);
    }
}
