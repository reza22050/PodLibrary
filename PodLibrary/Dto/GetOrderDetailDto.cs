using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodLibrary
{

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class OrderDetailData
    {
        [JsonProperty("api_key.is_test")]
        public int api_keyis_test { get; set; }
        public int store_id { get; set; }
        public int api_key_id { get; set; }
        public Order order { get; set; }
    }

    public class OrderDetailItem
    {
        public int order_id { get; set; }
        public string item_title { get; set; }
        public int item_id { get; set; }
        public string item_type { get; set; }
        public string sku { get; set; }
        public int variant_id { get; set; }
        public int quantity { get; set; }
        public int unit_price { get; set; }
        public int unit_tax_rate { get; set; }
        public int total_tax { get; set; }
        public int item_discount { get; set; }
        public int item_total { get; set; }
        public int item_payable_amount { get; set; }
        public int original_unit_price { get; set; }
        public int total_weight { get; set; }
        public int total_height { get; set; }
        public int total_width { get; set; }
        public int total_length { get; set; }
        public Metas metas { get; set; }
    }

    public class Metas
    {
        public string reference { get; set; }
        public string customer_reference { get; set; }
        public string comment { get; set; }
    }

    public class Order
    {
        public int id { get; set; }
        public int is_test { get; set; }
        public string reference { get; set; }
        public string channel { get; set; }
        public int shipment_method_id { get; set; }
        public int payment_method_id { get; set; }
        public object auto_discount_id { get; set; }
        public object auto_discount_codes { get; set; }
        public object discount_id { get; set; }
        public object discount_codes { get; set; }
        public int items_payable { get; set; }
        public int items_tax { get; set; }
        public int items_discount { get; set; }
        public int total_cost { get; set; }
        public int total_weight { get; set; }
        public string financial_status { get; set; }
        public int changed { get; set; }
        public int return_days { get; set; }
        public int deliver_days_estimation { get; set; }
        public string status { get; set; }
        public object ordered_at { get; set; }
        public Metas metas { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string created_at_p { get; set; }
        public List<OrderDetailItem> items { get; set; }
    }

    public class GetOrderDetailResponse
    {
        public bool success { get; set; }
        public int status { get; set; }
        public List<object> errors { get; set; }
        public string message { get; set; }
        public List<object> validation_errors { get; set; }
        public OrderDetailData data { get; set; }
    }



}
