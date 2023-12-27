using Volo.Abp.Modularity;

namespace HistoricalTrails;

[DependsOn(
    typeof(HistoricalTrailsDomainModule),
    typeof(HistoricalTrailsTestBaseModule)
)]
public class HistoricalTrailsDomainTestModule : AbpModule
{

}
