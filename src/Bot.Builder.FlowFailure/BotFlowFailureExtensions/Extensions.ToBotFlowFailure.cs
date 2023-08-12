using System;
using System.Diagnostics.CodeAnalysis;

namespace GarageGroup.Infra.Bot.Builder;

partial class BotFlowFailureExtensions
{
    public static BotFlowFailure ToBotFlowFailure([AllowNull] this Exception sourceException, string userMessage, string logMessage)
        =>
        new(userMessage, logMessage)
        {
            SourceException = sourceException
        };
}