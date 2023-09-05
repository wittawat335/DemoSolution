using DemoWebApp.Core.Models;

namespace DemoWebApp.FrontEnd.Services.Interfaces
{
    public interface IBaseApiService<T> where T : class
    {
        Task<ResponseApi<List<T>>> GetListAsync(string path);
        Task<ResponseApi<T>> GetAsyncById(string path);
        Task<ResponseApi<T>> InsertAsync(string path, T request);
        Task<ResponseApi<T>> PostAsync(string path, T request);
        Task<ResponseApi<T>> PostAsJsonAsync(string path, T request);
        Task<ResponseApi<T>> PutAsync(string path, T request);
        Task<ResponseApi<T>> PatchAsync(string path, T request);
        Task<ResponseApi<T>> DeleteAsync(string path);
    }
}
