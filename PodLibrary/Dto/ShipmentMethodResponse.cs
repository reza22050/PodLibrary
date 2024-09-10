using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodLibrary
{
    public class ShipmentMethodData
    {
        [JsonProperty("api_key.is_test")]
        public int api_keyis_test { get; set; }
        public int store_id { get; set; }
        public int api_key_id { get; set; }
        public List<PaymentMethod> payment_methods { get; set; }
    }

    public class PaymentMethod
    {
        public int id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public int active { get; set; }
        public string description { get; set; }
        public int average_shipping_time { get; set; }
        public int price { get; set; }
        public int size_limit { get; set; }
        public int weight_limit { get; set; }
        public int? tax_percent { get; set; }
        public int? discount_percent { get; set; }
        public List<object> config { get; set; }
    }

    public class ShipmentMethodResponse
    {
        public bool success { get; set; }
        public int status { get; set; }
        public List<object> errors { get; set; }
        public string message { get; set; }
        public List<object> validation_errors { get; set; }
        public ShipmentMethodData data { get; set; }
    }



}
