using System.Threading.Tasks;
using NecCms.Database;

namespace NecCms.Logger
{
    public interface ILoggerService
    {
        Task SaveLog(CustomLogger logger);
    }
    public class LoggerService : ILoggerService
    {
        private readonly CrmContext _dbContext = new CrmContext();
        public async Task SaveLog(CustomLogger logger)
        {
#if !DEBUG
            await _dbContext.Set<CustomLogger>().AddAsync(logger);
            await _dbContext.SaveChangesAsync();
#endif
        }
    }
}