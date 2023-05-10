using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;

namespace GarageGroup.Infra.Bot.Builder;

public interface IBotBuilder
{
    IBotBuilder Use(Func<IBotContext, CancellationToken, ValueTask<Unit>> middleware);

    IBot Build();

    IBot Build(
        bool useLocking,
        string? lockingMessage = null);
}