using DemoWebApp.Core.Models.ReceiveCar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebApp.Core.Domain.RepositoryContracts
{
    public interface IReceiveCarRepository
    {
        Task<List<SP_SEARCH_RC_Result>> GetAllBySp(SearchModel model);
    }
}
