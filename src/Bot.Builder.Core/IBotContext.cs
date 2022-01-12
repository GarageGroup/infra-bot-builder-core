using System;
using Microsoft.Bot.Builder;
using Microsoft.Extensions.Logging;

namespace GGroupp.Infra.Bot.Builder;

public interface IBotContext
{
    ITurnContext TurnContext { get; }

    IBotFlow BotFlow { get; }

    UserState UserState { get; }

    ConversationState ConversationState { get; }

    IBotUserProvider BotUserProvider { get; }

    ILoggerFactory LoggerFactory { get; }

    IServiceProvider ServiceProvider { get; }
}