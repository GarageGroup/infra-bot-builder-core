using System;

namespace GarageGroup.Infra.Bot.Builder;

partial struct BotFlowFailure
{
    private static Type EqualityContract
        =>
        typeof(BotFlowFailure);

    private static StringComparer UserMessageComparer
        =>
        StringComparer.Ordinal;

    private static StringComparer LogMessageComparer
        =>
        StringComparer.Ordinal;
}