using Volo.Abp.Modularity;

namespace HistoricalTrails;

public abstract class HistoricalTrailsApplicationTestBase<TStartupModule> : HistoricalTrailsTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
