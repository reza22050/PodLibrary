using PodLibrary.Token;
using RestSharp;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace PodLibrary
{
    public class PodService
    {
        public string apiKey { get; private set; }
        public string secretKey { get; private set; }
        public PodService(string apiKey, string secretKey)
        {
            this.apiKey = apiKey;
            this.secretKey = secretKey;
        }

        public async Task<GetProductListResponse> GetProductList(int pageNumber, int pageSize)
        {
            long timeStamp = ((DateTimeOffset)DateTime.Now).ToUnixTimeSeconds();

            var xApiKey = ApiKeyGenerator.Generate_XApiKey(apiKey, timeStamp, secretKey);

            var options = new RestClientOptions("http://pod.rahpooyan.ir")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest($"/api/v1/store/products?page={pageNumber}&page_size={pageSize}", Method.Get);
            request.AddHeader("X-API-KEY", xApiKey);
            request.AddHeader("X-API-DATE-TIME", timeStamp);
            RestResponse response = await client.ExecuteAsync(request);
            var result = JsonSerializer.Deserialize<GetProductListResponse>(response.Content);
            return result;
        }

        public async Task<GetProductDetailResponse> GetProductDetail()
        {
            long timeStamp = ((DateTimeOffset)DateTime.Now).ToUnixTimeSeconds();

            var xApiKey = ApiKeyGenerator.Generate_XApiKey(apiKey, timeStamp, secretKey);

            var options = new RestClientOptions("http://pod.rahpooyan.ir")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/api/v1/store/products/pod-book-108-2-2/details", Method.Get);
            request.AddHeader("X-API-KEY", xApiKey);
            request.AddHeader("X-API-DATE-TIME", timeStamp);
            RestResponse response = await client.ExecuteAsync(request);
            var result = JsonSerializer.Deserialize<GetProductDetailResponse>(response.Content);
            return result;
        }

        public async Task<BaseDto<StoreProductUpdateEvent>> ProductHook(HttpRequestMessage request, string x_Api_Key, string apiDatetime)
        {
            string payloadJson = await request.Content.ReadAsStringAsync();
            string calcSign;
            using (var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(secretKey)))
            {
                calcSign = Convert.ToBase64String(hmac.ComputeHash(Encoding.UTF8.GetBytes(apiDatetime.ToString())));
            }

            var spilited = apiKey.Split(':');
            
            if (spilited.Length != 2) 
            {
                return new BaseDto<StoreProductUpdateEvent>(false, new List<string>() { "اطلاعات ارسال شده نامعتبر است" }, null);
            }
            else if(calcSign != spilited[1] || apiKey != spilited[0])
            {
                return new BaseDto<StoreProductUpdateEvent>(false, new List<string>() { "اطلاعات ارسال شده نامعتبر است" }, null);
            }

            var result = JsonSerializer.Deserialize<StoreProductUpdateEvent>(payloadJson);

            return new BaseDto<StoreProductUpdateEvent>(true, new List<string>() { "اطلاعات ارسال شده معتبر است" }, result);

        }

        public async Task<GetProductListResponse> CreateOrder(OrderRequest request)
        {
            long timeStamp = ((DateTimeOffset)DateTime.Now).ToUnixTimeSeconds();

            var xApiKey = ApiKeyGenerator.Generate_XApiKey(apiKey, timeStamp, secretKey);

            var options = new RestClientOptions("http://pod.rahpooyan.ir")
            {
                MaxTimeout = -1,
            };

            var client = new RestClient(options);
            var restRequest = new RestRequest("/api/v1/store/orders/create", Method.Post);
            
            restRequest.AddHeader("X-API-KEY", xApiKey);
            restRequest.AddHeader("X-API-DATE-TIME", timeStamp);

            var body = JsonSerializer.Serialize(request);
            restRequest.AddStringBody(body, DataFormat.Json);

            RestResponse response = await client.ExecuteAsync(restRequest);

            var result = JsonSerializer.Deserialize<GetProductListResponse>(response.Content);
            return result;


        }

        public async Task<GetOrderDetailResponse> GetOrderDetail(int orderId)
        {
            long timeStamp = ((DateTimeOffset)DateTime.Now).ToUnixTimeSeconds();

            var xApiKey = ApiKeyGenerator.Generate_XApiKey(apiKey, timeStamp, secretKey);

            var options = new RestClientOptions("http://pod.rahpooyan.ir")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest($"/api/v1/store/orders/{orderId}", Method.Get);
            request.AddHeader("X-API-KEY", xApiKey);
            request.AddHeader("X-API-DATE-TIME", timeStamp);
            RestResponse response = await client.ExecuteAsync(request);
            var result = JsonSerializer.Deserialize<GetOrderDetailResponse>(response.Content);
            return result;
        }

        public async Task<ShipmentMethodResponse> GetShipmentMethods()
        {
                long timeStamp = ((DateTimeOffset)DateTime.Now).ToUnixTimeSeconds();

                var xApiKey = ApiKeyGenerator.Generate_XApiKey(apiKey, timeStamp, secretKey);

                var options = new RestClientOptions("http://pod.rahpooyan.ir")
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/api/v1/store/orders/shipment-methods", Method.Get);
                request.AddHeader("X-API-KEY", xApiKey);
                request.AddHeader("X-API-DATE-TIME", timeStamp);
                RestResponse response = await client.ExecuteAsync(request);
                var result = JsonSerializer.Deserialize<ShipmentMethodResponse>(response.Content);
                return result;
        }

        public async Task<GetPaymentMethodsResponse> GetPaymentMethods()
        {
            long timeStamp = ((DateTimeOffset)DateTime.Now).ToUnixTimeSeconds();

            var xApiKey = ApiKeyGenerator.Generate_XApiKey(apiKey, timeStamp, secretKey);

            var options = new RestClientOptions("http://pod.rahpooyan.ir")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/api/v1/store/orders/payment-methods", Method.Get);
            request.AddHeader("X-API-KEY", xApiKey);
            request.AddHeader("X-API-DATE-TIME", timeStamp);
            RestResponse response = await client.ExecuteAsync(request);
            var result = JsonSerializer.Deserialize<GetPaymentMethodsResponse>(response.Content);
            return result;
        }

        public async Task<BaseDto<OrderHookResponse>> OrderHook(HttpRequestMessage request, string x_Api_Key, string apiDatetime)
        {
            string payloadJson = await request.Content.ReadAsStringAsync();
            string calcSign;
            using (var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(secretKey)))
            {
                calcSign = Convert.ToBase64String(hmac.ComputeHash(Encoding.UTF8.GetBytes(apiDatetime.ToString())));
            }

            var spilited = apiKey.Split(':');

            if (spilited.Length != 2)
            {
                return new BaseDto<OrderHookResponse>(false, new List<string>() { "اطلاعات ارسال شده نامعتبر است" }, null);
            }
            else if (calcSign != spilited[1] || apiKey != spilited[0])
            {
                return new BaseDto<OrderHookResponse>(false, new List<string>() { "اطلاعات ارسال شده نامعتبر است" }, null);
            }

            var result = JsonSerializer.Deserialize<OrderHookResponse>(payloadJson);

            return new BaseDto<OrderHookResponse>(true, new List<string>() { "اطلاعات ارسال شده معتبر است" }, result);

        }

    }
}
