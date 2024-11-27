using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient.Memcached;

namespace eguidanceV2.modules
{
    public class ApiHelper
    {
        private void Initialize()
        {
            BaseClient clientbase = new BaseClient("https://my.mu.edu.ph/api", "admin", "kokey12345!@#");
            BaseResponse response = new BaseResponse();
           // BaseResponse newresponse = clientbase.GetCallV2Async("Candidate").Result;
        }
     


        //public async Task<BaseResponse> GetCallAsync(string endpoint)
        //{
        //    //try
        //    //{
        //    //    HttpResponseMessage myresponse = await client.GetAsync(endpoint + "/").ConfigureAwait(false);
        //    //    if (response.IsSuccessStatusCode)
        //    //    {
        //    //        baseresponse.ResponseMessage = await response.Content.ReadAsStringAsync();
        //    //        baseresponse.StatusCode = (int)response.StatusCode;
        //    //    }
        //    //    else
        //    //    {
        //    //        baseresponse.ResponseMessage = await response.Content.ReadAsStringAsync();
        //    //        baseresponse.StatusCode = (int)response.StatusCode;
        //    //    }
        //    //    return baseresponse;
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    baseresponse.StatusCode = 0;
        //    //    baseresponse.ResponseMessage = (ex.Message ?? ex.InnerException.ToString());
        //    //}
        //    //return baseresponse;
        //}
    }

    public class BaseResponse
    {
        public int StatusCode { get; set; }
        public string ResponseMessage { get; set; }
    }

    public class BaseClient
    {
        readonly HttpClient client;
        readonly BaseResponse baseresponse;

        public BaseClient(string baseAddress, string username, string password)
        {
            HttpClientHandler handler = new HttpClientHandler()
            {
                Proxy = new WebProxy("http://127.0.0.1:8888"),
                UseProxy = false,
            };

            client = new HttpClient(handler);
            client.BaseAddress = new Uri(baseAddress);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var byteArray = Encoding.ASCII.GetBytes(username + ":" + password);

            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

            baseresponse = new BaseResponse();

        }
    }


}
