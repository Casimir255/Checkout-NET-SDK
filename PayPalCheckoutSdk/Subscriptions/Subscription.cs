using PayPalCheckoutSdk.Orders;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace PayPalCheckoutSdk.Subscriptions
{

    /// <summary>
    /// The order details.
    /// </summary>
    [DataContract]
    public class Subscription
    {

        public Subscription() { }


        /// <summary>
        /// The intent to either capture payment immediately or authorize a payment for an order after order creation.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string status;


        /// <summary>
        /// The intent to either capture payment immediately or authorize a payment for an order after order creation.
        /// </summary>
        [DataMember(Name = "status_update_time", EmitDefaultValue = false)]
        public string status_update_time;


        /// <summary>
        /// The intent to either capture payment immediately or authorize a payment for an order after order creation.
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string id;


        /// <summary>
        /// The intent to either capture payment immediately or authorize a payment for an order after order creation.
        /// </summary>
        [DataMember(Name = "plan_id", EmitDefaultValue = false)]
        public string plan_id;


        /// <summary>
        /// The intent to either capture payment immediately or authorize a payment for an order after order creation.
        /// </summary>
        [DataMember(Name = "start_time", EmitDefaultValue = false)]
        public string start_time;


        /// <summary>
        /// The intent to either capture payment immediately or authorize a payment for an order after order creation.
        /// </summary>
        [DataMember(Name = "subscriber", EmitDefaultValue = false)]
        public Subscriber subscriber;


        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/reference/api-responses/#hateoas-links). To complete payer approval, use the `approve` link with the `GET` method.
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<LinkDescription> Links;
    }
}
