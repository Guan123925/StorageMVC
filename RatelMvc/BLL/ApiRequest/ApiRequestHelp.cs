using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using SDKClient;
using Newtonsoft.Json;
using System.Net.Http.Headers;
namespace BLL
{
    public static class ApiRequestHelp
    {
        static string BaseAddress = "http://localhost:8066";

        public static TResponse Post<TRequet, TResponse>(TRequet t) where TRequet : BaseRequest where TResponse : BaseResponse, new()
        {
            try
            {
                var api = t.GetApiName();//拿到接口的名称

                HttpClient client = new HttpClient();
                //设置 API的 基地址
                client.BaseAddress = new Uri(BaseAddress);
                //设置 默认请求头ACCEPT 
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //string token = ConfigurationManager.AppSettings["token"];
                //client.DefaultRequestHeaders.Add("token", token);

                //设置消息体
                HttpContent content = new StringContent(JsonConvert.SerializeObject(t));
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                //发送Post请求
                HttpResponseMessage msg = client.PostAsync(api, content).Result;
                //判断结果是否成功
                if (msg.IsSuccessStatusCode)
                {
                    var obj = JsonConvert.DeserializeObject<TResponse>(msg.Content.ReadAsStringAsync().Result);
                    if (obj.Status)
                    {
                        //表示请求成功
                        //返回响应结果
                        return obj;
                    }
                    else
                    {
                        return new TResponse() { Status = false, Message = obj.Message };
                    }

                }

                return new TResponse() { Status = false, Message = msg.ReasonPhrase };
            }
            catch (Exception ex)
            {

                return new TResponse() { Status = false, Message = ex.Message };
            }
        }
    }
}
