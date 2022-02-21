using System.Net;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace DAL
{
    public class HttpHelper
    {
        /// <summary>
        /// 模拟浏览器请求WebAPI POST
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="dt">存储请求参数的字典</param>
        /// <returns></returns>
        public static string HttpPost(string url,Dictionary<string,string> dt)
        {
            using (var client = new HttpClient())
            {
                
                StringContent value=new StringContent(JsonConvert.SerializeObject(dt));
                value.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");//请求参数转换为json格式
                var response = client.PostAsync(url, value).Result;//获取请求结果
                string res="";
                if (response.IsSuccessStatusCode)
                {
                    var read = response.Content.ReadAsStringAsync();//读取返回内容
                    read.Wait();
                    res = read.Result;
                }
                else
                    return null;
                return res;
            }
        }

        /// <summary>
        /// 模拟浏览器请求WebAPI GET
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <returns></returns>
        public static string HttpGet(string url)
        {
            using (var client = new HttpClient())
            {
                var response= client.GetAsync(url).Result;
                string res = "";
                if (response.IsSuccessStatusCode)
                {
                    var read = response.Content.ReadAsStringAsync();
                    read.Wait();
                    res = read.Result;
                }
                else
                    return null;
                return res;
            }
        }

        /// <summary>
        /// 模拟浏览器请求WebAPI Delete
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string HttpDelete(string url)
        {
            using (var client = new HttpClient())
            {
                var response = client.DeleteAsync(url).Result;
                string res = "";
                if (response.IsSuccessStatusCode)
                {
                    var read = response.Content.ReadAsStringAsync();
                    read.Wait();
                    res = read.Result;
                }
                else
                    return null;
                return res;
            }
        }

        /// <summary>
        /// 模拟浏览器请求WebAPI POST 提交表单数据formdata
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="dt">存储请求参数的字典</param>
        /// <returns></returns>
        public static string HttpPostFormData(string url,Dictionary<string,string> dt)
        {
            var mfdc = new System.Net.Http.MultipartFormDataContent();
            mfdc.Headers.Add("ContentType", "multipart/form-data");//声明头部
            /*
            mfdc.Add(new System.Net.Http.StringContent("aa"), "param1");//参数, 内容在前,参数名称在后
            mfdc.Add(new System.Net.Http.StringContent("bb"), "param2");
            */
            foreach(KeyValuePair<string,string> kvp in dt)
            {
                mfdc.Add(new System.Net.Http.StringContent(kvp.Key), kvp.Value);
            }
            var clientTask = new System.Net.Http.HttpClient().PostAsync(url, mfdc);//发起异步请求
            clientTask.Wait();//等待请求结果
            if (clientTask.Result.IsSuccessStatusCode)
            {
                //请求正常
                var resultTask = clientTask.Result.Content.ReadAsStringAsync();//异步读取返回内容
                resultTask.Wait();//等读取返回内容
                var resultStr = resultTask.Result;//返回内容字符串
                return resultStr;
            }
            else
            {
                //请求异常
                return null;
            }
        }
    }
}