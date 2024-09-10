using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Test.Dto
{
    public class OrderItem
    {
        public string product_sku { get; set; }

            
        [Range(1, int.MaxValue, ErrorMessage = "حداقل مقدار 1 باید باشد")]
        public int quantity { get; set; }
        
        public string? custom_note { get; set; }

        [MaxLength(100)]
        public string? refrence { get; set; }

        [MaxLength(250)]
        public string? comment { get; set; }
    }

    public class OrderRequest
    {
        public int payment_method_id { get; set; }
        public int shipment_method_id { get; set; }
        public bool use_store_default_address { get; set; }


        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Currency currency { get; set; }


        [MaxLength(100)]    
        public string reference { get; set; }

        [MaxLength(250)]
        public string comment { get; set; }
        public List<OrderItem> items { get; set; }

        public List<StoreCustomer> store_customer { get; set; }
       
        public List<ShipmentAddress> store_order_shipment_address { get; set; }
    }

    public class ShipmentAddress
    {
        [MaxLength(100)]    
        public string? first_name { get; set; }

        [MaxLength(100)]
        public string? last_name { get; set; }

        [MaxLength(11)]
        public string? mobile { get; set; }

        [MaxLength(10)]
        public string? telephone { get; set; }

        [MaxLength(255)]
        public string? address { get; set; }

        [MaxLength(50)]
        public string? state { get; set; }

        [MaxLength(50)]
        public string? city { get; set; }

        [MaxLength(20)]
        public string? postal_code { get; set; }

        [MaxLength(10)]
        public string? building_number { get; set; }

        [MaxLength(10)]
        public string? unit { get; set; }
        
        [MaxLength (100)]           
        public string? latitude { get; set; }

        [MaxLength(100)]
        public string? longitude { get; set; }

        [MaxLength(255)]
        public string? comment { get; set; }
    }

    public class StoreCustomer
    {
        [MaxLength(100)]
        public string? reference { get; set; }

        [MaxLength(100)]
        public string? first_name { get; set; }

        
        [MaxLength(100)]
        public string? last_name { get; set; }

        [MaxLength(150)]
        public string? email { get; set; }

        [MaxLength(15)]
        public string? phone { get; set; }

        [MaxLength(15)]
        public string? mobile { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Sex? sex { get; set; }

        [MaxLength(15)]
        public string? client_details { get; set; }

    }

    public enum Sex
    {
        Male,
        Female,
        Unknown
    }

    public enum Currency
    {
        Rial
    }
}
