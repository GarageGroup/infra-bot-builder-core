namespace GarageGroup.Infra.Bot.Builder;

public readonly partial struct BotFlowFailure
{
    public static BotFlowFailure From(string userMessage, string logMessage)
        =>
        new(userMessage, logMessage);
}