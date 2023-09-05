using Dapper;
using DemoWebApp.Core.Domain.RepositoryContracts;
using DemoWebApp.Core.Models.ReceiveCar;
using DemoWebApp.Infrastructure.DBContexts;
using System.Data;

namespace DemoWebApp.Infrastructure.Repositories
{
    public class ReceiveCarRepository : IReceiveCarRepository
    {
        private readonly NCLS_SITContext _context;
        private readonly DapperContext _dapperContext;

        public ReceiveCarRepository(
            NCLS_SITContext context, DapperContext dapperContext)
        {
            _context = context;
            _dapperContext = dapperContext;
        }

        public async Task<List<SP_SEARCH_RC_Result>> GetAllBySp(SearchModel model)
        {
            DateTime? from = null;
            DateTime? to = null;
            if (model.assignDateForm != null &&
                model.assignDateTo != null)
            {
                from = DateTime
                      .ParseExact(model.assignDateForm,
                      "dd/MM/yyyy", null);
                to = DateTime
                      .ParseExact(model.assignDateTo,
                      "dd/MM/yyyy", null);
            }

            try
            {
                using (var connection =
                  _dapperContext.CreateConnection())
                {
                    var procedure = "SP_SEARCH_RC";
                    var parameters = new DynamicParameters
                        (new
                        {
                            REF_NO = model.refNo,
                            CONTRACT_NO = model.contractNo,
                            CUST_NAME = model.borrowerName,
                            STATUS = model.status,
                            ADMIN = model.admin,
                            OA_CODE = model.legal,
                            ASSIGN_DATE_FROM = from,
                            ASSIGN_DATE_TO = to,
                            ADMIN_CODE = "",
                            ROLE_CODE = "",
                            DATASTATUS = model.status
                        });
                    var results = await connection
                        .QueryAsync<SP_SEARCH_RC_Result>(
                        procedure,
                        parameters,
                        commandType: CommandType.StoredProcedure);

                    return results.ToList();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
