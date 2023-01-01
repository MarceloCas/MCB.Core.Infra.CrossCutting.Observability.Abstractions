using System.Diagnostics;

namespace MCB.Core.Infra.CrossCutting.Observability.Abstractions;

public interface ITraceManager
{
    // Constants
    public const string CORRELATION_ID_TAG_NAME = "correlationId";
    public const string TENANT_ID_TAG_NAME = "tenantId";
    public const string EXECUTION_USER_TAG_NAME = "executionUser";
    public const string SOURCE_PLATFORM_TAG_NAME = "sourcePlatform";

    // Methods
    void StartActivity(
        string name,
        ActivityKind kind,
        Guid correlationId,
        Guid tenantId,
        string executionUser,
        string sourcePlatform,
        Action<Activity> handler
    );
    void StartActivity<TInput>(
        string name,
        ActivityKind kind,
        Guid correlationId,
        Guid tenantId,
        string executionUser,
        string sourcePlatform,
        Action<TInput, Activity> handler
    );
    void StartActivity<TInput, TOutput>(
        string name,
        ActivityKind kind,
        Guid correlationId,
        Guid tenantId,
        string executionUser,
        string sourcePlatform,
        Func<TInput, Activity, TOutput> handler
    );

    Task StartActivityAsync(
        string name,
        ActivityKind kind,
        Guid correlationId,
        Guid tenantId,
        string executionUser,
        string sourcePlatform,
        Func<Activity, CancellationToken, Task> handler,
        CancellationToken cancellationToken
    );
    Task StartActivityAsync<TInput>(
        string name,
        ActivityKind kind,
        Guid correlationId,
        Guid tenantId,
        string executionUser,
        string sourcePlatform,
        Func<TInput, Activity, CancellationToken, Task> handler,
        CancellationToken cancellationToken
    );
    Task StartActivityAsync<TInput, TOutput>(
        string name,
        ActivityKind kind,
        Guid correlationId,
        Guid tenantId,
        string executionUser,
        string sourcePlatform,
        Func<TInput, Activity, CancellationToken, Task<TOutput>> handler,
        CancellationToken cancellationToken
    );
}
