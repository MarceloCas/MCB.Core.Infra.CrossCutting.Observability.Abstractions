namespace MCB.Core.Infra.CrossCutting.Observability.Abstractions.Models;
public record Histogram(
    string Name,
    string? Description,
    string? Unity
);
