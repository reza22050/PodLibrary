using PodLibrary;
using PodLibrary.Dto;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PodService service = new PodService("i99e6qcei4jblvfc7nh78hh1sfn9ue91qa4lgikc1m5nkt8zzlde7pv5oflt", "00ad30de1da1b39f7e14bf78b5698960728148d5c5bbfa8a7e06b0aead911515");

         
            //var result = service.GetProductList(1,5);
            var result = service.GetPaymentMethods().Result;

            //var result = service.GetOrderDetail(1885).Result;


            //        var orderRequest = new OrderRequest
            //        {
            //            payment_method_id = 1,
            //            shipment_method_id = 2,
            //            use_store_default_address = true,
            //            currency = Currency.Rial,
            //            reference = "ORD12345",
            //            comment = "This is a sample order",
            //            items = new List<OrderItem>
            //    {
            //        new OrderItem
            //        {
            //        product_sku = "pod-book-108-2-2",
            //        quantity = 2,
            //        custom_note = "Handle with care",
            //        refrence = "REF123",
            //        comment = "Urgent"
            //    }
            //},
            //            store_customer = new StoreCustomer
            //            {
            //                reference = "CUST123",
            //                first_name = "John",
            //                last_name = "Doe",
            //                email = "john.doe@example.com",
            //                phone = "1234567890",
            //                mobile = "0987654321",
            //                sex = Sex.male,
            //                client_details = "Loyal"
            //            },
            //            store_order_shipment_address = new ShipmentAddress
            //            {
            //                first_name = "John",
            //                last_name = "Doe",
            //                mobile = "0987654321",
            //                telephone = "02112345678",
            //                address = "123 Main Street",
            //                state = "Tehran",
            //                city = "Tehran",
            //                postal_code = "1234567890",
            //                building_number = "12",
            //                unit = "34",
            //                latitude = "35.6892",
            //                longitude = "51.3890",
            //                comment = "Leave at the door"
            //            }
            //        };


            //        var result = service.CreateOrder(orderRequest).Result;



        }
    }
}
