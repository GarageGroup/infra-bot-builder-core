namespace GarageGroup.Infra.Bot.Builder;

public readonly partial struct BotFlowFailure
{
    public static BotFlowFailure From(string userMessage) => new(userMessage);
}