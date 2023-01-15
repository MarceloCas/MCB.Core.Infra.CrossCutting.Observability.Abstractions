namespace MCB.Core.Infra.CrossCutting.Observability.Abstractions.Models;

public record ObservableGauge(
    string Name,
    string? Description,
    string? Unity
);
