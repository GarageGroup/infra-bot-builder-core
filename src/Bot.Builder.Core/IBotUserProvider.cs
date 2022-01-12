using System;
using System.Threading;
using System.Threading.Tasks;

namespace GGroupp.Infra.Bot.Builder;

public interface IBotUserProvider : IAsyncValueFunc<Unit, Result<BotUser, Unit>>, IAsyncValueFunc<BotUser?, Unit>
{
    ValueTask<Unit> SetCurrentUserAsync(BotUser? user, CancellationToken cancellationToken);

    ValueTask<BotUser?> GetCurrentUserAsync(CancellationToken cancellationToken);

    ValueTask<Unit> IAsyncValueFunc<BotUser?, Unit>.InvokeAsync(BotUser? user, CancellationToken token)
        =>
        SetCurrentUserAsync(user, token);

    async ValueTask<Result<BotUser, Unit>> IAsyncValueFunc<Unit, Result<BotUser, Unit>>.InvokeAsync(Unit _, CancellationToken token)
    {
        var user = await GetCurrentUserAsync(token).ConfigureAwait(false);
        return user is not null ? Result.Present(user) : default;
    }
}