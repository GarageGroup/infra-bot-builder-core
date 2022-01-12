using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Schema;

namespace GGroupp.Infra.Bot.Builder;

public interface IBotFlow
{
    ValueTask<Unit> NextAsync(CancellationToken cancellationToken);

    ValueTask<Unit> NextAsync(Activity nextActivity, CancellationToken cancellationToken);

    ValueTask<Unit> StartAsync(Activity activity, CancellationToken cancellationToken);

    ValueTask<Unit> EndAsync(CancellationToken cancellationToken);
}