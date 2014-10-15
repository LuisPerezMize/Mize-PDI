using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PDILibrary.Network
{
    public class NetworkCalls
    {
        #region Values

        public string RootURL { get; private set; }

        public static string Cookie { get; private set; }

        #endregion

        public NetworkCalls()
        {
            this.RootURL = "http://cctest.m-ize.com";
        }

        public async Task<Model.signin> DoLoginCall(string Username, string Password)
        {
            var result = new Model.signin();

            string URL = string.Format("{0}/signin", RootURL);

            var client = new HttpClient();
           
            string Post = new Engine.GetJsonString().GetLoginJsonPost(Username, Password);

            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.PostAsync(URL, new StringContent(Post, System.Text.Encoding.UTF8, "application/json"));

            if (response.IsSuccessStatusCode)
            {
                var Headers = response.Headers.ToList();
                if (Headers.Count > 1)
                {
                    var CookieList = Headers[2].Value.ToList();
                    Cookie = CookieList[0];
                    Cookie = new Engine.ParseCookie().ParseData(Cookie);
                }

                string JsonData = await response.Content.ReadAsStringAsync();
                result = Newtonsoft.Json.JsonConvert.DeserializeObject<Model.signin>(JsonData);
            }

            return result;
        }

        public async Task<Models.JsonSearchResult.meta> GetDownloads()
        {
            var result = new Models.JsonSearchResult.meta();

            string Post = new Engine.GetJsonString().GetSearchJsonPost();

            string URL = string.Format("{0}/generic/searchResults?pageIndex=0", RootURL);

            var cookieContainer = new CookieContainer();
 
            cookieContainer.Add(new Uri(URL), new Cookie("PLAY_SESSION", Cookie));
            
            var handler = new HttpClientHandler() { CookieContainer = cookieContainer };

            var client = new HttpClient(handler);

            Post = new Engine.GetJsonString().GetSearchJsonPost();

            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.PostAsync(URL, new StringContent(Post, System.Text.Encoding.UTF8, "application/json"));

            if (response.IsSuccessStatusCode)
            {
                string JsonData = await response.Content.ReadAsStringAsync();
                var data = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.JsonSearchResult.meta>(JsonData);
                result = data;
            }

            return result;
        }

        public async Task<Model.retrieve> GetInspection(string InspectionID)
        {
            string result = string.Empty;

            string URL = string.Format("{0}/inspectionForm?id={1}", RootURL, InspectionID);

            var cookieContainer = new CookieContainer();

            cookieContainer.Add(new Uri(URL), new Cookie("PLAY_SESSION", Cookie));

            var handler = new HttpClientHandler() { CookieContainer = cookieContainer };

            var client = new HttpClient(handler);

            try
            {
                result = await client.GetStringAsync(URL);

                var data = Newtonsoft.Json.JsonConvert.DeserializeObject<Model.retrieve>(result);

                return data;
            }
            catch (Exception error)
            {
                System.Diagnostics.Debug.WriteLine(error.Message);
                return null;
            }
        }
    }
}
