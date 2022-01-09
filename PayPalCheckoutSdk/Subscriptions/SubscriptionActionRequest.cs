using PayPalCheckoutSdk.Payments;
using System.Runtime.Serialization;

namespace PayPalCheckoutSdk.Subscriptions
{

    [DataContract]
    public class SubscriptionActionRequest
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public SubscriptionActionRequest() { }


        /// <summary>
        /// The payment source definition.
        /// </summary>
        [DataMember(Name = "note", EmitDefaultValue = false)]
        public string note;


        /// <summary>
        /// The payment source definition.
        /// </summary>
        [DataMember(Name = "capture_type", EmitDefaultValue = false)]
        public string capture_type;


        /// <summary>
        /// The payment source definition.
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Money amount;


    }
}