using DemoWebApp.Web.Services.Contracts;
using DemoWebApp.Web.Utilities;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;

namespace DemoWebApp.Web.Services
{
    public class BaseApiService<T> : IBaseApiService<T> where T : class
    {
        HttpClientHandler _httpClient = new HttpClientHandler();
        Common common = new Common();

        public BaseApiService()
        {
            _httpClient.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
        }

        public async Task<Response<List<T>>> GetListAsync(string path)
        {
            var session = common.GetValueBySession();
            var response = new Response<List<T>>();
            try
            {
                using (var client = new HttpClient(_httpClient))
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", session.AccessToken);
                    HttpResponseMessage result = await client.GetAsync(path);
                    if (result.IsSuccessStatusCode)
                    {
                        string data = result.Content.ReadAsStringAsync().Result;
                        response.Value = JsonConvert.DeserializeObject<List<T>>(data);
                        response.IsSuccess = Constants.StatusData.True;
                        response.Message = Constants.StatusMessage.InsertSuccess;
                    }
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<Response<T>> GetAsyncById(string path)
        {
            var session = common.GetValueBySession();
            var response = new Response<T>();
            try
            {
                using (var client = new HttpClient(_httpClient))
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", session.AccessToken);
                    HttpResponseMessage result = await client.GetAsync(path);
                    if (result.IsSuccessStatusCode)
                    {
                        string data = result.Content.ReadAsStringAsync().Result;
                        response = JsonConvert.DeserializeObject<Response<T>>(data);
                    }
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<Response<T>> InsertAsync(string path, T request)
        {
            var session = common.GetValueBySession();
            var response = new Response<T>();
            try
            {
                using (var client = new HttpClient(_httpClient))
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", session.AccessToken);
                    HttpResponseMessage result = await client.PostAsJsonAsync(path, request);

                    if (result.IsSuccessStatusCode)
                    {
                        string data = result.Content.ReadAsStringAsync().Result;
                        response = JsonConvert.DeserializeObject<Response<T>>(data);
                    }
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public Task<Response<T>> PatchAsync(string path, T request)
        {
            throw new NotImplementedException();
        }

        public Task<Response<T>> PostAsJsonAsync(string path, T request)
        {
            throw new NotImplementedException();
        }

        public Task<Response<T>> PostAsync(string path, T request)
        {
            throw new NotImplementedException();
        }

        public Task<Response<T>> PutAsync(string path, T request)
        {
            throw new NotImplementedException();
        }

        public Task<Response<T>> DeleteAsync(string path)
        {
            throw new NotImplementedException();
        }
    }
}
