using DemoWebApp.Core.Models;
using DemoWebApp.Core.Models.Dashboard;

namespace DemoWebApp.Core.Services.Contracts
{
    public interface IDashboardService
    {
        Task<ResponseApi<List<ChartsSP>>> GetChartsR3();
        Task<ResponseApi<List<ChartsSP>>> GetChartsRepo();
        Task<ResponseApi<List<object>>> GetTotal();
        Task<ResponseApi<List<Charts>>> ChartsR3();
        Task<ResponseApi<List<Charts>>> ChartsRepo();
    }
}
