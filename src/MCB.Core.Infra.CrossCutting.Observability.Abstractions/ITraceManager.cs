using System.Diagnostics;

namespace MCB.Core.Infra.CrossCutting.Observability.Abstractions;

public interface ITraceManager
{
    // Constants
    public const string TENANT_ID_TAG_NAME = "tenantId";
    public const string EXECUTION_USER_TAG_NAME = "executionUser";
    public const string SOURCE_PLATFORM_TAG_NAME = "sourcePlatform";

    // Methods
    void StartActivity(
        string name,
        ActivityKind kind,
        Guid tenantId,
        string executionUser,
        string sourcePlatform,
        Action<Activity> handler,
        CancellationToken cancellationToken
    );
    void StartActivity<TInput>(
        string name,
        ActivityKind kind,
        Guid tenantId,
        string executionUser,
        string sourcePlatform,
        Action<TInput, Activity> handler,
        CancellationToken cancellationToken
    );
    void StartActivity<TInput, TOutput>(
        string name,
        ActivityKind kind,
        Guid tenantId,
        string executionUser,
        string sourcePlatform,
        Func<TInput, Activity, TOutput> handler,
        CancellationToken cancellationToken
    );

    Task StartActivityAsync(
        string name,
        ActivityKind kind,
        Guid tenantId,
        string executionUser,
        string sourcePlatform,
        Func<Activity, Task> handler,
        CancellationToken cancellationToken
    );
    Task StartActivityAsync<TInput>(
        string name,
        ActivityKind kind,
        Guid tenantId,
        string executionUser,
        string sourcePlatform,
        Func<TInput, Activity, Task> handler,
        CancellationToken cancellationToken
    );
    Task StartActivityAsync<TInput, TOutput>(
        string name,
        ActivityKind kind,
        Guid tenantId,
        string executionUser,
        string sourcePlatform,
        Func<TInput, Activity, Task<TOutput>> handler,
        CancellationToken cancellationToken
    );
}
