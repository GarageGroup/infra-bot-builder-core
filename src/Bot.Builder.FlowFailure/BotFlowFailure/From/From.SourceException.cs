using System;

namespace GarageGroup.Infra.Bot.Builder;

public readonly partial struct BotFlowFailure
{
    public static BotFlowFailure From(string userMessage, string logMessage, Exception? sourceException)
        =>
        new(userMessage, logMessage)
        {
            SourceException = sourceException
        };
}