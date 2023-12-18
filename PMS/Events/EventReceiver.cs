using System;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Xml.Serialization;
using PMS.Response;

namespace PMS.Events {

    [ServiceBehavior(Namespace = "http://sila.coop")]
    public class EventReceiver : IEventReceiver {

        // The event receiver address used by SiLA Reset command
        public static string EventReceiverURI { get; private set; }


        // static ctor
        // hosts the SiLA event receiver web service (.net wcf self-hosting)
        static EventReceiver() {
            UriBuilder builder = new UriBuilder();
            builder.Scheme = "http";
            builder.Host = System.Net.Dns.GetHostName();
            builder.Port = 8080;
            builder.Path = "ihc";
            Uri baseAddress = builder.Uri;

            EventReceiverURI = baseAddress.ToString();

            ServiceHost host = new ServiceHost(typeof(EventReceiver), baseAddress);

            ServiceMetadataBehavior metad = new ServiceMetadataBehavior();
            metad.HttpGetEnabled = true;
            host.Description.Behaviors.Add(metad);

            // custom binding, we change default values
            BasicHttpBinding binding = new BasicHttpBinding();
            binding.MaxBufferPoolSize = 3145728;
            binding.MaxBufferSize = 3145728;
            binding.MaxReceivedMessageSize = 3145728;
            host.AddServiceEndpoint(typeof(IEventReceiver), binding, baseAddress);
            
            host.Open();
        }


        // The "standard" event, called by any asynchronous SiLA command when finished
        public SiLAReturnValue ResponseEvent(int requestId, SiLAReturnValue returnValue, string responseData) {
            Form1.Log("ResponseEvent received:");
            Form1.Log(responseData);

            if (returnValue.returnCode != 3) {
                System.Windows.Forms.MessageBox.Show("Unexpected Asynchronous ReturnCode received: " + returnValue.returnCode + "\n" + "Message: " + returnValue.message);
            }

            // TODO you should validate responseData against ResponseType_1.2.xsd
            XmlSerializer serializer = new XmlSerializer(typeof(ResponseData));
            
            // deserialize responseData string to object
            ResponseData data;
            using (TextReader reader = new StringReader(responseData)) {
                data = serializer.Deserialize(reader) as ResponseData;
                // useful for GetParameters, GetConfiguration, ...
            }
            // ...

            return new SiLAReturnValue(1, "Success", "PT0S", 0);

        }


        // ODTC will call this when warning occour and provide additional informations
        public SiLAReturnValue StatusEvent(string deviceId, SiLAReturnValue returnValue, string eventDescription) {
            Form1.Log("StatusEvent received:");
            Form1.Log(eventDescription);
            return new SiLAReturnValue(1, "Success", "PT0S", 0);

            // TODO deserialize eventDespription (see Spezification for XSD)
        }


        // ODTC will call this in while invoking ExecuteMethod
        public SiLAReturnValue DataEvent(int requestId, string dataValue) {
            Form1.Log("DataEvent received:");
            Form1.Log(dataValue);
            SiLAReturnValue returnValue = new SiLAReturnValue(1, "Success", "PT0S", 0);
            return returnValue;
        }


        // Not invoked by ODTC
        public SiLAReturnValue ErrorEvent(int requestId, SiLAReturnValue returnValue, ref string continuationTask) {
            return new SiLAReturnValue(1, "Success", "PT0S", 0);
        }
    }

}
