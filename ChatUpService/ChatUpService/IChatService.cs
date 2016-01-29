using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace ChatUpService
{
    [ServiceContract]
    public interface IChatService
    {
        [OperationContract]
        [FaultContract(typeof (FaultException))]
        void SubmitPost(CustomPost post);
        [OperationContract]
        [FaultContract(typeof (FaultException))]
        ICollection<CustomPost> GetPosts(int chatId);
        [OperationContract]
        [FaultContract(typeof (FaultException))]
        void RemovePost(int postId);
    }

}