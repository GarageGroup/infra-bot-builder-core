using System;

namespace GarageGroup.Infra.Bot.Builder;

public readonly partial struct BotFlowFailure : IEquatable<BotFlowFailure>
{
    private readonly string? userMessage, logMessage;

    public BotFlowFailure(string userMessage, string logMessage)
    {
        this.userMessage = string.IsNullOrEmpty(userMessage) ? default : userMessage;
        this.logMessage = string.IsNullOrEmpty(logMessage) ? default : logMessage;
    }

    public BotFlowFailure(string userMessage)
    {
        this.userMessage = string.IsNullOrEmpty(userMessage) ? default : userMessage;
        logMessage = default;
    }

    public string UserMessage => userMessage ?? string.Empty;

    public string LogMessage => logMessage ?? string.Empty;

    public Exception? SourceException { get; init; } = null;
}