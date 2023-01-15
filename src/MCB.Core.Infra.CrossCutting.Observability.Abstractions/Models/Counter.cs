namespace MCB.Core.Infra.CrossCutting.Observability.Abstractions.Models;

public record Counter(
    string Name,
    string? Description,
    string? Unity
);