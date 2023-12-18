using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace PMS.Events {
    [ServiceContract(Name = "InhecoPMS", Namespace = "http://sila.coop")]
    public interface IEventReceiver {

        [OperationContract(Action = "http://sila.coop/DataEvent", ReplyAction = "http://sila.coop/DataEventResponse")]
        SiLAReturnValue DataEvent(int requestId, string dataValue);

        [OperationContract(Action = "http://sila.coop/ErrorEvent", ReplyAction = "http://sila.coop/ErrorEventResponse")]
        SiLAReturnValue ErrorEvent(int requestId, SiLAReturnValue returnValue, ref string continuationTask);

        [OperationContract(Action = "http://sila.coop/ResponseEvent", ReplyAction = "http://sila.coop/ResponseEventResponse")]
        SiLAReturnValue ResponseEvent(int requestId, SiLAReturnValue returnValue, string responseData);

        [OperationContract(Action = "http://sila.coop/StatusEvent", ReplyAction = "http://sila.coop/StatusEventResponse")]
        SiLAReturnValue StatusEvent(string deviceId, SiLAReturnValue returnValue, string eventDescription);
    }
}
