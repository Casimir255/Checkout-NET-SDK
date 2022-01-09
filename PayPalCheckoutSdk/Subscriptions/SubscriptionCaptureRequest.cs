using PayPalHttp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;

namespace PayPalCheckoutSdk.Subscriptions
{
    public class SubscriptionCaptureRequest : HttpRequest
    {
        public SubscriptionCaptureRequest(string OrderId) : base("/v1/billing/subscriptions/{order_id}/capture?", HttpMethod.Post, typeof(Subscription))
        {
            try
            {
                this.Path = this.Path.Replace("{order_id}", Uri.EscapeDataString(Convert.ToString(OrderId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }
        public SubscriptionCaptureRequest PayPalClientMetadataId(string PayPalClientMetadataId)
        {
            this.Headers.Add("PayPal-Client-Metadata-Id", PayPalClientMetadataId);
            return this;
        }

        public SubscriptionCaptureRequest PayPalRequestId(string PayPalRequestId)
        {
            this.Headers.Add("PayPal-Request-Id", PayPalRequestId);
            return this;
        }

        public SubscriptionCaptureRequest Prefer(string Prefer)
        {
            this.Headers.Add("Prefer", Prefer);
            return this;
        }


        public SubscriptionCaptureRequest RequestBody(SubscriptionActionRequest OrderActionRequest)
        {
            this.Body = OrderActionRequest;
            return this;
        }

    }
}
