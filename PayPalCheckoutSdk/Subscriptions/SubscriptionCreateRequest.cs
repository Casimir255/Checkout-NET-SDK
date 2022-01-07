using PayPalHttp;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace PayPalCheckoutSdk.Subscriptions
{
    public class SubscriptionCreateRequest : HttpRequest
    {
        public SubscriptionCreateRequest() : base("/v1/billing/subscriptions?", HttpMethod.Post, typeof(Subscription))
        {
            this.ContentType = "application/json";
        }
        public SubscriptionCreateRequest PayPalPartnerAttributionId(string PayPalPartnerAttributionId)
        {
            this.Headers.Add("PayPal-Partner-Attribution-Id", PayPalPartnerAttributionId);
            return this;
        }

        public SubscriptionCreateRequest Prefer(string Prefer)
        {
            this.Headers.Add("Prefer", Prefer);
            return this;
        }


        public SubscriptionCreateRequest RequestBody(SubscriptionRequest Order)
        {
            this.Body = Order;
            return this;
        }

    }
}
