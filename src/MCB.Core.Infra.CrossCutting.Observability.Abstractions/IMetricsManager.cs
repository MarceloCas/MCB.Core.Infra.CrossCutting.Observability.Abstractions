using MCB.Core.Infra.CrossCutting.Observability.Abstractions.Models;
using System.Diagnostics.Metrics;

namespace MCB.Core.Infra.CrossCutting.Observability.Abstractions;

public interface IMetricsManager
{
    void CreateCounter<T>(string name, string? unit = null, string? description = null) where T : struct;
    IEnumerable<Counter> GetCounterCollection();
    void IncrementCounter<T>(string name, T delta) where T : struct;
    void IncrementCounter<T>(string name, T delta, params KeyValuePair<string, object?>[] tags) where T : struct;

    void CreateHistogram<T>(string name, string? unit = null, string? description = null) where T : struct;
    IEnumerable<Histogram> GetHistogramCollection();
    void RecordHistogram<T>(T value, KeyValuePair<string, object?> tag) where T : struct;

    void CreateObservableGauge<T>(string name, Func<IEnumerable<Measurement<T>>> observeValues, string? unit = null, string? description = null) where T : struct;
    IEnumerable<ObservableGauge> GetObservableGaugeCollection();
}
