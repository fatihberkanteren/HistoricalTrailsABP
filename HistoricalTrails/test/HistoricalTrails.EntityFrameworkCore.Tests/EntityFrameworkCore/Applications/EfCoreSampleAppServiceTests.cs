using HistoricalTrails.Samples;
using Xunit;

namespace HistoricalTrails.EntityFrameworkCore.Applications;

[Collection(HistoricalTrailsTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<HistoricalTrailsEntityFrameworkCoreTestModule>
{

}
