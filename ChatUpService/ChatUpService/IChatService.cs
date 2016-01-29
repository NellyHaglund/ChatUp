using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace ChatUpService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IChatService
    {
        [OperationContract]
        [FaultContract(typeof (ApplicationException))]
        void SubmitPost(CustomPost post);
        [OperationContract]
        [FaultContract(typeof (ApplicationException))]
        ICollection<CustomPost> GetPosts(int chatId);
        [OperationContract]
        [FaultContract(typeof (ApplicationException))]
        void RemovePost(int chatId);
    }

}