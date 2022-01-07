using PayPalHttp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;

namespace PayPalCheckoutSdk.Subscriptions
{
    public class PlanGetRequest : HttpRequest
    {
        public PlanGetRequest(string OrderId) : base("/v1/billing/plans/{order_id}?", HttpMethod.Get, typeof(Plan))
        {
            try
            {
                this.Path = this.Path.Replace("{order_id}", Uri.EscapeDataString(Convert.ToString(OrderId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }
    }
}
