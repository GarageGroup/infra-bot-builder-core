namespace GGroupp.Infra.Bot.Builder;

partial struct BotFlowFailure
{
    public bool Equals(BotFlowFailure other)
        =>
        UserMessageComparer.Equals(UserMessage, other.UserMessage) &&
        LogMessageComparer.Equals(LogMessage, other.LogMessage);
}