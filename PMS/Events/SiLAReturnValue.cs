using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PMS.Events {

    [DataContract(Namespace = "http://sila.coop")]
    public sealed class SiLAReturnValue {
        [DataMember(Name = "deviceClass", IsRequired = true, Order = 4)]
        public int deviceClass { get; private set; }

        [DataMember(IsRequired = true, Order = 1)]
        public int returnCode { get; private set; }

        [DataMember(IsRequired = true, Order = 2)]
        public string message { get; private set; }

        [DataMember(IsRequired = true, Order = 3)]
        public string duration { get; private set; }

        public SiLAReturnValue(int returnCode, string message, string duration, int deviceClass) {
            this.returnCode = returnCode;
            this.message = message;
            this.duration = duration;
            this.deviceClass = deviceClass;
        }

    }
}
