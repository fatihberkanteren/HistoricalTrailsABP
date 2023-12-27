using Volo.Abp.Modularity;

namespace HistoricalTrails;

/* Inherit from this class for your domain layer tests. */
public abstract class HistoricalTrailsDomainTestBase<TStartupModule> : HistoricalTrailsTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
