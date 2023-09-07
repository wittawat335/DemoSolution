using Azure;
using DemoWebApp.Core.Models;
using DemoWebApp.FrontEnd.Services.Interfaces;
using DemoWebApp.FrontEnd.Utilities;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;

namespace DemoWebApp.FrontEnd.Services
{
    public class BaseApiService<T> : IBaseApiService<T> where T : class
    {
        private readonly ICommonService _commonService;
        HttpClientHandler _httpClient = new HttpClientHandler();

        public BaseApiService(ICommonService commonService)
        {
            _httpClient.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            _commonService = commonService;
        }

        public async Task<ResponseApi<List<T>>> GetListAsync(string path)
        {
            //var session = common.GetValueBySession();
            var session = _commonService.GetSessionValue();
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
            var session = _commonService.GetSessionValue();
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
            var session = _commonService.GetSessionValue();
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

        public async Task<ResponseApi<T>> PostAsJsonAsync(string path, T request)
        {
            var response = new ResponseApi<T>();
            var session = _commonService.GetSessionValue();
            try
            {
                using (var client = new HttpClient(_httpClient))
                {
                    client.BaseAddress = new Uri(path);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    if (session.AccessToken != null && session.AccessToken != "")
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", session.AccessToken);

                    HttpResponseMessage result = await client.PostAsJsonAsync<T>(path, request);
                    if (result.IsSuccessStatusCode)
                    {
                        string data = result.Content.ReadAsStringAsync().Result;
                        response = JsonConvert.DeserializeObject<ResponseApi<T>>(data);
                    }
                    else
                        response.Message = Constants.MessageError.CallAPI;
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
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
