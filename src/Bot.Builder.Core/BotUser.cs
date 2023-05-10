using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace GarageGroup.Infra.Bot.Builder;

public sealed record class BotUser
{
    public BotUser(
        Guid id,
        [AllowNull] string mail = default,
        [AllowNull] string displayName = default,
        FlatArray<KeyValuePair<string, string>> claims = default)
    {
        Id = id;
        Mail = mail ?? string.Empty;
        DisplayName = displayName ?? string.Empty;
        Claims = claims;
    }

    public Guid Id { get; }

    public string Mail { get; }

    public string DisplayName { get; }

    public FlatArray<KeyValuePair<string, string>> Claims { get; }
}