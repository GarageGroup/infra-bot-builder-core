using System;
using Microsoft.Bot.Builder;
using Microsoft.Extensions.Logging;

namespace GarageGroup.Infra.Bot.Builder;

public interface IBotContext
{
    ITurnContext TurnContext { get; }

    IBotFlow BotFlow { get; }

    UserState UserState { get; }

    ConversationState ConversationState { get; }

    IBotUserProvider BotUserProvider { get; }

    IBotTelemetryClient BotTelemetryClient { get; }

    ILoggerFactory LoggerFactory { get; }

    IServiceProvider ServiceProvider { get; }
}