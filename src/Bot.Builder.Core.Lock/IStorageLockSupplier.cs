using System.Threading;
using System.Threading.Tasks;

namespace GarageGroup.Infra.Bot.Builder;

public interface IStorageLockSupplier
{
    Task<StorageLockStatus> LockAsync(string key, CancellationToken cancellationToken = default);
}