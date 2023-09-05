using DemoWebApp.Core.Models;
using DemoWebApp.FrontEnd.Services.Interfaces;
using DemoWebApp.FrontEnd.Utilities;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace DemoWebApp.FrontEnd.Services
{
    public class BaseApiService<T> : IBaseApiService<T> where T : class
    {
        HttpClientHandler _httpClient = new HttpClientHandler();
        Common common = new Common();

        public BaseApiService()
        {
            _httpClient.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
        }

        public async Task<ResponseApi<List<T>>> GetListAsync(string path)
        {
            var session = common.GetValueBySession();
            var response = new ResponseApi<List<T>>();
            try
            {
                using (var client = new HttpClient(_httpClient))
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", session.AccessToken);
                    HttpResponseMessage result = await client.GetAsync(path);
                    if (result.IsSuccessStatusCode)
                    {
                        string data = result.Content.ReadAsStringAsync().Result;
                        response = JsonConvert.DeserializeObject<ResponseApi<List<T>>>(data);
                    }
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<ResponseApi<T>> GetAsyncById(string path)
        {
            var session = common.GetValueBySession();
            var response = new ResponseApi<T>();
            try
            {
                using (var client = new HttpClient(_httpClient))
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", session.AccessToken);
                    HttpResponseMessage result = await client.GetAsync(path);
                    if (result.IsSuccessStatusCode)
                    {
                        string data = result.Content.ReadAsStringAsync().Result;
                        response = JsonConvert.DeserializeObject<ResponseApi<T>>(data);
                    }
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<ResponseApi<T>> InsertAsync(string path, T request)
        {
            var session = common.GetValueBySession();
            var response = new ResponseApi<T>();
            try
            {
                using (var client = new HttpClient(_httpClient))
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", session.AccessToken);
                    HttpResponseMessage result = await client.PostAsJsonAsync(path, request);

                    if (result.IsSuccessStatusCode)
                    {
                        string data = result.Content.ReadAsStringAsync().Result;
                        response = JsonConvert.DeserializeObject<ResponseApi<T>>(data);
                    }
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public Task<ResponseApi<T>> PatchAsync(string path, T request)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseApi<T>> PostAsJsonAsync(string path, T request)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseApi<T>> PostAsync(string path, T request)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseApi<T>> PutAsync(string path, T request)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseApi<T>> DeleteAsync(string path)
        {
            throw new NotImplementedException();
        }
    }
}
