namespace GarageGroup.Infra.Bot.Builder;

partial struct BotFlowFailure
{
    public static bool Equals(BotFlowFailure left, BotFlowFailure right)
        =>
        left.Equals(right);

    public static bool operator ==(BotFlowFailure left, BotFlowFailure right)
        =>
        left.Equals(right);

    public static bool operator !=(BotFlowFailure left, BotFlowFailure right)
        =>
        left.Equals(right) is false;

    public override bool Equals(object? obj)
        =>
        obj is BotFlowFailure other && Equals(other);
}