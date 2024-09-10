using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodLibrary
{

    public class PaymentMethodData
    {
        [JsonProperty("api_key.is_test")]
        public int api_keyis_test { get; set; }
        public int store_id { get; set; }
        public int api_key_id { get; set; }
        public List<PaymentMethodDto> payment_methods { get; set; }
    }

    public class PaymentMethodDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public int active { get; set; }
        public List<object> config { get; set; }
    }

    public class GetPaymentMethodsResponse
    {
        public bool success { get; set; }
        public int status { get; set; }
        public List<object> errors { get; set; }
        public string message { get; set; }
        public List<object> validation_errors { get; set; }
        public PaymentMethodData data { get; set; }
    }


}
