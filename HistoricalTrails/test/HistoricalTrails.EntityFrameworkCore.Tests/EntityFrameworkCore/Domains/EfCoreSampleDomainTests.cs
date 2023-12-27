using HistoricalTrails.Samples;
using Xunit;

namespace HistoricalTrails.EntityFrameworkCore.Domains;

[Collection(HistoricalTrailsTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<HistoricalTrailsEntityFrameworkCoreTestModule>
{

}
